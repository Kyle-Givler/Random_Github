using System;
using System.Collections.Generic;
using System.Text;

namespace RandomGithubLibrary.Models
{
    public class GitHubUser
    {
        public string Login { get; set; }
        public int Id { get; set; }
        public string Node_Id { get; set; }
        public string Avatar_url { get; set; }
        public string Url { get; set; }
        public string Html_Url { get; set; }
        public string Followers_Url { get; set; }
        public string Following_Url { get; set; }
        public string Gists_Url { get; set; }
        public string Starred_Url { get; set; }
        public string Subscriptions_Url { get; set; }
        public string Organizations_Url { get; set; }
        public string Repos_Url { get; set; }
        public string Events_Url { get; set; }
        public string Received_events_url { get; set; }
        public string Type { get; set; }
        public bool Site_admin { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Blog { get; set; }
        public string Location { get; set; }
        public string email { get; set; }
        public bool hireable { get; set; }
        public string Bio { get; set; }
        public string Twitter_username { get; set; }
        public int Public_repos { get; set; }
        public int Public_gists { get; set; }
        public int Followers { get; set; }
        public int Following { get; set; }
        public string Created_at { get; set; }
        public string Updated_at { get; set; }
    }
}
