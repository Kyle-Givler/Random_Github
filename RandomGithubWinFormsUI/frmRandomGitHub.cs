using Microsoft.Extensions.Configuration;
using RandomGithubLibrary;
using RandomGithubLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomGithubWinFormsUI
{
    public partial class frmRandomGitHub : Form
    {
        private readonly IGithubAPI githubAPI;
        private readonly IConfiguration configuration;
        private readonly Random rand = new Random();

        public frmRandomGitHub(IGithubAPI githubAPI,
            IConfiguration configuration)
        {
            InitializeComponent();
            this.githubAPI = githubAPI;
            this.configuration = configuration;
        }

        private async void btnFind_Click(object sender, EventArgs e)
        {
            IGitHubRepo repo = await GetRandomGitHub();
            UpdateLabels(repo);

        }

        private void UpdateLabels(IGitHubRepo repo)
        {
            lblIdValue.Text = repo.Id.ToString();
            lblOwnerValue.Text = repo.Owner.Login;
            lblOwnerGHValue.Text = repo.Owner.Html_url;
            lblNameValue.Text = repo.Name;
            lblDescValue.Text = repo.Description;
            lblUrlValue.Text = repo.Html_url;
            lblLanguageValue.Text = repo.Language;

            lblRemainingValue.Text = githubAPI.RateLimitRemaining.ToString();
        }

        private async Task<IGitHubRepo> GetRandomGitHub()
        {
            int tryMax;

            if (int.TryParse(configuration.GetSection("MaxId").Value, out int res))
            {
                tryMax = res;
            }
            else
            {
                tryMax = 300000000;
            }

            IGitHubRepo repo = null;

            while (repo?.Name == null)
            {
                int id = rand.Next(1, tryMax);

                try
                {
                    repo = await githubAPI.GetRepo(id);
                }
                catch (RateLimitedException)
                {
                    MessageBox.Show("You cannnot make any more API calls, please try again later", "Out Of API Calls", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Encountered during API Call:\n{ex.Message}", "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return repo;
        }
    }
}
