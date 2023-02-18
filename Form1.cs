namespace Swim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




      // go to form 12 to give details of athlete

        private void add_athlete(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();      // go to add athlete form
            f2.Show();                  // show that form
            this.Hide();              // hide this form when go to add athlete form
        }




        // give form 11 to add result of swim competition

        private void result_click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();        // gp to add result form
            f11.Show();                      // show that form
            this.Hide();                   // hide this form when go to add result form
        }





        // go to form 12 to get report of competiion 

        private void report_click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();            // go to report form
            f12.Show();                       // show that form
            this.Hide();                  // hide this form when go to report form
        }




        // click help button show these messages

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" *** Using this application can add details of athelete." +
                " Don't move from form before save the adding data. So don't back from form at adding details." +
                "Because of then all data will be lost. There fore continue the adding details without the jump back forms. \n \n" +
                "" +
                "*** So can add result of athelete using Admission No, Event, Time. In here after " +
                "adding details you should click button with event name that you want to add result. \n \n" +
                "" +
                "*** clicking the Report button you can get report about Competitors, Events, Places, Coach Details. ");
        }


    }
}