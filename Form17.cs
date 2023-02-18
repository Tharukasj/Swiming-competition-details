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
    public partial class Form17 : Form
    {


        public Form17()
        {
            InitializeComponent();
        }


        // give connection string

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-THPNSVGP;Initial Catalog=swimming;Integrated Security=True");



        // codes for display database and view in datagrid

        public void display()
        {
            
                conn.Open();      // open database
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from CoachDetails";          // select all data in database
                cmd.ExecuteNonQuery();       
                System.Data.DataTable dt = new System.Data.DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                grdCoach.DataSource = dt;       // data view in database
                conn.Close();               // close database
                
       
        }
        



        // what happen coach details form is open

        private void Form17_Load(object sender, EventArgs e)
        {
            display();      // view datagrid within value
        }





        // hide and show column in datagrid

        private void chkAdmission_CheckedChanged(object sender, EventArgs e)
        {

            // if Admission No checkbox is select then hide that column in datagrid

            if (chkAdmission.Checked)
            {
                grdCoach.Columns[0].Visible = false;
            }
            else        // if condition is false. Then Admission No column view in the datagrid 
            {
                grdCoach.Columns[0].Visible = true;
            }
        }





        // if MICC Name checkbox is select then hide that column in datagrid

        private void chkMiccName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMiccName.Checked)
            {
                grdCoach.Columns[1].Visible = false;
            }
            else          // if condition is false. Then show MICC Name column in datagrid
            {
                grdCoach.Columns[1].Visible = true;
            }
        }





        // if MICC Phone No checkbox is select then hide that column in datagrid

        private void chkMiccPhone_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMiccPhone.Checked)
            {
                grdCoach.Columns[2].Visible = false;
            }
            else        // if condition is false. Then MICC Phone No column show in datagrid 
            {
                grdCoach.Columns[2].Visible = true;
            }
        }





        // if Coach Name checkbox is select then hide that column in datagrid

        private void chkCoachName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoachName.Checked)
            {
                grdCoach.Columns[3].Visible = false;
            }
            else       // if condition is false. Then Coach Name column show in datagrid
            {
                grdCoach.Columns[3].Visible = true;
            }
        }





        // if Coach Phone No checkbox is select then hide that column in datagrid

        private void chkCoachPhone_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoachPhone.Checked)
            {
                grdCoach.Columns[4].Visible = false;
            }
            else         // if condition is false. Then datagrid show column of Coach Phone No
            {
                grdCoach.Columns[4].Visible = true;
            }
        }




        // what happen click back button

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();         // go to Event Categories form
            f12.Show();                           // show that form
            this.Close();                     // close this form when go to Event Categories form
        }





        // what happen click search button

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from CoachDetails where Admission_No = '" + txtAdmission.Text +"'";           // search recode using admission No
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grdCoach.DataSource = dt;
            conn.Close();
        }





        // what happen delete button click

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "delete from CoachDetails where Admission_No = '" + txtAdmission.Text + "'";           // delete all data of each record using the Admission No
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grdCoach.DataSource = dt;
            conn.Close();
            display();
            MessageBox.Show("Record deleted successfully.");
        }




        // what happen display button click

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            display();        // view datagrid within data
        }



    }
}
