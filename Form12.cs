using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swim
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }



        // click event button

        private void event_click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();       // go to event details form
            f13.Show();                      // show that form
            this.Hide();                    // hide get report form when go to event details form
        }





        // click place button

        private void place_click(object sender, EventArgs e)
        {
            Form18 f18 = new Form18();          // go to event categories form
            f18.Show();
            this.Hide();                        // close get report form when go to event categories form
        }





        // click competition button

        private void Competition_click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();          // go to competition details form
            f16.Show();
            this.Hide();                        // close get report form when go to competition details form
        }




        // go to coach fetails form

        private void button1_Click(object sender, EventArgs e)
        {
            Form17 f17 = new Form17();          // go to coach details form
            f17.Show();
            this.Hide();                        // close get report form when go to competition details form
        }




        // what happen click back button

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();          // go to main form
            f1.Show();                   // show main form
            this.Close();              // close the " Get Report" when go to main form
        }




    }
}
