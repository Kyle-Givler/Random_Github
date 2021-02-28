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
    public interface IGitHubRepo
    {
        string Archive_url { get; set; }
        bool Archived { get; set; }
        string Assignees_url { get; set; }
        string Blobs_url { get; set; }
        string Branches_url { get; set; }
        string Clone_url { get; set; }
        string Collaborators_url { get; set; }
        string Comments_url { get; set; }
        string Commits_url { get; set; }
        string Compare_url { get; set; }
        string Contents_url { get; set; }
        string Contributors_url { get; set; }
        DateTime Created_at { get; set; }
        string Default_branch { get; set; }
        string Deployments_url { get; set; }
        string Description { get; set; }
        bool Disabled { get; set; }
        string Downloads_url { get; set; }
        string Events_url { get; set; }
        bool Fork { get; set; }
        int Forks { get; set; }
        int Forks_count { get; set; }
        string Forks_url { get; set; }
        string Full_name { get; set; }
        string Git_commits_url { get; set; }
        string Git_refs_url { get; set; }
        string Git_tags_url { get; set; }
        string Git_url { get; set; }
        bool Has_downloads { get; set; }
        bool Has_issues { get; set; }
        bool Has_pages { get; set; }
        bool Has_projects { get; set; }
        bool Has_wiki { get; set; }
        string Homepage { get; set; }
        string Hooks_url { get; set; }
        string Html_url { get; set; }
        int Id { get; set; }
        string Issue_comment_url { get; set; }
        string Issue_events_url { get; set; }
        string Issues_url { get; set; }
        string Keys_url { get; set; }
        string Labels_url { get; set; }
        string Language { get; set; }
        string Languages_url { get; set; }
        License License { get; set; }
        string Merges_url { get; set; }
        string Milestones_url { get; set; }
        object Mirror_url { get; set; }
        string Name { get; set; }
        int Network_count { get; set; }
        string Node_id { get; set; }
        string Notifications_url { get; set; }
        int Open_issues { get; set; }
        int Open_issues_count { get; set; }
        Owner Owner { get; set; }
        Permissions Permissions { get; set; }
        bool Private { get; set; }
        string Pulls_url { get; set; }
        DateTime Pushed_at { get; set; }
        string Releases_url { get; set; }
        int Size { get; set; }
        string Ssh_url { get; set; }
        int Stargazers_count { get; set; }
        string Stargazers_url { get; set; }
        string Statuses_url { get; set; }
        int Subscribers_count { get; set; }
        string Subscribers_url { get; set; }
        string Subscription_url { get; set; }
        string Svn_url { get; set; }
        string Tags_url { get; set; }
        string Teams_url { get; set; }
        string Temp_clone_token { get; set; }
        string Trees_url { get; set; }
        DateTime Updated_at { get; set; }
        string Url { get; set; }
        int Watchers { get; set; }
        int Watchers_count { get; set; }
    }
}