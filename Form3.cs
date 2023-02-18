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
    public partial class Form3 : Form
    {

        // give connection string

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-THPNSVGP;Initial Catalog=swimming;Integrated Security=True");


        public string admissionNo;


        public Form3()
        {
            InitializeComponent();
        }



        // constructor for get data from form 2


        public Form3(string admissionNo)
        {
            InitializeComponent();
            this.admissionNo = admissionNo;


        }



        // click more button visible other radio button

        private void add_count(object sender, EventArgs e)
        {
            rdb6.Visible = true;
            rdb7.Visible = true;
            rdb8.Visible = true;
            rdb9.Visible = true;
           // rdb10.Visible = true;

        }




        // mouse point to continue button display continue button like "Add Coach Details"

        private void button2_MouseHover(object sender, EventArgs e)
        {
            btnContinue.Text = "Add Caoch Details";
            btnContinue.ForeColor = Color.Green;
        }




        // mouse point leave  to continue button display continue button like "Continue"

        private void btnContinue_MouseLeave(object sender, EventArgs e)
        {
            btnContinue.Text = "Continue";
        }




        // click continue button

        private void Btn_Click(object sender, EventArgs e)
        {
            // here check all feilds are fill in the form

            if ((txtAdmissionNo.Text != "") && (rdb3.Text != "") && (rdb5.Text != "") && (rdb6.Text != "")
                   && (rdb7.Text != "") && (rdb8.Text != "") && (rdb9.Text != "") && (cmbRelay.Text != ""))

            {
                // if condition is true then go next form

                Form4 f4 = new Form4();       // go to Add Coach Details form
                f4.addadmission = txtAdmissionNo.Text;
                f4.Show();
                this.Hide();                 // close add event details form when login to Add Coach Details form
            }
               

        }





        // click back button

        private void Back_click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();     // go to Add Coach Details form Add Athlete form
            f2.Show();
            this.Hide();               // close add event details form when login to Add Athlete form
        }




        // choose event 3

        private void Select_3(object sender, EventArgs e)
        {
            gbEvent3.Visible = true;        // visible the 3 combobox to add event
            gbEvent5.Hide();                // hide the 5 combobox of add event
            rdb6.Hide();                    // hide the radio button 6
            rdb7.Hide();                    // hide the radio button 7             
            rdb8.Hide();                    // hide the radio button 8
            rdb9.Hide();                    // hide the radio button 9
            cdlEvents.Hide();               // hide the checklist box
        }





        // choose event 5

        private void Select_5(object sender, EventArgs e)
        {
            gbEvent5.Visible = true;        // visible the 5 combobox of add event
            gbEvent3.Hide();               // hide the 3 combobox to add event
            rdb6.Hide();                   // hide the radio button 6
            rdb7.Hide();                   // hide the radio button 7 
            rdb8.Hide();                   // hide the radio button 8
            rdb9.Hide();                   // hide the radio button 9
            cdlEvents.Hide();              // hide the checklist box
        }




        // choose event 6

        private void Select_6(object sender, EventArgs e)
        {
            cdlEvents.Visible = true;         // visible the checklist box to choose event
            gbEvent3.Hide();                  // hide the 3 combobox to add event
            gbEvent5.Hide();                  // hide the 5 combobox of add event

        }





        // choose event 7

        private void Select_7(object sender, EventArgs e)
        {
            cdlEvents.Visible = true;         // visible the checklist box to choose event
            gbEvent3.Hide();                  // hide the 3 combobox to add event
            gbEvent5.Hide();                  // hide the 5 combobox of add event
        }






        // choose event 8

        private void Select_8(object sender, EventArgs e)
        {
            cdlEvents.Visible = true;         // visible the checklist box to choose event
            gbEvent3.Hide();                  // hide the 3 combobox to add event
            gbEvent5.Hide();                  // hide the 5 combobox of add event
        }






        // choose event 9

        private void Select_9(object sender, EventArgs e)
        {
            cdlEvents.Visible = true;        // visible the checklist box to choose event
            gbEvent3.Hide();                 // hide the 3 combobox to add event
            gbEvent5.Hide();                 // hide the 5 combobox of add event
        }





        // choose event 10

        private void Select_10(object sender, EventArgs e)
        {
            cdlEvents.Visible = true;       // visible the checklist box to choose event
            gbEvent3.Hide();                 // hide the 3 combobox to add event
            gbEvent5.Hide();                // hide the 5 combobox of add event
        }

       


        // click save button

        private void btnSave_Click(object sender, EventArgs e)
        {

            // check wether all fields are fill.Then insert data t0 database

            if ((txtAdmissionNo.Text != "") && (rdb3.Text != "") && (rdb5.Text != "") && (rdb6.Text != "")
                    && (rdb7.Text != "") && (rdb8.Text != "") && (rdb9.Text != "") && (cmbRelay.Text != ""))
            {

                // if click save button then database open and insert data to database

                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "insert into EventDetails values(@Admission_No, @Event_1, @Event_2, @Event_3, @Event_4, @Event_5, @Event_6, @Event_7, @Event_8, @Event_9, @Relay_Event)";
                    cmd.Parameters.AddWithValue("@Admission_No", txtAdmissionNo.Text);


                    // if choose event is 3. Then only give three events to database and others are make empty 

                    if (rdb3.Checked)
                    {
                        cmd.Parameters.AddWithValue("@Event_1", cmb1event3.Text);
                        cmd.Parameters.AddWithValue("@Event_2", cmb2Event3.Text);
                        cmd.Parameters.AddWithValue("@Event_3", cmb3Event3.Text);
                        cmd.Parameters.AddWithValue("@Event_4", "");
                        cmd.Parameters.AddWithValue("@Event_5", "");
                        cmd.Parameters.AddWithValue("@Event_6", "");
                        cmd.Parameters.AddWithValue("@Event_7", "");
                        cmd.Parameters.AddWithValue("@Event_8", "");
                        cmd.Parameters.AddWithValue("@Event_9", "");
                        cmd.Parameters.AddWithValue("@Relay_Event", cmbRelay.Text);
                    }



                    // if choose event is 5. Then only give five events to database and others are make empty

                    else if (rdb5.Checked)
                    {
                        cmd.Parameters.AddWithValue("@Event_1", cmb1Event5.Text);
                        cmd.Parameters.AddWithValue("@Event_2", cmb2Event5.Text);
                        cmd.Parameters.AddWithValue("@Event_3", cmb3Event5.Text);
                        cmd.Parameters.AddWithValue("@Event_4", cmb4Event5.Text);
                        cmd.Parameters.AddWithValue("@Event_5", cmb5Event5.Text);
                        cmd.Parameters.AddWithValue("@Event_6", "");
                        cmd.Parameters.AddWithValue("@Event_7", "");
                        cmd.Parameters.AddWithValue("@Event_8", "");
                        cmd.Parameters.AddWithValue("@Event_9", "");
                        cmd.Parameters.AddWithValue("@Relay_Event", cmbRelay.Text);
                    }


                    // if choose event is 6. Then only give six events to database and others are make empty

                    else if (rdb6.Checked)
                    {
                        cmd.Parameters.AddWithValue("@Event_1", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_2", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_3", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_4", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_5", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_6", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_7", "");
                        cmd.Parameters.AddWithValue("@Event_8", "");
                        cmd.Parameters.AddWithValue("@Event_9", "");
                        cmd.Parameters.AddWithValue("@Relay_Event", cmbRelay.Text);
                    }



                    // if choose event is 7. Then only give seven events to database and others are make empty

                    else if (rdb7.Checked)
                    {
                        cmd.Parameters.AddWithValue("@Event_1", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_2", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_3", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_4", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_5", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_6", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_7", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_8", "");
                        cmd.Parameters.AddWithValue("@Event_9", "");
                        cmd.Parameters.AddWithValue("@Relay_Event", cmbRelay.Text);
                    }



                    // if choose event is 8. Then only give eight events to database and others are make empty

                    else if (rdb8.Checked)
                    {
                        cmd.Parameters.AddWithValue("@Event_1", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_2", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_3", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_4", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_5", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_6", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_7", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_8", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_9", "");
                        cmd.Parameters.AddWithValue("@Relay_Event", cmbRelay.Text);
                    }



                    // if choose event is 9. Then only give nine events to database and others are make empty

                    else if (rdb9.Checked)
                    {
                        cmd.Parameters.AddWithValue("@Event_1", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_2", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_3", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_4", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_5", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_6", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_7", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_8", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Event_9", cdlEvents.Text);
                        cmd.Parameters.AddWithValue("@Relay_Event", cmbRelay.Text);
                    }

                    // if not choose any event then show this message

                    else
                    {
                        MessageBox.Show("Choose your events.");
                    }



                   //execute the database

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sucessfull");
                    

                }

                // if have error. Then display it.

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }

            }

            else    // all area not fill
            {
                MessageBox.Show("Fill all areas");
            }
           


            }




        // when form load admission number is autofill. It give from form 2

        private void Form3_Load(object sender, EventArgs e)
        {
            txtAdmissionNo.Text = admissionNo;      // add admission number to textbox
        }


    }
        
}
