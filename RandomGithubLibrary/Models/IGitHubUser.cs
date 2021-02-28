/*
MIT License

Copyright(c) 2021 Kyle Givler
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

using System;

namespace RandomGithubLibrary.Models
{
    public interface IGitHubUser
    {
        string Avatar_url { get; set; }
        string Bio { get; set; }
        string Blog { get; set; }
        string Company { get; set; }
        DateTime Created_at { get; set; }
        object Email { get; set; }
        string Events_url { get; set; }
        int Followers { get; set; }
        string Followers_url { get; set; }
        int Following { get; set; }
        string Following_url { get; set; }
        string Gists_url { get; set; }
        string Gravatar_id { get; set; }
        bool Hireable { get; set; }
        string Html_url { get; set; }
        int Id { get; set; }
        string Location { get; set; }
        string Login { get; set; }
        string Name { get; set; }
        string Node_id { get; set; }
        string Organizations_url { get; set; }
        int Public_gists { get; set; }
        int Public_repos { get; set; }
        string Received_events_url { get; set; }
        string Repos_url { get; set; }
        bool Site_admin { get; set; }
        string Starred_url { get; set; }
        string Subscriptions_url { get; set; }
        object Twitter_username { get; set; }
        string Type { get; set; }
        DateTime Updated_at { get; set; }
        string Url { get; set; }
    }
}