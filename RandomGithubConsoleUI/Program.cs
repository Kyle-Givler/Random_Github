using RandomGithubLibrary;
using System;
using System.Threading.Tasks;

namespace RandomGithubConsoleUI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            GithubAPI gh = new GithubAPI();

            await gh.GetUser("JoyfulReaper");
        }
    }
}
