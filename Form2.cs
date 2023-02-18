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
    public partial class Form2 : Form
    {


        // give conection string

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-THPNSVGP;Initial Catalog=swimming;Integrated Security=True");

        




        public Form2()
        {
            InitializeComponent();

        }





        // mouse heover to continue button display "Add event details" 

        private void change_text(object sender, EventArgs e)
        {
            btnContinue.Text = "Add event details";
            btnContinue.ForeColor = Color.Green;           // color change to green
        }





        // mouse leave from "Add event details" button to display "continue" 

        private void btnContinue_MouseLeave(object sender, EventArgs e)
        {
            btnContinue.Text = "Continue";
        }







        // click continue button

        private void btn_click(object sender, EventArgs e)
        {
            
            // go to form 3 give event details
            /*   here at least one filed is empty then can't go to event detals.
                  it is checked using "if" condition.*/


            if ((txtNo.Text != "") && (txtName.Text != "") && (txtAge.Text != "") && (cmbAge.Text != "") &&
                 (cmbSex.Text != "") && (txtId.Text != "") && (cmbHouse.Text != "") && (cmbSchool.Text != "") &&
                 (cmbZonal.Text != "") && (cmbDistrict.Text != "") && (cmbProvince.Text != "") &&
                  (txtBirth.Text != "")) 

            {
                Form3 f3 = new Form3(txtNo.Text);       // Then condition is true go and tranfer data of addmission number event form 
                f3.Show();
                this.Hide();                 // hide add athelete form
            }

            else        // condition is fails show error message
            {
                MessageBox.Show("Fill all areas");
            }



                
        }






       


        // click add button near the age group textbox 

        private void add_click(object sender, EventArgs e)
        {


            gbAddAge.Visible = true;        // Add button is click display the box to add age groups

        
        }






        // click add button near the house textbox

        private void addHouse_click(object sender, EventArgs e)
        {
           
            gbAddHouse.Visible = true;         // Add button is click display the box to add House to house combobox

        }




        // click add button near the school textbox 

        private void AddSchool_click(object sender, EventArgs e)
        {

            gbAddSchool.Visible = true;        // Add button is click display the box to add school to school combobox


        }





        // click add button near the zonal textbox

        private void AddZonal_click(object sender, EventArgs e)
        {

            gbAddZonal.Visible = true;        // Add button is click then display the box to add zonal to zonal combobox
        }






        // click add button near the district textbox

        private void AddDistrict_click(object sender, EventArgs e)
        {
            
            gbAddDistrict.Visible = true;        // Add button is click then display the box to add district to district combobx

        }






        // click add button near the province textbox 

        private void AddProvince_click(object sender, EventArgs e)
        {
            gbAddProvince.Visible = true;           // Add button is click then display the box to add province to province combobox
        }





        /////////////////////////////////////////////////////////////////////////////////////////////





        // calculate the age using birthday and current day

        private void btnCalAge_Click(object sender, EventArgs e)
        {
            try
            {
                if(dtpCurrentDate.Value < dtpDOB.Value)
                {
                    MessageBox.Show("Current date is greater than DOB");
                }

                int age = dtpCurrentDate.Value.Year - dtpDOB.Value.Year;        // calculate age
                
                // if add DOB + age < current date

                if (dtpDOB.Value.AddYears(age) > dtpCurrentDate.Value)
                {
                    age--;
                }

                txtAge.Text = age.ToString();     // show age
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }







        // what happen add athelete form load

        private void Form2_Load(object sender, EventArgs e)
        {
           

            // add item to age combobox

            cmbAge.Items.Add("9 below");
            cmbAge.Items.Add("11 below");
            cmbAge.Items.Add("13 below");
            cmbAge.Items.Add("15 below");
            cmbAge.Items.Add("17 below");
            cmbAge.Items.Add("19 below");
            cmbAge.Items.Add("21 below");
            cmbAge.Items.Add("23 below");
            








            /////////////////////////////////////////////////////////////////////////////////////////////////



            // add items to house combobox

            cmbHouse.Items.Add("Vijaya");
            cmbHouse.Items.Add("Gemunu");
            cmbHouse.Items.Add("Perakum");


            




            /////////////////////////////////////////////////////////////////////////////////////////////////


            // add items to school combobox

            cmbSchool.Items.Add("Mo / Mariarawa Secondary School");
            cmbSchool.Items.Add("Mo / Royal Collage");


           



            ///////////////////////////////////////////////////////////////////////////////////////////////////

            // add items to zonal combobox

            cmbZonal.Items.Add("Bibile");
            cmbZonal.Items.Add("Monaragala");


            


            /////////////////////////////////////////////////////////////////////////////////////////////////


            // add items to district combobox

            cmbDistrict.Items.Add("Monaragala");
            cmbDistrict.Items.Add("Badulla");
            cmbDistrict.Items.Add("Gampaha");


            





            /////////////////////////////////////////////////////////////////////////////////////////////////


            // add items to province combobox

            cmbProvince.Items.Add("Uva");
            cmbProvince.Items.Add("Western");
            cmbProvince.Items.Add("South");



        }




        ////////////////////////////////////////////////////////////////////////////////////////////////////




        // what happen click save button

        private void btnSave_Click(object sender, EventArgs e)
        {

            // check all fiel are selected and then condition is true then insert data to the database

            if ((txtNo.Text != "") && (txtName.Text != "") && (txtAge.Text != "") && (cmbAge.Text != "") &&
                      (cmbSex.Text != "") && (txtId.Text != "") && (cmbHouse.Text != "") && (cmbSchool.Text != "") &&
                      (cmbZonal.Text != "") && (cmbDistrict.Text != "") && (cmbProvince.Text != "") &&
                      (txtBirth.Text != ""))
            {
                try
                {
                    //  open the database and add value to database

                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "insert into athleteDetails values(@Admission_No, @Name, @DOB, @Age, @Age_Group, @Sex, @ID, @House, @School, @Zonal, @District, @Province, @DOB_Certificate_No, @Date)";
                    cmd.Parameters.AddWithValue("@Admission_No", txtNo.Text);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@DOB", dtpDOB.Text);
                    cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                    cmd.Parameters.AddWithValue("@Age_Group", cmbAge.Text);
                    cmd.Parameters.AddWithValue("@Sex", cmbSex.Text);
                    cmd.Parameters.AddWithValue("@ID", txtId.Text);
                    cmd.Parameters.AddWithValue("@House", cmbHouse.Text);
                    cmd.Parameters.AddWithValue("@School", cmbSchool.Text);
                    cmd.Parameters.AddWithValue("@Zonal", cmbZonal.Text);
                    cmd.Parameters.AddWithValue("@District", cmbDistrict.Text);
                    cmd.Parameters.AddWithValue("@Province", cmbProvince.Text);
                    cmd.Parameters.AddWithValue("@DOB_Certificate_No", txtBirth.Text);
                    cmd.Parameters.AddWithValue("@Date", dtpCurrentDate.Text);


                   
                    cmd.ExecuteNonQuery();
                    conn.Close();                    // close the database
                    MessageBox.Show("Sucessfull");


                }



                catch (Exception ex)          // display error if there have error when insert data to database 
                {
                    MessageBox.Show(ex.Message, "Error");
                }



            }

            else         // condition is false display message 
            {
                MessageBox.Show("Fill all the fields.");
            }





        }






        // what happen click back button

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();             // go to main form
            f1.Show();                     // show that form
            this.Close();                 // close "add athele" form when go to main form
        }




        /* here give code for add, delete, reset, cancel the box of,
                       && add age group
                       && add house
                       && add school 
                       && add zonal
                       && add district
                       && add province 
        */ 


        /////////////////////////////////////////////////////////////////////////////////////////
        
        // click the Add button in age group box

        private void btnadd_Click(object sender, EventArgs e)
        {

            if (!cmbAge.Items.Contains(txtAddAge.Text))       // check whether add Age group not in age goup condition
            {
              
                cmbAge.Items.Add(txtAddAge.Text.Trim());     // condition is true the add age to age group combobox
                gbAddAge.Visible = false;                  // close the box of adding age group

            }

            else       // if combobox contain age group then show message
            {
                MessageBox.Show("You already have this age");

            }
            

        }



        // click the delete button in age group box

        private void btndeleteAge_Click(object sender, EventArgs e)
        {
            cmbAge.Items.Remove(txtAddAge.Text);      // delete the combobox age that give in age group of in textbox
            
        }



        // click the cancel button in age group box

        private void btnCancelAge_Click(object sender, EventArgs e)
        {
            gbAddAge.Visible = false;       // close the box of adding age
        }




        // click the reset button in age group box

        private void btnResetAge_Click(object sender, EventArgs e)
        {
            txtAddAge.Text = "";        // do empty textbox value
        }






        /////////////////////////////////////////////////////////////////////////////////////////


        // click the Add button in house group box

        private void btnAddHouse_Click(object sender, EventArgs e)
        {
            if (!cmbHouse.Items.Contains(txtAddHouse.Text))       // check adding house os not in house combobox
            {

                cmbHouse.Items.Add(txtAddHouse.Text.Trim());      // condition is true, then add the house to house combobox
                gbAddHouse.Visible = false;                    // close the box

            }

            else       // if contain age group then show message
            {
                MessageBox.Show("You already have this house");

            }

        }



        // click the delete button in house group box

        private void btnDeleteHouse_Click(object sender, EventArgs e)
        {
            cmbHouse.Items.Remove(txtAddHouse.Text);      // delete the item in house combobox that adding house to textbox
        }




        // click the reset button in house group box

        private void btnResetHouse_Click(object sender, EventArgs e)
        {
            txtAddHouse.Text = "";         // do empty value of textbox of adding house
        }




        // click the cancel button in house group box

        private void btnCancelHouse_Click(object sender, EventArgs e)
        {
            gbAddHouse.Visible = false;        // close the box
        }







        /////////////////////////////////////////////////////////////////////////////////////////////


        // click the Add button in school group box

        private void btnAddSchool_Click(object sender, EventArgs e)
        {
            // add items using textbox
            // check whether adding item already in the school combobox

            if (!cmbSchool.Items.Contains(txtAddSchool.Text))   // if combobox does not cantain that adding school, then add school to combobox
            {

                cmbSchool.Items.Add(txtAddSchool.Text.Trim());
                gbAddSchool.Visible = false;                     // close the box
            }

            else   // if combobox have that school give error message
            {
                MessageBox.Show("You already have this school");
            }

        }





        // click the delete button in school group box

        private void btnbtnDeleteSchool_Click(object sender, EventArgs e)
        {
            cmbSchool.Items.Remove(txtAddSchool.Text);       // delete item in school combobox that item give using textbox
        }





        // click the reset button in school group box

        private void btnResetSchool_Click(object sender, EventArgs e)
        {
            txtAddSchool.Text = "";        // do empty textbox
        }





        // click the cancel button in school group box

        private void btnCancelSchool_Click(object sender, EventArgs e)
        {
            gbAddSchool.Visible = false;          // close the school adding box
        }



        /////////////////////////////////////////////////////////////////////////////////////////////////


        // click the Add button in zonal group box

        private void btnAddZonal_Click(object sender, EventArgs e)
        {
            // add items using textbox
            // check whether adding item already in the zonal combobox


            if (!cmbZonal.Items.Contains(txtAddZonal.Text))   // if combobox does not cantain that adding zonal, then add zonal to combobox
            {
                cmbZonal.Items.Add(txtAddZonal.Text.Trim());
                gbAddZonal.Visible = false;                    // close the adding zonal box
            }

            else   // if combobox have that zonal give error message
            {
                MessageBox.Show("You already have this zonal");
            }
        }




        // click the delete button in zonal group box

        private void btnDeleteZonal_Click(object sender, EventArgs e)
        {
            cmbZonal.Items.Remove(txtAddZonal.Text);       // remove item from combobox of zonal
        }





        // click the reset button in zonal group box

        private void btnResetZonal_Click(object sender, EventArgs e)
        {
            txtAddZonal.Text = "";         // make empty of textbox 
        }




        // click the cancel button in zonal group box

        private void btnCancelZonal_Click(object sender, EventArgs e)
        {
            gbAddZonal.Visible = false;           // close the box of adding zonal
        }






        /////////////////////////////////////////////////////////////////////////////////////////



        // click the Add button in district group box

        private void btnAddDistrict_Click(object sender, EventArgs e)
        {
            // add items using textbox
            // check whether adding item already in the district combobox

            if (!cmbDistrict.Items.Contains(txtAddDistrict.Text))   // if combobox does not cantain that adding district, then add district to combobox
            {
                cmbDistrict.Items.Add(txtAddDistrict.Text.Trim());
                gbAddDistrict.Visible = false;                     // close box
            }

            else   // if combobox have that district give error message
            {
                MessageBox.Show("You already have this district");
            }


        }




        // click the delete button in district group box

        private void btnDeleteDistrict_Click(object sender, EventArgs e)
        {
            cmbDistrict.Items.Remove(txtAddDistrict.Text);     //item delete from combobox
        }




        // click the reset button in district group box

        private void btnResetDistrict_Click(object sender, EventArgs e)
        {
            txtAddDistrict.Text = "";        // empty textbox
        }




        // click the cancel button in district group box

        private void btnCancelDistrict_Click(object sender, EventArgs e)
        {
            gbAddDistrict.Visible = false;           // close the box of adding district 
        }





        //////////////////////////////////////////////////////////////////////////////////////////

        // click the Add button in province group box

        private void btnAddProvince_Click(object sender, EventArgs e)
        {
            if (!cmbProvince.Items.Contains(txtAddProvince.Text))   // check whether adding province in the combobox.if combobox does not cantain that adding district, then add district to combobox
            {
                cmbProvince.Items.Add(txtAddProvince.Text.Trim());
                gbAddProvince.Visible = false;                      // close the box
            }

            else   // if combobox have that district give error message
            {
                MessageBox.Show("You already have this province");
            }


        }






        // click the delete button in province group box

        private void bntDeleteProvince_Click(object sender, EventArgs e)
        {
            cmbProvince.Items.Remove(txtAddProvince.Text);        // delete item from combobox
        }





        // click the reset button in province group box

        private void btnResetProvince_Click(object sender, EventArgs e)
        {
            txtAddProvince.Text = "";           // do empty textbox of adding province 
        }





        // click the cancel button in province group box

        private void btnCancelProvince_Click(object sender, EventArgs e)
        {
            gbAddProvince.Visible = false;          // close the box of adding proovince
        }




    }
}
