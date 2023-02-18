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
    public partial class Form4 : Form
    {


        // give connection string

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-THPNSVGP;Initial Catalog=swimming;Integrated Security=True");


        public string addadmission;
        
        public Form4()
        {
            InitializeComponent();
        }


        // constructor for get data from form 3

        public Form4(string addadmission)
        {
            InitializeComponent();
            this.addadmission = addadmission;
        }



        // what happen click back button

        private void Back_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();           // go to form 3 (event form)
            f3.Show();                      // show that form
            this.Hide();                 // hide this form when go to form 2
        }




        // what happen click finish button

        private void Finish_click(object sender, EventArgs e)
        {

            // check all filed are fill. Then insert data to database

            if ((txtAdmissionNo.Text != "") && (txtMiccName.Text != "") && (txtPhone.Text != "")
                    && (txtCoachName.Text != "") && (txtCoachPhone.Text != ""))
            {

                // open the database and add data to database

                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "insert into CoachDetails values(@Admission_No, @MICC_Name, @MICC_Phone_No, @Coach_Name, @Coach_Phone_No)";
                    cmd.Parameters.AddWithValue("@Admission_No", txtAdmissionNo.Text);
                    cmd.Parameters.AddWithValue("@MICC_Name", txtMiccName.Text);
                    cmd.Parameters.AddWithValue("@MICC_Phone_No", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@Coach_Name", txtCoachName.Text);
                    cmd.Parameters.AddWithValue("@Coach_Phone_No", txtCoachPhone.Text);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sucessfull");       // data insert is successful then display this message



                    Form1 f1 = new Form1();       // and after data insert correctly, go to main form
                    f1.Show();
                    this.Hide();                 // hide this form when go to main form
                                                 //}

                }

                // if there have error display it

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }

            }

            else  // all area not fill
            {
                MessageBox.Show("Fill all areas");
            }

        }

       



        // this form is load, then addmission no is auto fill.

        private void Form4_Load(object sender, EventArgs e)
        {
            txtAdmissionNo.Text = addadmission;       // admission no give to textbox
        }



    }
}
