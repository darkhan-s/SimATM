using System.Threading;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace SimATM
{
    
    public partial class ComCen : Form
    {
        
        //the central bank system is being initialized
        public ComCen()
        {
            InitializeComponent();
            
        }

        // Set starting status for the Data Race indicator

        private void setupComCen(object sender, EventArgs e)
        {
            // Data Race is on upon running the program
            VisualDRStatus.ForeColor = Color.DarkGreen;
            VisualDRStatus.BackColor = Color.DarkGreen;
            VisualDRStatus.Text = "----";
        }

        //setting the indicators and event for the data race
        private void toggleButton_Click(object sender, EventArgs e)
        {
            if (Details.recStatusDR() == true)
            {
                // Toggle the Data Race off
                Details.statusSwitchDR();
                VisualDRStatus.ForeColor = Color.Maroon;
                VisualDRStatus.BackColor = Color.Maroon;
                VisualDRStatus.Text = "----";
            }
            else
            {
                // Toggle the Data Race on
                Details.statusSwitchDR();
                VisualDRStatus.ForeColor = Color.DarkGreen;
                VisualDRStatus.BackColor = Color.DarkGreen;
                VisualDRStatus.Text = "----";
            }
        }

        // Opens a single ATM sim for the user - Can be clicked mutliple times to produce more ATM's
        //upon every click a new thread is opened
        private void createButton_Click(object sender, EventArgs e)
        {
           
            Thread myThread = new Thread(simRun);
            myThread.Start();
           
        }
        //this opens the atm window
        public void simRun()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.Run(new userSim());
        }


}
}
