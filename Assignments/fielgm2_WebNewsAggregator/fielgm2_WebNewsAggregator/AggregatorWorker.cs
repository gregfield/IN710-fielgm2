using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace fielgm2_WebNewsAggregator
{
    public class AggregatorWorker
    {
        //fields for class
        private IList<SearchResult> bingResults;
        private List<string> likes;
        private List<string> dislikes;
        private DatabaseWorker dbWorker;
        private int userID;

        public AggregatorWorker(int userId)
        {
            //makes a new db worker
            dbWorker = new DatabaseWorker();

            this.userID = userId;
            //gets likes and dislikes from database for user
            likes = dbWorker.getLikes(userId);
            dislikes = dbWorker.getDislikes(userId);
        }

        //choses a random like to search
        public string choseRandomLike()
        {
            likes = dbWorker.getLikes(userID);
            Random random = new Random();
            int like = random.Next(likes.Count);

            return likes[like];
        }

        //makes a list of the dislikes to exclude when searching
        public string makeDislikesList()
        {
            dislikes = dbWorker.getDislikes(userID);
            string disLikeString = "";
            int count = 0;
            foreach(string dislike in dislikes)
            {
                if (count != 0)
                {
                    disLikeString += "+";
                    disLikeString += dislike;
                }
                else
                {
                    disLikeString += dislike;
                }
            }
            return disLikeString;
        }

        //calls the methods for the bing api call and the converting from json 
        public void HTTPandJSON(bool webOrNews)
        {
            //call the method to get the json back
            string json = bingApiCall(choseRandomLike(), makeDislikesList(), webOrNews);

            if(json != null)
            {
                //call the method to parse the json
                bingResults = JSONConverter(json);
            }
        }

        //makes an http request and gets json returned
        public string bingApiCall(string like, string dislike, bool webOrNews)
        {
            //bing api key
            string accountKey = "f202074769924ca9a7cf5ad8342dd13e";

            string newsQuery = "https://bingapis.azure-api.net/api/v5/news/search/?q=" + like + "&NOT=" + dislike + "&count=10&mkt=en-NZ&key=" + accountKey;
            string websiteQuery = "https://bingapis.azure-api.net/api/v5/news/search/?q=" + like + "&NOT=" + dislike + "&count=10&mkt=en-NZ&key=" + accountKey;
            //url query
            string urlQuery = "";

            if(webOrNews == true)
            {
                urlQuery = newsQuery;
            }
            else
            {
                urlQuery = websiteQuery;
            }

            Uri formattedUrl = new Uri(urlQuery);
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(formattedUrl);
            
            NetworkCredential accountCredential = new NetworkCredential(accountKey, accountKey);
            webRequest.Credentials = accountCredential;
            
            HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            return sr.ReadToEnd().ToString();
        }

        //converts the json into objects of SearchResult
        public IList<SearchResult> JSONConverter(string json)
        {
            JObject searchObject = JObject.Parse(json);
            IList<JToken> results = searchObject["value"].Children().ToList();
            IList<SearchResult> searchResults = new List<SearchResult>();
            foreach(JToken result in results)
            {
                SearchResult searchResult = JsonConvert.DeserializeObject<SearchResult>(result.ToString());
                searchResults.Add(searchResult);
            }

            return searchResults;
        }

        //adds a like to the db
        public void addLikeToDb(string like)
        {
            dbWorker.addALike(like, userID);
        }

        //adds a dislike to the db
        public void addDislikeToDb(string dislike)
        {
            dbWorker.addALike(dislike, userID);
        }

        //getter setter for search results
        public IList<SearchResult> BingResults
        {
            get { return bingResults; }
            set { bingResults = value; }
        }
    }
}
