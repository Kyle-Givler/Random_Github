using RandomGithubLibrary.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RandomGithubLibrary
{
    public class GithubAPI
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly string login = "user:token"; // TODO Get this from appsettings.json

        public GithubAPI()
        {
            client.BaseAddress = new Uri("https://api.github.com");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
                );
            client.DefaultRequestHeaders.UserAgent.Clear();
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("RandomGithub", "0.1"));

            var authArray = Encoding.ASCII.GetBytes(login);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(authArray));
        }

        public async Task<GitHubUser> GetUser(string user)
        {
            var response = await client.GetAsync($"/users/{user}");
            var result = await response.Content.ReadAsAsync<GitHubUser>();

            return result;
        }
    }
}
