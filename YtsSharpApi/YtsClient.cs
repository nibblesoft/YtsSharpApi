﻿namespace YtsSharpApi
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using RestSharp;
    using YtsSharpApi.Models;
    using RestSharp.Authenticators;

    public partial class YtsClient
    {
        private readonly Uri BaseAddress = new Uri("https://yts.ag/api/v2/");
        private readonly RestClient _restClient;

        public YtsClient()
        {
            _restClient = new RestClient(BaseAddress);
        }

        public YtsClient(string userName, string passsword)
            : this(new HttpBasicAuthenticator(userName, passsword))
        {
        }

        public YtsClient(HttpBasicAuthenticator Authenticator)
        {
            _restClient.Authenticator = Authenticator;
        }

        public string GetMovieComment(string movieId)
        {
            var request = new RestRequest("movie_comments.json", Method.GET);
            request.AddParameter("movie_id", movieId);
            IRestResponse restResponse = _restClient.Execute(request);
            return null;
        }

        public RootObject GetListMovies()
        {
            var request = new RestRequest("list_movies.json", Method.GET);
            //request.AddParameter("movie_id", movieId);
            IRestResponse<RootObject> restResponse = _restClient.Execute<RootObject>(request);
            // _restClient.Execute<>
            return restResponse.Data;
        }

    }
}


// Note: object model factor http://json2csharp.com/#