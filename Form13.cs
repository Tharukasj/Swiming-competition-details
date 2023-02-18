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
    public partial class Form13 : Form
    {

        // give connection string

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-THPNSVGP;Initial Catalog=swimming;Integrated Security=True");


        

        public Form13()
        {
            InitializeComponent();
        }


     




        // click back button

        private void back_click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();          // go to get report form
            f12.Show();                         // show that form
            this.Close();                       // close this form when go to form 12
        }




        // read the database

        public void display()
        {

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from EventDetails";            // det database item using select keyword
            cmd.ExecuteNonQuery();                                        // execute database
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grdEvent.DataSource = dt;                                // data show in datagrid
            conn.Close();                                          // close the database


        }





        // what happen event form load

        private void Form13_Load(object sender, EventArgs e)
        {
            display();              //raed and show data in database on gridview
        }





        // hide the columns in gridview

        private void chkAdmission_CheckedChanged(object sender, EventArgs e)
        {


            // Admission No check box is checked then Admission No column is hide

            if (chkAdmission.Checked)
            {
                grdEvent.Columns[0].Visible = false;
            }
            else           // condition is fails Admission No column is show
            {
                grdEvent.Columns[0].Visible = true;
            }
        }





        // Event 1 check box is checked then Event 1 column is hide

        private void chkEvent1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEvent1.Checked)
            {
                grdEvent.Columns[1].Visible = false;
            }
            else                    // is condition is fail show Event 1
            {
                grdEvent.Columns[1].Visible = true;
            }
        }





        // Event 2 check box is checked then Event 2 column is hide

        private void chkEvent2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEvent2.Checked)
            {
                grdEvent.Columns[2].Visible = false;
            }
            else              // if condition is fail Then show Event 2 column
            {
                grdEvent.Columns[2].Visible = true;
            }
        }





        // Event 3 check box is checked then Event 3 column is hide

        private void chkEvent3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEvent3.Checked)
            {
                grdEvent.Columns[3].Visible = false;
            }
            else                 // condition is fails Event 3 show in gridview
            {
                grdEvent.Columns[3].Visible = true;
            }
        }





        // // Event 4 check box is checked then Event 4 column is hide

        private void chkEvent4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEvent4.Checked)
            {
                grdEvent.Columns[4].Visible = false;
            }
            else             // condition is fails. Then Event 4 column show
            {
                grdEvent.Columns[4].Visible = true;
            }
        }





        // Event 5 check box is checked then Event 5 column is hide

        private void chkEvent5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEvent5.Checked)
            {
                grdEvent.Columns[5].Visible = false;
            }
            else            // if comdition is fails. Then show Event 5 column
            {
                grdEvent.Columns[5].Visible = true;
            }
        }





        // Event 6 check box is checked then Event 6 column is hide

        private void chkEvent6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEvent6.Checked)
            {
                grdEvent.Columns[6].Visible = false;
            }
            else             // condition is fail. Then show Event 6 in gridview
            {
                grdEvent.Columns[6].Visible = true;
            }
        }





        // Event 7 check box is checked then Event 7 column is hide

        private void chkEvent7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEvent7.Checked)
            {
                grdEvent.Columns[7].Visible = false;
            }
            else              // condition is fail. Then Event 7 is show
            {
                grdEvent.Columns[7].Visible = true;
            }
        }





        // Event 8 check box is checked then Event 8 column is hide

        private void chkEvent8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEvent8.Checked)
            {
                grdEvent.Columns[8].Visible = false;
            }
            else           // condition is fail. Then show Event 8 in gridview
            {
                grdEvent.Columns[8].Visible = true;
            }
        }






        // Event 9 check box is checked then Event 9 column is hide

        private void chkEvent9_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEvent9.Checked)
            {
                grdEvent.Columns[9].Visible = false;
            }
            else             // condition is fail. Then show Event 9 in gridview
            {
                grdEvent.Columns[9].Visible = true;
            }
        }






        // Relay Event check box is checked then Relay Event column is hide

        private void chkRelayEvent_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRelayEvent.Checked)
            {
                grdEvent.Columns[10].Visible = false;
            }
            else           // if condition is fail. Then Relay Event column is show in gridview
            {
                grdEvent.Columns[10].Visible = true;
            }
        }





        // if delete button is clicked. Then delete each data from gridview 

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "delete from EventDetails where Admission_No = '" + txtAdmission.Text +"'";           // select the wanted record for delete using Admission No textbox 
            cmd.ExecuteNonQuery();
            conn.Close();
            display();        
            MessageBox.Show("Record deleted successfully.");    // after delete sucessfully then display this message
        }






        // click the search button

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from EventDetails where Admission_No = '" + txtAdmission.Text +"'";      // search the item in gridview using the Admission No
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grdEvent.DataSource = dt;
            conn.Close();
        }






        // click display button

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            display();          // display the gridview
        }
    }
}
