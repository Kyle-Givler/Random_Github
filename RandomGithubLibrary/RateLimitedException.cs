using System;
using System.Collections.Generic;
using System.Text;

namespace RandomGithubLibrary
{
    public class RateLimitedException : Exception
    {
        public RateLimitedException(string message) : base (message)
        {

        }
    }
}
