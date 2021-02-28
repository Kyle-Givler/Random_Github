﻿/*
MIT License

Copyright(c) 2020 Kyle Givler
https://github.com/JoyfulReaper

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using RandomGithubLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RandomGithubLibrary
{
    public class GithubAPI
    {
        public int RateLimitRemaining { get; private set; } = -1;

        private static readonly HttpClient client = new HttpClient();

        // Put you GitHub username and personal token here for more RateLimiting
        private static readonly string login = ""; // TODO Get this from appsettings.json

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

        public async Task<GitHubRepo> GetRepo(string user, string repo)
        {
            var response = await client.GetAsync($"/repos/{user}/{repo}");
            var result = await response.Content.ReadAsAsync<GitHubRepo>();

            ThrowIfRateLimited(response);
            UpdateRateLimit(response);

            return result;
        }

        public async Task<GitHubRepo> GetRepo(int id)
        {
            var response = await client.GetAsync($"/repositories/{id}");
            var result = await response.Content.ReadAsAsync<GitHubRepo>();

            ThrowIfRateLimited(response);
            UpdateRateLimit(response);

            return result;
        }

        public async Task<GitHubUser> GetUser(string user)
        {
            var response = await client.GetAsync($"/users/{user}");
            var result = await response.Content.ReadAsAsync<GitHubUser>();

            ThrowIfRateLimited(response);
            UpdateRateLimit(response);

            return result;
        }

        private void ThrowIfRateLimited(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                if (response.Headers.GetValues("X-RateLimit-Remaining").First() == "0")
                {
                    throw new RateLimitedException("You hit the rate limit :(");
                }
            }
        }

        private void UpdateRateLimit(HttpResponseMessage response)
        {
            RateLimitRemaining = int.Parse(response.Headers.GetValues("X-RateLimit-Remaining").First());
        }
    }
}
