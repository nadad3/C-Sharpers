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
    public partial class FUpdate : Form
    {

        private Movies LastFoundMovie = new Movies();

        private void LoadDropDownItems()
        {
            //Load up the combo box with all genre options
            comboBGenre.Items.Clear();
            foreach (string genre in Movies.genres)
                if (genre.Length > 0)
                    comboBGenre.Items.Add(genre);

        }
    
        public FUpdate()
        {
            InitializeComponent();
            LoadDropDownItems();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtBMovieTitle.Text.Length > 0)
                SearchForMovie();
            else
                //No movie title was entered
                MessageBox.Show("Please enter the movie title to be looked up!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Validate inputs
            int intRotten = 0;
            double doubleEarnings = 0d;

            //Title
            if (txtBMovieTitle.Text.Length == 0)
                MessageBox.Show("You must enter the title for the movie.");
            //Year
            else if (!int.TryParse(txtBYearReleased.Text, out int intYear))
                MessageBox.Show("You must enter the valid year for a movie.");
            //Director
            else if (txtbDirector.Text.Length == 0)
                MessageBox.Show("You must enter the director name for the movie.");
            //Genre
            else if (comboBGenre.SelectedIndex < 0)
                MessageBox.Show("You must choose a ganre for the movie.");
            //Rotten Tomatoes - if filled in, must have a valid number
            else if ((txtBRottenTScore.Text.Length > 0) && (!int.TryParse(txtBRottenTScore.Text, out intRotten)))
                MessageBox.Show("If you specify a Rotten Tomatoes Score, it has to be a number!");
            //Earnings - if filled in, must have a valid number
            else if ((txtTotalEarnings.Text.Length > 0) && (!double.TryParse(txtTotalEarnings.Text, out doubleEarnings)))
                MessageBox.Show("If you specify a total earnings, it has to be a number!");
            //Check if the movie already exist
            else if ((txtBMovieTitle.Text != LastFoundMovie.Title) && (DbOps.FindMovieInDatabase(txtBMovieTitle.Text)))
                MessageBox.Show("A movie with this title already exist in the database!");

            else
            {
                //Try to update this record in the table
                Movies updateMovie = new Movies();
                //Keep the original id from the movie we found
                updateMovie.Id = LastFoundMovie.Id;
                //Then add the content to the form
                updateMovie.Title = txtBMovieTitle.Text;
                updateMovie.Year = intYear;
                updateMovie.Director = txtbDirector.Text;
                updateMovie.Genre = comboBGenre.SelectedIndex + 1;
                if (txtBRottenTScore.Text.Length > 0)
                    updateMovie.Score = intRotten;
                if (txtTotalEarnings.Text.Length > 0)
                    updateMovie.TotalEarned = doubleEarnings;
                bool success = DbOps.UpdateMovieInDatabase(updateMovie);

                //
                if (success)
                {
                    MessageBox.Show("Movie Updated!");
                    ClearSelections();
                    txtBYearReleased.Enabled = false;
                    txtbDirector.Enabled = false;
                    comboBGenre.Enabled = false;
                    txtBRottenTScore.Enabled = false;
                    txtTotalEarnings.Enabled = false;
                    //Return the cursor to the title Field for the next search
                    txtBMovieTitle.Focus();
                    LastFoundMovie = new Movies();
                }
            }

        }
        private void ClearSelections()
        {
            txtBMovieTitle.Clear();
            txtBYearReleased.Clear();
            txtbDirector.Clear();
            txtBRottenTScore.Clear();
            txtTotalEarnings.Clear();
            comboBGenre.SelectedIndex = -1; //Clear the current selection

        }
        private void SearchForMovie()
        {
            txtBYearReleased.Enabled = false;
            txtbDirector.Enabled = false;
            comboBGenre.Enabled = false;
            txtBRottenTScore.Enabled = false;
            txtTotalEarnings.Enabled = false;
            btnUpdate.Enabled = false;
            txtBYearReleased.Clear();
            txtbDirector.Clear();
            txtBRottenTScore.Clear();
            txtTotalEarnings.Clear();
            comboBGenre.SelectedIndex = -1; //Clear the current selection
            LastFoundMovie = new Movies();
            //Search for movie

            if (DbOps.FindMovieInDatabase(txtBMovieTitle.Text, out LastFoundMovie))
            {
                //Movie was found and details are in foundMovieObject - fill in the controls
                txtBYearReleased.Text = $"{LastFoundMovie.Year}";
                txtbDirector.Text = LastFoundMovie.Director;
                comboBGenre.SelectedIndex = LastFoundMovie.Genre - 1;
                txtBRottenTScore.Text = LastFoundMovie.ScoreText;
                if (LastFoundMovie.TotalEarned >= 0)
                    txtTotalEarnings.Text = $"{LastFoundMovie.TotalEarned}";
                else
                    txtTotalEarnings.Text = "";
                //Enable the controls
                txtBYearReleased.Enabled = true;
                txtbDirector.Enabled = true;
                comboBGenre.Enabled = true;
                txtBRottenTScore.Enabled = true;
                txtTotalEarnings.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
                //Provide an error message and allow the user to try again
                MessageBox.Show($"The movie title you specified could not be found: \n{txtBMovieTitle.Text}");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearSelections();
        }
    }
}
