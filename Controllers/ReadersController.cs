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

namespace Library_App.Controllers
{
    [Authorize(Roles = "Reader")]
    public class ReadersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReadersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Readers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Readers.ToListAsync());
        }

        // GET: Readers/Details/5
        public async Task<IActionResult> Details(int? id)
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
        public async void AddBook(Books books)
        {
            var author = await findAuthor(books.AuthorFirstName, books.AuthorLastName);

            books.AuthorID = getAuthorID(author);
            _context.Add(books);
            _context.SaveChanges();
        }
        public async Task<Author> findAuthor(string firstName, string lastName)
        {
            var author =await _context.Authors.Where(s => s.AuthorFirstName == firstName && s.AuthorLastName == lastName).FirstOrDefaultAsync();
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
        public async Task<IActionResult> editBook(Books books) 
        {
            var author = await findAuthor(books.AuthorFirstName, books.AuthorLastName);

            books.AuthorID = getAuthorID(author);
            _context.Update(books);
            _context.SaveChanges();
            return View(books);
        }
        public async Task<IActionResult> DeleteBook(Books books) 
        {
            var deletedbook = await _context.Books.Where(s => s.BookId == books.BookId).FirstOrDefaultAsync();
            _context.Remove(deletedbook);
            _context.SaveChanges();
            return View(books);
        
        
        
        
        
        }
        public async Task<List<Books>> GetAllBooks(Reader reader) 
        {
            var checkShelves = await  _context.Shelves.Where(s => s.ReaderId == reader.ReaderId).ToListAsync();
            List<Books> allBooks = new List<Books>();
            foreach(var shelf in checkShelves) 
            {
               allBooks = await _context.Books.Where(s => s.Shelf_ID == shelf.Shelf_ID).ToListAsync();
                /*  var books foreach(var book in books) 
                  {
                      allBooks.Add(book);
                  }*/
            }
            return allBooks;
        }



    }
}



