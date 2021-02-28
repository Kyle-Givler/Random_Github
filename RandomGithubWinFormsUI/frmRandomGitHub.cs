using RandomGithubLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RandomGithubWinFormsUI
{
    public partial class frmRandomGitHub : Form
    {
        private readonly IGithubAPI githubAPI;

        public frmRandomGitHub(IGithubAPI githubAPI)
        {
            InitializeComponent();
            this.githubAPI = githubAPI;
        }
    }
}
