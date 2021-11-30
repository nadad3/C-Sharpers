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
    public partial class FAdd : Form
    {
        public FAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
            else if (DbOps.FindMovieInDatabase(txtBMovieTitle.Text))
                MessageBox.Show("A movie with this title already exist in the database!");

            else
            {
                //If the movie doesn't exist, try to add it
                Movies newMovie = new Movies();
                newMovie.Title = txtBMovieTitle.Text;
                newMovie.Year = intYear;
                newMovie.Director = txtbDirector.Text;
                newMovie.Genre = comboBGenre.SelectedIndex + 1; //Add 1 to get the 1-base genre code
                if (txtBRottenTScore.Text.Length > 0)
                    newMovie.Score = intRotten;
                if (txtTotalEarnings.Text.Length > 0)
                    newMovie.TotalEarned = doubleEarnings;

                bool success = DbOps.AddMovieToDatabase(newMovie);

                //If Success this message will pop up!
                if (success)
                {
                    MessageBox.Show("Movie Added!");
                    ClearSelections();
                }



            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearSelections();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FAdd_Load(object sender, EventArgs e)
        {
            //Load the combo box with all genre options (except for the clear first item)
            comboBGenre.Items.Clear();
            foreach (string genre in Movies.genres)
                if (genre.Length > 0)
                    comboBGenre.Items.Add(genre);

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
    }
}
