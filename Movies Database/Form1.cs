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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MoviesDatabase.mdf;Integrated Security=True"); //Connection to database with file path

        SqlDataReader reader;
        SqlCommand command; //Defining variables

        public SqlDataAdapter adapter;
        public DataSet ds;

        public void loadAll() //method to load data to datagridview
        {
            try
            {
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(@"SELECT * FROM MoviesDatabase", conn); //Creating Sql Command 
                adapter = new SqlDataAdapter(); //Decalring adapter
                ds = new DataSet(); //Declaring data set

                adapter.SelectCommand = sqlCmd; //Linking command
                adapter.Fill(ds, "MoviesDatabase"); //Fills dataset

                dataGridViewMovies.DataSource = ds; //Providng data source
                dataGridViewMovies.DataMember = "MoviesDatabase"; //Specifying data member

                conn.Close();

                cbMovie.DataSource = ds.Tables[0];
                cbMovie.DisplayMember = "MovieName"; //Loading movies to combobox
                cbMovie.ValueMember = "MovieName";

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message); //Exception if connection failed
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            hScrollYear.Minimum = 1990;
            hScrollYear.Maximum = 2019; //Scollbar minimum and maximum values
            loadAll();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            lboxMovies.Items.Clear();
            try
            {
                conn.Open();
                command = new SqlCommand($"SELECT * FROM MoviesDatabase WHERE MovieName LIKE '%{tbName.Text}%'", conn); //Creating Sql Command 
                reader = command.ExecuteReader(); //Reader declaration

                while (reader.Read())
                {
                    lboxMovies.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t" + reader.GetValue(2) + "\t" + reader.GetValue(3)); //Values to be displayed in ListBox
                }

                conn.Close();
            }
            catch (SqlException error) //Exception if connection failed
            {
                MessageBox.Show(error.Message);
            }
        }

        private void hScrollYear_Scroll(object sender, ScrollEventArgs e)
        {
            lblYearScroll.Text = hScrollYear.Value.ToString(); //Displaying scrollbar value to the user

            lboxMovies.Items.Clear();
            try
            {
                conn.Open();
                command = new SqlCommand($"SELECT * FROM MoviesDatabase WHERE MovieYear = {hScrollYear.Value}", conn); //Creating Sql Command 
                reader = command.ExecuteReader(); //Reader declaration

                while (reader.Read())
                {
                    lboxMovies.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t" + reader.GetValue(2) + "\t" + reader.GetValue(3)); //Values to be displayed in ListBox
                }

                conn.Close();
            }
            catch (SqlException error) //Exception if connection failed
            {
                MessageBox.Show(error.Message);
            }
        }

        private void cbRating_SelectedIndexChanged(object sender, EventArgs e)
        {
            lboxMovies.Items.Clear();
            try
            {
                conn.Open();
                command = new SqlCommand($"SELECT * FROM MoviesDatabase WHERE MovieRating = {cbRating.SelectedItem}", conn); //Creating Sql Command 
                reader = command.ExecuteReader(); //Reader declaration

                while (reader.Read())
                {
                    lboxMovies.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t" + reader.GetValue(2) + "\t" + reader.GetValue(3)); //Values to be displayed in ListBox
                }

                conn.Close();
            }
            catch (SqlException error) //Exception if connection failed
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand sqlCmd = new SqlCommand(@"DELETE from MoviesDatabase WHERE MovieName = @name", conn); //Creating delete Sql Command 
                sqlCmd.Parameters.AddWithValue("@name", cbMovie.SelectedValue);
                sqlCmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("The record has been deleted"); //Confirmation message
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message); //Exception if connection failed
            }
            loadAll(); //Refreshes data in datagridview
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmAdd myFormAdd = new frmAdd();
            myFormAdd.ShowDialog(); //Showing add record form in dialogbox
            loadAll(); //Refreshing datagridview
        }

        private void cbMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadAll(); //Loads data into datagridview
        }
    }
}
