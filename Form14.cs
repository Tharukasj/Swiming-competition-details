using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Swim
{
    public partial class Form14 : Form
    {

        // give connection string

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-THPNSVGP;Initial Catalog=swimming;Integrated Security=True");


        public Form14()
        {
            InitializeComponent();
        }




        // codes for display database and view in gridview

        public void display()
        {

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from PlaceDetails order by Performance_Time asc";   // select method
            cmd.ExecuteNonQuery();                     // execute the query
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grdPlace.DataSource = dt;           // view data in gridview
            conn.Close();

       
        }





        // what happen click search button

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from PlaceDetails where Admission_No = '"+txtAdmission.Text+"' ";           // select raw using admission No
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grdPlace.DataSource = dt;
            conn.Close();
        }





        // what happen click delete button

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "delete from PlaceDetails where Admission_No = '" + txtAdmission.Text + "'";          // delete all data of each record using the Admission No
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grdPlace.DataSource = dt;
            conn.Close();
            display();
            MessageBox.Show("Record deleted successfully.");
        }





        // what happen when click the display button

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            display();        // display the datagrid
        }





        // what happen click back button

        private void button1_Click(object sender, EventArgs e)
        {
            Form18 f18 = new Form18();          // go to event categories form
            f18.Show();                  // show event categories form
            this.Close();                // go to event categories, form close the this form

        }



        // view gridview then open the result form of 50 Freestyle event place details

        private void Form14_Load_1(object sender, EventArgs e)
        {
            display();       // display datagrid
        }



    }
}
