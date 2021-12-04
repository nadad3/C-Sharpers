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
        BindingList<Movies> masterMovieList = new BindingList<Movies>();
        public Form1()
        {
            InitializeComponent();
        }
        
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
            DbOps.RefreshingMovies(masterMovieList);
        }

        private void DataGridViewMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DataGridViewMovies.SelectedRows[0];
            string movieTitle = Convert.ToString(row.Cells[1].Value);
           FUpdate updateForm = new FUpdate(movieTitle);
            updateForm.ShowDialog();
            DbOps.RefreshMovies(masterMovieList);
        }

        private void deleteMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open up a new delete form
            FDeleted deleteForm = new FDeleted();
            deleteForm.ShowDialog();
            //Refresh the list in case some movies were chenged
            DbOps.RefreshMovies(masterMovieList);
        }

        private void refreshListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DbOps.RefreshingMovies(masterMovieList);

        }

        private void addMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show the Add form modally
            AddingNewEventArgs addForm = new AddingNewEventArgs();
            addForm.ShowDialog();
            //Refresh the list in case some movies were added
            DbOps.RefreshMovies(masterMovieList);
        }

        private void updateMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open up a new update form
            FUpdate updateForm = new FUpdate();
            updateForm.ShowDialog();
             //Refresh the list in case some movies were changed
            DbOps.RefreshMovies(masterMovieList);
        }
    }
}
