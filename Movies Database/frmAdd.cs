using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Movies_Database
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.SetError(tbMovieRating, "");
                errorProvider1.SetError(tbMovieYear, ""); //Clearing errors

                Form1 myFormMain = new Form1();

                myFormMain.conn.Open();
                SqlCommand sqlCmd = new SqlCommand(@"INSERT INTO MoviesDatabase(MovieName, MovieDirector, MovieRating, MovieYear) VALUES(@name, @director, @rating, @year)", myFormMain.conn); //Creating Sql insert Command 
                sqlCmd.Parameters.AddWithValue("@name", tbMovieName.Text);
                sqlCmd.Parameters.AddWithValue("@director", tbMovieDirector.Text);
                sqlCmd.Parameters.AddWithValue("@rating", tbMovieRating.Text);//Replacing placeholders with text in the textboxes
                sqlCmd.Parameters.AddWithValue("@year", tbMovieYear.Text);

                if (!int.TryParse(tbMovieRating.Text, out int n))
                {
                    errorProvider1.SetError(tbMovieRating, "Please enter a number (1 - 10)"); //Error messages for incorrect input
                }

                if (!int.TryParse(tbMovieYear.Text, out int m))
                {
                    errorProvider1.SetError(tbMovieYear, "Please enter a year (1990 - 2019)");
                }

                sqlCmd.ExecuteNonQuery();

                myFormMain.conn.Close();


                MessageBox.Show("Data successfully inserted");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message); //Exception if connection failed
            }
        }
    }
}
