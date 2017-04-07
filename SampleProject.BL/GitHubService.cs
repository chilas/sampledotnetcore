using Newtonsoft.Json;
using SampleProject.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SampleProject.Services
{
    public class GitHubService
    {
        public GitHubService()
        {

        }

        public async Task<GitHubModel> GetUser(string username)
        {
            username = username ?? "chilas";

            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("https://api.github.com/")
            };
            var response = await client.GetStringAsync($"users/${username}");
            var user = JsonConvert.DeserializeObject<GitHubModel>(response);
            return user;
        }
    }
}
