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
    public partial class Form23 : Form
    {



        // give connection string

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-THPNSVGP;Initial Catalog=swimming;Integrated Security=True");



        public Form23()
        {
            InitializeComponent();
        }



        // what happen click back button

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form18 f18 = new Form18();          // go to event categories form
            f18.Show();                  // show event categories form
            this.Close();                // go to event categories form close the this form
        }






        // codes for display database and view in datagrid

        public void display()
        {

            conn.Open();            // open database
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from PlaceDetails_5 order by Performance_Time asc";   // select all data from database
            cmd.ExecuteNonQuery();                     // execute the query
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grdPlace5.DataSource = dt;           // view data in gridview
            conn.Close();        // close database


        }





        // what happen form load

        private void Form23_Load(object sender, EventArgs e)
        {
            display();      // view datagrid
        }





        // what happen click search button

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from PlaceDetails_5 where Admission_No = '" + txtAdmission.Text + "' ";           // search record using admission No
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grdPlace5.DataSource = dt;
            conn.Close();
        }






        // what happen click delete button

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "delete from PlaceDetails_5 where Admission_No = '" + txtAdmission.Text + "'";          // delete all data of each record using the Admission No
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grdPlace5.DataSource = dt;
            conn.Close();
            display();
            MessageBox.Show("Record deleted successfully.");
        }






        // what happen click display button

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            display();      // view datagrid
        }




    }
}
