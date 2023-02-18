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
    public partial class Form27 : Form
    {



        // give connection string

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-THPNSVGP;Initial Catalog=swimming;Integrated Security=True");



        public Form27()
        {
            InitializeComponent();
        }





        // what happen click back button

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form18 f18 = new Form18();          // go to event categories form
            f18.Show();                  // show event categories form
            this.Close();                // go to event categories form, close this form
        }






        // codes for display database and view in datagrid

        public void display()
        {

            conn.Open();         // open database
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from PlaceDetails_9 order by Performance_Time asc";        // select all data
            cmd.ExecuteNonQuery();                     // execute the query
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grdPlace9.DataSource = dt;           // view data in gridview
            conn.Close();         // close database


        }






        // when form load

        private void Form27_Load(object sender, EventArgs e)
        {
            display();          // view datagrid
        }





        // what happen click search button

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from PlaceDetails_9 where Admission_No = '" + txtAdmission.Text + "' ";           // search row using admission No
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grdPlace9.DataSource = dt;
            conn.Close();
        }




        // what happen delete button click

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "delete from PlaceDetails_9 where Admission_No = '" + txtAdmission.Text + "'";          // delete all data of each record using the Admission No
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grdPlace9.DataSource = dt;
            conn.Close();
            display();
            MessageBox.Show("Record deleted successfully.");
        }





        // what happen display button click

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            display();       // view datagrid
        }



    }
}
