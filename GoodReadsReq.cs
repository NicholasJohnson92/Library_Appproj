using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace apitests
{

    public class GoodReadsReq
    {
        public GoodReadsReq()
        {

            SeriesbyWorkId(42720997);

        }
        public async Task<int> GetAuthorIdFromName(string firstname, string lastname)
        {


            HttpClient client = new HttpClient();
            HttpResponseMessage httpResponse = await client.GetAsync($" https://www.goodreads.com/api/author_url/{firstname}%20{lastname}?key=hf1OZrcIM8ZyLPFSpOH6Q");
            if (httpResponse.IsSuccessStatusCode)
            {

                string xml = httpResponse.Content.ReadAsStringAsync().Result;
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                string json = JsonConvert.SerializeXmlNode(doc);
                var myObj = JsonConvert.DeserializeObject<JObject>(json);
                var x = myObj["GoodreadsResponse"]["author"]["@id"].ToString();
                var y= int.Parse(x);
                
                //goodReadsAuthor=  JsonConvert.DeserializeObject<GoodReadsAuthor>(json);
                // var x= goodReadsAuthor[]

                return y;
            }
            return 0;




        }
        public async Task<List<string>> ShowAuthorsBooks(string firstName, string lastName)
        {
            List<string> mylist = new List<string>();
            int x = await GetAuthorIdFromName(firstName,lastName);
            HttpClient client = new HttpClient();
            HttpResponseMessage httpResponse = await client.GetAsync($" https://www.goodreads.com/author/show/{x}?format=xml&key==hf1OZrcIM8ZyLPFSpOH6Q");
            if (httpResponse.IsSuccessStatusCode)
            {
                
                string xml = httpResponse.Content.ReadAsStringAsync().Result;
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                string json = JsonConvert.SerializeXmlNode(doc);
                var myObj = JsonConvert.DeserializeObject<JObject>(json);
                //Console.WriteLine(myObj["GoodreadsResponse"]["author"]["books"].ToString());
                var xz = myObj["GoodreadsResponse"]["author"]["books"]["book"];
                foreach (JToken thing in xz)
                {
                    //var otherthing = thing.SelectToken("title");
                    //Console.WriteLine(otherthing);
                    string booktitles=thing["title"].ToString();
                    mylist.Add(booktitles);
                }
               
                //var searchedTokens = myObj.FindTokens(key);
                //int count = searchedTokens.Count;
            }
                return mylist;
            
           


        }
        public async Task<List<string>> BooksOnSimilarSubject(string subject)
        {
            List<string> mylist = new List<string>();
            subject = subject.Trim().ToLower();
            HttpClient client = new HttpClient();
            HttpResponseMessage httpResponse = await client.GetAsync($"https://www.googleapis.com/books/v1/volumes?q={subject}+subject:&key={ApiKey.GoogleKey}");
            if (httpResponse.IsSuccessStatusCode)
            {
                var json = await httpResponse.Content.ReadAsStringAsync();
                var myobj = JsonConvert.DeserializeObject<JObject>(json);
                var xz = myobj["items"];
                foreach (JToken thing in xz)
                {
                    var otherthing = thing["volumeInfo"]["title"];

                    mylist.Add(otherthing.ToString());
                }


            }
            return mylist;

        }
        public async Task<int>BookIdFromISBN(long isbn)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage httpResponse = await client.GetAsync($"https://www.goodreads.com/book/isbn_to_id/{isbn}?key={ApiKey.GoodReadsKey}");
            if (httpResponse.IsSuccessStatusCode) 
            {
                var json = await httpResponse.Content.ReadAsStringAsync();
                var myobj = int.Parse(json);

                return myobj;
                    

            }

            return 0;


        } public async Task<int>WorkIdFromBookID(int bookId)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage httpResponse = await client.GetAsync($"https://www.goodreads.com/book/id_to_work_id/{bookId}?key={ApiKey.GoodReadsKey}");
            if (httpResponse.IsSuccessStatusCode)
            {
                string xml = httpResponse.Content.ReadAsStringAsync().Result;
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                string json = JsonConvert.SerializeXmlNode(doc);
                var myObj = JsonConvert.DeserializeObject<JObject>(json);
                var xz = myObj["GoodreadsResponse"]["work-ids"]["item"];
                int workID = int.Parse(xz.ToString());

                return workID;


            }

            return 0;

        }
        public async Task<int> SeriesbyWorkId(int workId) 
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage httpResponse = await client.GetAsync($"https://www.goodreads.com/work/{workId}/series?format=xml&key={ApiKey.GoodReadsKey}");
            if (httpResponse.IsSuccessStatusCode)
            {
                string xml = httpResponse.Content.ReadAsStringAsync().Result;
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                string json = JsonConvert.SerializeXmlNode(doc);
                var myObj = JsonConvert.DeserializeObject<JObject>(json);
                Console.WriteLine();
               
            }


            return 0;       
        }
    }
}