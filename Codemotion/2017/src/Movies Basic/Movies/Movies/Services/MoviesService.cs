﻿using Movies.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Movies.Services
{
    public class MoviesService
    {
        private static MoviesService _instance;

        public static MoviesService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MoviesService();

                return _instance;
            }
        }

        public async Task<MovieResponse<Movie>> GetPopularAsync()
        {
            string uri = $"{AppSettings.ApiUrl}movie/popular?api_key={AppSettings.ApiKey}&language=en";

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(uri);

            string serialized = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<MovieResponse<Movie>>(serialized);
            
            return result;
        }
    }
}