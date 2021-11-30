using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }
        List<Movies> masterMovieList = new List<Movies>();

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to exit?",
                                            "Exit the App?",
                                             MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
                Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }

        private void refreshListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DbOps.RefreshMovies(masterMovieList);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewMovies.DataSource = masterMovieList;
            DataGridViewMovies.Columns["Id"].Visible = false;
            DataGridViewMovies.Columns["Genre"].Visible = false;
            DataGridViewMovies.Columns["TotalEarned"].Visible = false;
            DataGridViewMovies.Columns["RottenTomatoesScoreText"].Visible = false;

            DataGridViewMovies.Columns["GenreText"].HeaderText = "Genre";
            DataGridViewMovies.Columns["TotalEarnedText"].HeaderText = "Total Earned";
            DataGridViewMovies.Columns["ScoreText"].HeaderText = "Score";


            //load movies 
            DbOps.RefreshMovies(masterMovieList);
        }
    }
}
