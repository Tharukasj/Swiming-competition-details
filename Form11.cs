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
    public partial class Form11 : Form
    {

        // give connection string

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-THPNSVGP;Initial Catalog=swimming;Integrated Security=True");

        


        public Form11()
        {
            InitializeComponent();
        }


       


        // click 50 freestyle button

        private void btn50Freestyle_Click(object sender, EventArgs e)
        {
            // check whether all field are fill

            if ((txtAdmission.Text != "") && (cmbEvent.Text != "") && (txtTime.Text != ""))
            {
                try
                {
                    // condition is true database open and add value to database place details

                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "insert into PlaceDetails values(@Admission_No, @Event, @Performance_Time)";     // insert value to table
                    cmd.Parameters.AddWithValue("@Admission_No", txtAdmission.Text);
                    cmd.Parameters.AddWithValue("@Event", cmbEvent.Text);
                    cmd.Parameters.AddWithValue("@Performance_Time", txtTime.Text);



                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sucessfull");



                    //  click finish button go to main form and add result form close.

                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Close();


                }

                // code for if have error dispaly it

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }


            }


            else // all area not fill
            {
                MessageBox.Show("Fill all areas");
            }
        }





        // click 100 freestyle button

        private void btn100Freestyle_Click(object sender, EventArgs e)
        {
            // check whether all field are fill

            if ((txtAdmission.Text != "") && (cmbEvent.Text != "") && (txtTime.Text != ""))
            {
                try
                {
                    // condition true, then database open and add value to database place details

                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "insert into PlaceDetails_2 values(@Admission_No, @Event, @Performance_Time)";     // insert value to table
                    cmd.Parameters.AddWithValue("@Admission_No", txtAdmission.Text);
                    cmd.Parameters.AddWithValue("@Event", cmbEvent.Text);
                    cmd.Parameters.AddWithValue("@Performance_Time", txtTime.Text);


                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sucessfull");



                    // click finish button go to main form and add result form close.

                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Close();


                }

                // code for if have error dispaly it

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }



            }

            else // all area not fill display this message
            {
                MessageBox.Show("Fill all areas");
            }
        }







        // click 200 freestyle button

        private void btn200Freestyle_Click(object sender, EventArgs e)
        {
            // check whether all field are fill

            if ((txtAdmission.Text != "") && (cmbEvent.Text != "") && (txtTime.Text != ""))
            {
                try
                {
                    // if condition is true then database open and add value to database place details

                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "insert into PlaceDetails_3 values(@Admission_No, @Event, @Performance_Time)";     // insert value to table
                    cmd.Parameters.AddWithValue("@Admission_No", txtAdmission.Text);
                    cmd.Parameters.AddWithValue("@Event", cmbEvent.Text);
                    cmd.Parameters.AddWithValue("@Performance_Time", txtTime.Text);


                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sucessfull");

                    

                    // click finish button go to main form and add result form close.

                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Close();


                }

                // code for if have error dispaly it

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }



            }

            else // are area not fill, display this message
            {
                MessageBox.Show("Fill all areas");
            }

        }





     // click 500 freestyle button

        private void btn500Freestyle_Click(object sender, EventArgs e)
        {
            // check whether all field are fill

            if ((txtAdmission.Text != "") && (cmbEvent.Text != "") && (txtTime.Text != ""))
            {

                try
                {
                    // condition is tur then database open and add value to database place details

                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "insert into PlaceDetails_4 values(@Admission_No, @Event, @Performance_Time)";     // insert value to table
                    cmd.Parameters.AddWithValue("@Admission_No", txtAdmission.Text);
                    cmd.Parameters.AddWithValue("@Event", cmbEvent.Text);
                    cmd.Parameters.AddWithValue("@Performance_Time", txtTime.Text);


                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sucessfull");

                   

                    // click finish button go to main form and add result form close.

                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Close();


                }

                // code for if have error dispaly it

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }



            }

            else   // condition is false display this message
            {
                MessageBox.Show("Fill all areas");
            }


        }



        // click 100 butterfly button

        private void btn100Butterfly_Click(object sender, EventArgs e)
        {
            // check whether all field are fill

            if ((txtAdmission.Text != "") && (cmbEvent.Text != "") && (txtTime.Text != ""))
            {
                try
                {
                    // condition is true, then database open and add value to database place details

                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "insert into PlaceDetails_5 values(@Admission_No, @Event, @Performance_Time)";     // insert value to table
                    cmd.Parameters.AddWithValue("@Admission_No", txtAdmission.Text);
                    cmd.Parameters.AddWithValue("@Event", cmbEvent.Text);
                    cmd.Parameters.AddWithValue("@Performance_Time", txtTime.Text);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sucessfull");

                    

                    // click finish button go to main form and add result form close.

                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Close();


                }

                // code for if have error dispaly it

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }



            }

            else  // condition is false then display this message
            {
                MessageBox.Show("Fill all areas");
            }
        }





        // click 100 Backstroke button


        private void btn100Backstroke_Click(object sender, EventArgs e)
        {
            // check whether all field are fill

            if ((txtAdmission.Text != "") && (cmbEvent.Text != "") && (txtTime.Text != ""))
            {
                try
                {
                    // condition is true, then database open and add value to database place details

                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "insert into PlaceDetails_6 values(@Admission_No, @Event, @Performance_Time)";     // insert value to table
                    cmd.Parameters.AddWithValue("@Admission_No", txtAdmission.Text);
                    cmd.Parameters.AddWithValue("@Event", cmbEvent.Text);
                    cmd.Parameters.AddWithValue("@Performance_Time", txtTime.Text);


                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sucessfull");

                    

                    // click finish button go to main form and add result form close.

                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Close();


                }

                // code for if have error dispaly it

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }



            }

            else   //condition fall, display this message
            {
                MessageBox.Show("Fill all areas");
            }
        }






        // click 100 Breakstroke button

        private void btn100Breakstroke_Click(object sender, EventArgs e)
        {  // check whether all field are fill

            if ((txtAdmission.Text != "") && (cmbEvent.Text != "") && (txtTime.Text != ""))
            {

                try
                {
                    // condition is true then database open and add value to database place details

                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "insert into PlaceDetails_7 values(@Admission_No, @Event, @Performance_Time)";     // insert value to table
                    cmd.Parameters.AddWithValue("@Admission_No", txtAdmission.Text);
                    cmd.Parameters.AddWithValue("@Event", cmbEvent.Text);
                    cmd.Parameters.AddWithValue("@Performance_Time", txtTime.Text);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sucessfull");

                    

                    // click finish button go to main form and add result form close.

                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Close();


                }

                // code for if have error dispaly it

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }



            }

            else
            {
                MessageBox.Show("Fill all areas");
            }
        }






        // click 200 Individual Medley button

        private void btn200IndividualMedley_Click(object sender, EventArgs e)
        {

            // check whether all field are fill

            if ((txtAdmission.Text != "") && (cmbEvent.Text != "") && (txtTime.Text != ""))
            {

                try
                {
                    // condition is true then database open and add value to database place details

                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "insert into PlaceDetails_8 values(@Admission_No, @Event, @Performance_Time)";     // insert value to table
                    cmd.Parameters.AddWithValue("@Admission_No", txtAdmission.Text);
                    cmd.Parameters.AddWithValue("@Event", cmbEvent.Text);
                    cmd.Parameters.AddWithValue("@Performance_Time", txtTime.Text);


                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sucessfull");

                  

                    // click finish button go to main form and add result form close.

                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Close();


                }

                // code for if have error dispaly it

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }


            }

            else // all area not fill, display this message
            {
                MessageBox.Show("Fill all areas");
            }


        }





        // click 1 Meter Driving button

        private void btn1MeterDriving_Click(object sender, EventArgs e)
        {
            // check whether all field are fill

            if ((txtAdmission.Text != "") && (cmbEvent.Text != "") && (txtTime.Text != ""))
            {
                try
                {
                    // condition is true, then database open and add value to database place details

                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "insert into PlaceDetails_9 values(@Admission_No, @Event, @Performance_Time)";     // insert value to table
                    cmd.Parameters.AddWithValue("@Admission_No", txtAdmission.Text);
                    cmd.Parameters.AddWithValue("@Event", cmbEvent.Text);
                    cmd.Parameters.AddWithValue("@Performance_Time", txtTime.Text);


                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sucessfull");

                   

                    // click finish button go to main form and add result form close.

                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Close();


                }

                // code for if have error dispaly it

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }



            }

            else // conditional false
            {
                MessageBox.Show("Fill all areas");
            }
        }






        // click 200 freestyle relay button

        private void btn200FreestyleRelay_Click(object sender, EventArgs e)
        {

            // check whether all field are fill

            if ((txtAdmission.Text != "") && (cmbEvent.Text != "") && (txtTime.Text != ""))
            {

                try
                {
                    // if condition is true, then database open and add value to database place details

                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "insert into PlaceDetailsRelay_1 values(@Admission_No, @Event, @Performance_Time)";     // insert value to table
                    cmd.Parameters.AddWithValue("@Admission_No", txtAdmission.Text);
                    cmd.Parameters.AddWithValue("@Event", cmbEvent.Text);
                    cmd.Parameters.AddWithValue("@Performance_Time", txtTime.Text);


                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sucessfull");

                  

                    // click finish button go to main form and add result form close.

                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Close();


                }

                // code for if have error dispaly it

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }



            }

            else  // condition fail
            {
                MessageBox.Show("Fill all areas");
            }
        }





        // click 400 freestyle relay button


        private void btn400FreestyleRelay_Click(object sender, EventArgs e)
        {

            // check whether all field are fill

            if ((txtAdmission.Text != "") && (cmbEvent.Text != "") && (txtTime.Text != ""))
            {

                try
                {
                    // condition is true, then database open and add value to database place details

                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "insert into PlaceDetailsRelay_2 values(@Admission_No, @Event, @Performance_Time)";     // insert value to table
                    cmd.Parameters.AddWithValue("@Admission_No", txtAdmission.Text);
                    cmd.Parameters.AddWithValue("@Event", cmbEvent.Text);
                    cmd.Parameters.AddWithValue("@Performance_Time", txtTime.Text);


                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sucessfull");

                 

                    //click finish button go to main form and add result form close.

                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Close();


                }

                // code for if have error dispaly it

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }



            }

            else //condition gail
            {
                MessageBox.Show("Fill all areas");
            }


        }





        // click 200 medley relay button


        private void btn200MeedleyRelay_Click(object sender, EventArgs e)
        {
            // check whether all field are fill

            if ((txtAdmission.Text != "") && (cmbEvent.Text != "") && (txtTime.Text != ""))
            {

                try
                {
                    // condition is true, then database open and add value to database place details

                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "insert into PlaceDetailsRelay_3 values(@Admission_No, @Event, @Performance_Time)";     // insert value to table
                    cmd.Parameters.AddWithValue("@Admission_No", txtAdmission.Text);
                    cmd.Parameters.AddWithValue("@Event", cmbEvent.Text);
                    cmd.Parameters.AddWithValue("@Performance_Time", txtTime.Text);


                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sucessfull");

                

                    // click finish button go to main form and add result form close.

                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Close();


                }

                // code for if have error dispaly it

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }



            }

            else
            {
                MessageBox.Show("Fill all areas");
            }
        }






        // click back button

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }





    }
































              
        }











          


    


