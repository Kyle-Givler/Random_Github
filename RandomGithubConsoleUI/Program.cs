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
            int max = 300000000; // TODO read this from config. This is a decent default

            GithubAPI gh = new GithubAPI();
            Random rand = new Random();

            GitHubRepo repo = null;

            bool again = true;

            while (again)
            {
                int tryMax = max;
                while (repo?.Name == null)
                {
                    int id = rand.Next(1, tryMax);

                    try
                    {
                        repo = await gh.GetRepo(id);
                    }
                    catch (RateLimitedException)
                    {
                        Console.WriteLine("You cannot make any more API calls due to rate limiting. Try again later.");
                        Environment.Exit(-1);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Something went wrong with the API call!");
                        Console.WriteLine(ex.Message);
                    }

                    if (repo.Name == null)
                    {
                        tryMax = id - 1;
                    }
                    else
                    {
                        DisplayRepoInfo(repo);
                        Console.WriteLine();
                        DisplayRateLimitingInfo(gh);
                    }
                }

                Console.WriteLine();
                Console.Write("Would you like to find another (Y/n): ");
                var input = Console.ReadLine();
                if(!string.IsNullOrEmpty(input) && Char.ToUpperInvariant(input[0]) == 'N')
                {
                    again = false;
                }
                repo = null;
                Console.WriteLine();
            }

        }

        private static void DisplayRepoInfo(GitHubRepo repo)
        {
            Console.WriteLine("I found this random GitHub just for you!");
            Console.WriteLine($"Id: {repo.Id}");
            Console.WriteLine($"Owner: {repo.Owner.Login}");
            Console.WriteLine($"Owner's GitHub: {repo.Owner.Html_url}");
            Console.WriteLine($"Name: {repo.Name}");
            Console.WriteLine($"Description: {repo.Description}");
            Console.WriteLine($"URL: {repo.Html_url}");
            Console.WriteLine($"Programming Language: {repo.Language}");
        }

        private static void DisplayRateLimitingInfo(GithubAPI gh)
        {
            Console.WriteLine($"API calls until limited: {gh.RateLimitRemaining}");
        }
    }
}
