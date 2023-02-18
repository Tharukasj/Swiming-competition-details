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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }



        // go to form 14
        private void btn50Freestyle_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();      // go to form14 to view the datagrid of event 50 Freestyle
            f14.Show();         // show that form
            this.Hide();        // hide this form when go to form 14
        }




        // go to form 19

        private void btn100Freestyle_Click(object sender, EventArgs e)
        {
            Form19 f19 = new Form19();      // go to form19 to view the datagrid of event 100 Freestyle
            f19.Show();         // show that form
            this.Hide();        // hide this form when go to form 19
        }




        // go to form 20
        private void btn200Freestyle_Click(object sender, EventArgs e)
        {
            Form20 f20 = new Form20();      // go to form20 to view the datagrid of event 200 Freestyle
            f20.Show();         // show that form
            this.Hide();        // hide this form when go to form 20
        }




        // go to form 21

        private void btn500Freestyle_Click(object sender, EventArgs e)
        {
            Form21 f21 = new Form21();      // go to form21 to view the datagrid of event 500 Freestyle
            f21.Show();         // show that form
            this.Hide();        // hide this form when go to form 21
        }




        // go to form 23

        private void btn100Butterfly_Click(object sender, EventArgs e)
        {
            Form23 f23 = new Form23();      // go to form23 to view the datagrid of event 100 Butterfly
            f23.Show();         // show that form
            this.Hide();        // hide this form when go to form 23
        }




        // go to form 24
        private void btn100Backstroke_Click(object sender, EventArgs e)
        {
            Form24 f24 = new Form24();      // go to form24 to view the datagrid of event 100 Backstroke
            f24.Show();         // show that form
            this.Hide();        // hide this form when go to form 24
        }




        // go to form 25

        private void btn100Breakstroke_Click(object sender, EventArgs e)
        {
            Form25 f25 = new Form25();      // go to form25 to view the datagrid of event 100 Breakstroke
            f25.Show();         // show that form
            this.Hide();        // hide this form when go to form 25
        }




        // go to form 26

        private void btn200IndividualMedley_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();      // go to form26 to view the datagrid of event 200 Individual Medley
            f26.Show();         // show that form
            this.Hide();        // hide this form when go to form 26
        }



        // go to form 27

        private void btn1MeterDriving_Click(object sender, EventArgs e)
        {
            Form27 f27 = new Form27();      // go to form27 to view the datagrid of event 1 Meter Driving
            f27.Show();         // show that form
            this.Hide();        // hide this form when go to form 27
        }




        // go to form 28

        private void btn200FreestyleRelay_Click(object sender, EventArgs e)
        {
            Form28 f28 = new Form28();      // go to form28 to view the datagrid of event 200 Freestyle Relay
            f28.Show();         // show that form
            this.Hide();        // hide this form when go to form 28
        }




        // go to form 29

        private void btn400FreestyleRelay_Click(object sender, EventArgs e)
        {
            Form29 f29 = new Form29();      // go to form29 to view the datagrid of event 400 Freestyle Relay
            f29.Show();         // show that form
            this.Hide();        // hide this form when go to form 29
        }




        // go to form 30

        private void btn200MedleyRelay_Click(object sender, EventArgs e)
        {
            Form30 f30 = new Form30();      // go to form 30 to view the datagrid of event 200 Medley Relay
            f30.Show();         // show that form
            this.Hide();        // hide this form when go to form 30
        }



        // go to back form

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();     // give to get report form
            f12.Show();                 // show that form
            this.Close();               // when go to "get report" form close this form
        }



    }
}
