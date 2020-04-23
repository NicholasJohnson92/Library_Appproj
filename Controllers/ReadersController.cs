using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Library_App.Data;
using Library_App.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Library_App.Services;

namespace Library_App.Controllers
{
    [Authorize(Roles = "Reader")]
    public class ReadersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly GoodReadsReq _goodReadsReq;

        public ReadersController(ApplicationDbContext context, GoodReadsReq goodReadsReq)
        {
            _context = context;
            _goodReadsReq = goodReadsReq;
        }

        // GET: Readers
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            Reader reader = await _context.Readers.Where(s => s.IdentityUserId == userId).FirstOrDefaultAsync();
            GetShelves(reader.ReaderId);
            return View(reader);

        }

        // GET: Readers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var books = await _context.Books.Where(s => s.Shelf_ID == id).ToListAsync();
            if (books == null)
            {
                return NotFound();
            }

            return View(books);
        }

        // GET: Readers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Readers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReaderId,First_Name,Last_Name,Zipcode")] Reader reader)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                reader.IdentityUserId = userId;
                _context.Add(reader);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reader);
        }

        // GET: Readers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reader = await _context.Readers.FindAsync(id);
            if (reader == null)
            {
                return NotFound();
            }
            return View(reader);
        }

        // POST: Readers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReaderId,First_Name,Last_Name,Zipcode")] Reader reader)
        {
            if (id != reader.ReaderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reader);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReaderExists(reader.ReaderId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(reader);
        }

        // GET: Readers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reader = await _context.Readers
                .FirstOrDefaultAsync(m => m.ReaderId == id);
            if (reader == null)
            {
                return NotFound();
            }

            return View(reader);
        }

        // POST: Readers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reader = await _context.Readers.FindAsync(id);
            _context.Readers.Remove(reader);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReaderExists(int id)
        {
            return _context.Readers.Any(e => e.ReaderId == id);
        }
        [HttpGet]
        public IActionResult AddBook(int id)
        {
            return View();



        }
        [HttpPost]
        public async Task<IActionResult> AddBook(Books books)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            Reader reader = await _context.Readers.Where(s => s.IdentityUserId == userId).FirstOrDefaultAsync();
            var author = await findAuthor(books.AuthorFirstName, books.AuthorLastName);
            books.Genre = books.Genre.ToLower();
            books.AuthorID = getAuthorID(author);
            books.ReaderId = reader.ReaderId;
            _context.Add(books);
            _context.SaveChanges();
            return View(books);
        }
        public async Task<Author> findAuthor(string firstName, string lastName)
        {
            var author = await _context.Authors.Where(s => s.AuthorFirstName == firstName && s.AuthorLastName == lastName).FirstOrDefaultAsync();
            if (author == null)
            {
                Author author1 = new Author();
                author1.AuthorFirstName = firstName;
                author1.AuthorLastName = lastName;
                author1.Rating = 3;
                _context.Add(author1);
                _context.SaveChanges();
                return author1;
            }
            else { return author; }


        }
        public int getAuthorID(Author author)
        {
            try
            {
                int id = author.AuthorID;
                return id;
            }
            catch (Exception) { return 0; }


        }
        public async Task<IActionResult> editBook(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Books books = await _context.Books.FindAsync(id);
            if (books == null)
            {
                return NotFound();
            }
            return View(books);
        }

        [HttpPost]
        public async Task<IActionResult> editBook(Books books)
        {
            var author = await findAuthor(books.AuthorFirstName, books.AuthorLastName);
            Books books1 = await _context.Books.Where(s => s.BookId == books.BookId).FirstOrDefaultAsync();
            
            books.AuthorID = getAuthorID(author);
            books1 = books;
            books1.Genre = books.Genre.ToLower();
            _context.Update(books1);
            _context.SaveChanges();
            return View(books1);
        }

        [HttpPost, ActionName("DeleteBook")]
        public async Task<IActionResult> DeleteBook(Books books)
        {
            var deletedbook = await _context.Books.Where(s => s.BookId == books.BookId).FirstOrDefaultAsync();
            _context.Remove(deletedbook);
            _context.SaveChanges();
            return View(books);





        }
        public async Task<List<Books>> GetAllBooks(Reader reader)
        {

            List<Books> allBooks = new List<Books>();
            allBooks = await _context.Books.Where(s => s.ReaderId == reader.ReaderId).ToListAsync();
            return allBooks;
        }


        public async Task<List<Books>> GetBooksByGenre(string genre)
        { genre = genre.ToLower();
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            Reader reader = await _context.Readers.Where(c => c.IdentityUserId == userId).SingleOrDefaultAsync();
            var myShelves = await _context.Shelves.Where(s => s.ReaderId == reader.ReaderId).ToListAsync();
            List<Books> booksByGenre = new List<Books>();
            foreach (var shelf in myShelves)
            {
                booksByGenre = await _context.Books.Where(s => s.Shelf_ID == shelf.Shelf_ID && s.Genre == genre).ToListAsync();

                booksByGenre = booksByGenre.OrderBy(s => s).ToList();
            }
            return booksByGenre;
        }
        [HttpGet]
        public IActionResult ADDShelf(int id)
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ADDShelf(Shelf shelf)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                Reader reader = await _context.Readers.Where(s => s.IdentityUserId == userId).FirstOrDefaultAsync();
                shelf.ReaderId = reader.ReaderId;
                _context.Add(shelf);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shelf);

        }
        [HttpGet]
        public async Task<IActionResult> EditShelf(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Shelf shelf = await _context.Shelves.Where(s => s.Shelf_ID == id).FirstOrDefaultAsync();
            if (shelf == null)
            {
                return NotFound();
            }
            return View(shelf);
        }
        [HttpPost]
        public async Task<IActionResult> EditShelf(Shelf shelf)
        {
            Shelf changedshelf = await _context.Shelves.Where(s => s.Shelf_ID == shelf.Shelf_ID).FirstOrDefaultAsync();
            changedshelf = shelf;
            _context.Update(changedshelf);
            _context.SaveChanges();
            return View(changedshelf);

        }
        [HttpGet]
        public async Task<IActionResult> DeleteShelf(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Shelf shelf = await _context.Shelves.FirstOrDefaultAsync(s => s.Shelf_ID == id);
            if (shelf == null)
            {
                return NotFound();
            }

            return View(shelf);
        }
        [HttpPost, ActionName("DeleteShelf")]
        public async Task<IActionResult> DeleteShelf(Shelf shelf)
        {
            Shelf goneShelf = await _context.Shelves.Where(s => s.Shelf_ID == shelf.Shelf_ID).FirstOrDefaultAsync();
            _context.Remove(goneShelf);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public async void GetShelves(int id)
        {
            ViewBag.Myshelves = await _context.Shelves.Where(s => s.ReaderId == id).ToListAsync();

        }
        public Shelf GetShelfByName(string name)
        {
            Shelf shelf = _context.Shelves.Where(s => s.Shelf_Name == name.ToLower()).FirstOrDefault();
            ViewBag.NamedShelf = shelf;
            return shelf;


        }



        public async void ApplyRating(Books books, double rating)
        {
            Books books1 = await _context.Books.FindAsync(books.BookId);
            books1.Rating = rating;
            _context.Update(books1);
            _context.SaveChanges();
                }
    

    
        public async void ApplyRating(Author author, double rating)
        {
           Author author1 = await _context.Authors.FindAsync(author.AuthorID);
            author1.Rating = rating;
            _context.Update(author1);
            _context.SaveChanges();


        }
        public async void PutBookOnShelf(int id,string name) 
        {
            Shelf shelf = GetShelfByName(name);
            Books books = await _context.Books.Where(s => s.BookId == id).FirstOrDefaultAsync();
            books.Shelf_ID = shelf.Shelf_ID;
            _context.Update(books);
            _context.SaveChanges();
        
        }
        public async Task<IActionResult> AllAuthors(int id) 
        {
            List<Author> allAuthors = new List<Author>();
            allAuthors =await _context.Authors.Where(s => s.ReaderId == id).ToListAsync();

            return View(allAuthors);
        
        
        
        }
        public async Task<IActionResult> HighlyRatedAuthors(int id)
        {
            List<Author> highlyRated = await _context.Authors.Where(s => s.ReaderId == id && s.Rating >= 4.0).ToListAsync();
            return View(highlyRated);
        }
        public async Task<IActionResult> HighlyRatedBooks(int id)
        {
            List<Books> highlyRated = await _context.Books.Where(s => s.ReaderId == id && s.Rating >= 4.0).ToListAsync();
            return View(highlyRated);

        }
        public async void BookRead(int id) 
        {
            Books books =await _context.Books.Where(s => s.BookId == id).FirstOrDefaultAsync();
            books.Completed = true;
            _context.Update(books);
            _context.SaveChanges();
        
        
        
        }
        public async void ChangeLendability(int id,bool input) 
        {
            Books books =await _context.Books.Where(s => s.BookId == id).FirstOrDefaultAsync();
            books.Lendable = input;
            _context.Update(books);
            _context.SaveChanges();
        
        
        
        }
    } 
}
 


