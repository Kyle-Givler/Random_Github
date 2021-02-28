/*
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

using RandomGithubLibrary;
using RandomGithubLibrary.Models;
using System;
using System.Threading.Tasks;

namespace RandomGithubConsoleUI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //int max = int.MaxValue;
            int max = 300000000; // TODO read this from config

            GithubAPI gh = new GithubAPI();

            //await gh.GetUser("JoyfulReaper");
            //await gh.GetRepo(22087777);

            Random rand = new Random();
            

            GitHubRepo repo = null;
            int count = 0;
            while (repo?.Name == null)
            {
                count++;
                int id = rand.Next(1, max);

                try
                {
                    repo = await gh.GetRepo(id);
                }
                catch (RateLimitedException)
                {
                    Console.WriteLine("You cannot make any more API calls due to rate limiting");
                    System.Environment.Exit(-1);
                }

                if(repo.Name == null)
                {
                    max = id - 1;
                    id--;
                }

                Console.WriteLine(repo.Name);
                Console.WriteLine(repo.Description);
                Console.WriteLine(repo.Language);

                Console.WriteLine();
                Console.WriteLine($"After {count} tries. Id: {id}");
                Console.WriteLine($"Calls until limited: {gh.RateLimitRemaining}");
                Console.WriteLine();
            }

        }
    }
}
