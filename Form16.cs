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
    public partial class Form16 : Form
    {

        

        public Form16()
        {
            InitializeComponent();
        }




       
        // give connection string

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-THPNSVGP;Initial Catalog=swimming;Integrated Security=True");



        // codes for display database and view in datagrid

        public void display()
        {
            conn.Open();             // open database
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from athleteDetails";        // select all data in database
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grdAthlete.DataSource = dt;                  // view in datagrid
            conn.Close();                 // close database

      
        }





        // what happen load competition details form

        private void Form16_Load(object sender, EventArgs e)
        {
           display();         // view datagrid
        }

       


        // hide and show the columns

        private void chbAdmission_CheckedChanged(object sender, EventArgs e)
        {

            // if Admission No checkbox is select then hide that column in datagrid

            if (chbAdmission.Checked)
            {
                grdAthlete.Columns[0].Visible = false;
            }
            else               // if condition is fail. Then show Admission No column in datagrid
            {
                grdAthlete.Columns[0].Visible = true;
            }
        }


        // if Name checkbox is select then hide that column in datagrid

        private void chbName_CheckedChanged(object sender, EventArgs e)
        {
            if (chbName.Checked)
            {
                grdAthlete.Columns[1].Visible = false;
            }
            else      // if condition is fail. Then show Name column in datagrid
            {
                grdAthlete.Columns[1].Visible = true;
            }
        }




        // if DOB checkbox is select then hide that column in datagrid

        private void chbDOB_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDOB.Checked)
            {
                grdAthlete.Columns[2].Visible = false;
            }
            else    // if condition is fail. Then DOB column show in datagrid
            {
                grdAthlete.Columns[2].Visible = true;
            }
        }




        // if Age checkbox is select then hide that column in datagrid

        private void chbAge_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAge.Checked)
            {
                grdAthlete.Columns[3].Visible = false;
            }
            else          // if condition is fail. Then show Age column in datagrid
            {
                grdAthlete.Columns[3].Visible = true;
            }
        }




        // if Age Group checkbox is select then hide that column in datagrid

        private void chbAgeGroup_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAgeGroup.Checked)
            {
                grdAthlete.Columns[4].Visible = false;
            }
            else         // if condition is fail. Then show Age Group column in datagrid
            {
                grdAthlete.Columns[4].Visible = true;
            }
        }




        // if Sex checkbox is select then hide that column in datagrid

        private void chbSex_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSex.Checked)
            {
                grdAthlete.Columns[5].Visible = false;
            }
            else      // if condition is fail. Then show Sex column in datagrid
            {
                grdAthlete.Columns[5].Visible = true;
            }
        }




        // if ID checkbox is select then hide that column in datagrid

        private void chbID_CheckedChanged(object sender, EventArgs e)
        {
            if (chbID.Checked)
            {
                grdAthlete.Columns[6].Visible = false;
            }
            else         // If condition is fail. Then show ID column in datagrid
            {
                grdAthlete.Columns[6].Visible = true;
            }
        }





        // if House checkbox is select then hide that column in datagrid

        private void chbHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (chbHouse.Checked)
            {
                grdAthlete.Columns[7].Visible = false;
            }
            else          // if condition is fail. Then House column show in datagrid
            {
                grdAthlete.Columns[7].Visible = true;
            }
        }




        // if School checkbox is select then hide that column in datagrid
        private void chbSchool_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSchool.Checked)
            {
                grdAthlete.Columns[8].Visible = false;
            }
            else       // if condition is fail. Then School column show in datagrid
            {
                grdAthlete.Columns[8].Visible = true;
            }
        }





        // if Zonal checkbox is select then hide that column in datagrid

        private void chbZonal_CheckedChanged(object sender, EventArgs e)
        {
            if (chbZonal.Checked)
            {
                grdAthlete.Columns[9].Visible = false;
            }
            else        // if condition is fail. Then Zonal column show in datagrid
            {
                grdAthlete.Columns[9].Visible = true;
            }
        }




        // if District checkbox is select then hide that column in datagrid

        private void chbDistrict_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDistrict.Checked)
            {
                grdAthlete.Columns[10].Visible = false;
            }
            else       // if condition is fail. Then datagrid show District column
            {
                grdAthlete.Columns[10].Visible = true;
            }
        }




        // if Province checkbox is select then hide that column in datagrid

        private void chbProvince_CheckedChanged(object sender, EventArgs e)
        {
            if (chbProvince.Checked)
            {
                grdAthlete.Columns[11].Visible = false;
            }
            else       // if coondition is fail. Then District column show in datagrid
            {
                grdAthlete.Columns[11].Visible = true;
            }
        }




        // if Birth Certificate No checkbox is select then hide that column in datagrid

        private void chbBCNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbBCNo.Checked)
            {
                grdAthlete.Columns[12].Visible = false;
            }
            else        // if condition is fail. Then datagrid show Birth Certificate No column
            {
                grdAthlete.Columns[12].Visible = true;
            }
        }





        // if Date checkbox is select then hide that column in datagrid

        private void chbDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDate.Checked)
            {
                grdAthlete.Columns[13].Visible = false;
            }
            else      // if condition is fail. Then Date column show in datagrid
            {
                grdAthlete.Columns[13].Visible = true;
            }
        }







        // what happen click back button

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();        // go to event categories form
            f12.Show();                 // show that form
            this.Close();                   // close this form when go to event categories form 
        }




        // what happen click delete button

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "delete from athleteDetails where Admission_No = '" + txtAdmission.Text +"'";      // delete all data of each record using the Admission No
            cmd.ExecuteNonQuery();
            conn.Close();
            display();
            MessageBox.Show("Record deleted successfully.");
        }



        // what happen click search button

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from athleteDetails where Admission_No = '" + txtAdmission.Text +"'";        // search recode using admission No
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grdAthlete.DataSource = dt;
            conn.Close();
        }




        // what happen click Display  button
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            display();         // view datagrid within value
        }




    }
}
