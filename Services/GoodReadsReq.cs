using Library_App.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;

namespace Library_App.Services
{
    public class GoodReadsReq
    {
        public GoodReadsReq()
        {

          Task<int> x=  GetAuthorIdFromName("johnathan", "stroud");
           
        }
        public async Task<int> GetAuthorIdFromName(string firstname, string lastname)
        {
            GoodReadsAuthor goodReadsAuthor = new GoodReadsAuthor();

            HttpClient client = new HttpClient();
            HttpResponseMessage httpResponse = await client.GetAsync($" https://www.goodreads.com/api/author_url/{firstname}%20{lastname}?key={ApiKey.GoodReadsKey}");
            if (httpResponse.IsSuccessStatusCode)
            {

                string xml = httpResponse.Content.ReadAsStringAsync().Result;
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                string json = JsonConvert.SerializeXmlNode(doc);
                var myObj = JsonConvert.DeserializeObject<JObject>(json);
                var x = myObj["GoodreadsResponse"]["author"]["@id"].ToString();
                var y = int.Parse(x);
                //goodReadsAuthor=  JsonConvert.DeserializeObject<GoodReadsAuthor>(json);
                // var x= goodReadsAuthor[]

                return await Task.FromResult(y);
            }
            return 0;
        }
        public async Task<List<string>> ShowAuthorsBooks(string firstName, string lastName)
        {
            List<string> mylist = new List<string>();
            int x = await GetAuthorIdFromName(firstName, lastName);
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
                    string booktitles = thing["title"].ToString();
                    mylist.Add(booktitles);
                }

                //var searchedTokens = myObj.FindTokens(key);
                //int count = searchedTokens.Count;
            }
            return mylist;


        }




        
    }
}
