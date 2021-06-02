using System.Windows.Forms;
using System;
using System.Drawing;

namespace SimATM
{
    public partial class userSim : Form
    {
        //initializing the components of the atm
        public userSim()
        {
            InitializeComponent();
        }
        private void setupUI(object sender, EventArgs e)
        {
            //all the screens and labels are being cleared out from the possible leftover
            setupSIM();
            setupDisplay();
            caseChange();
        }

        // Declare all constants and variables

        public const int sizeButton = 45;
        public const int numButton = 3;
        public const int sizeATM = 390;
        //these are used during the withdrawals
        public const int extractOne = 10;
        public const int extractTwo = 20;
        public const int extractThree = 40;
        public const int extractFour = 100;
        public const int extractFive = 500;

        public const int lengthP = 4;
        public const int lengthA = 6;

        private int setRecord; 
        private string setCase = "numAcc";
        //this variable is used to get the current balance to compare with the withdrawal amount
        private int a = 0;
        Button[] userInput = new Button[(numButton * numButton) + 1];

        // creating an array(keypad) for user's inputs
        public void setupSIM()
        {
            int num = 1;    
            int yCoordinates = sizeATM / 2 - ((numButton * sizeButton) /2) + sizeButton / 2;  
            int xCoordinates = sizeATM / 2 - ((numButton * sizeButton) /2) - sizeButton / 2;       

            for (int x = 0; x < numButton; x++)
            {
                for(int z = 0; z < numButton; z++)
                {
                    userInput[num] = new Button();

                    userInput[num].BackColor = Color.LightGray;
                    userInput[num].Text = Convert.ToString(num);
                    userInput[num].SetBounds(xCoordinates + (sizeButton * z), yCoordinates + (sizeButton * x), sizeButton, sizeButton);

                    userInput[num].Click += new EventHandler(this.setButton_Click);
                    Controls.Add(userInput[num]);
                    num++;
                }
            }
            //setting the parameters of the keypad buttons
            userInput[0] = new Button();
            userInput[0].Text = "0"; // Display "0"
            userInput[0].BackColor = Color.LightGray; // Set back colour of key
            userInput[0].SetBounds(xCoordinates + sizeButton, yCoordinates + (sizeButton * numButton), sizeButton, sizeButton); // Set location of key
            Controls.Add(userInput[0]);
        }

        // Empty current case

        public void caseEmpty()
        {
            userDisplay.Text = "";
            comDisplay.Text = "";
            LHLabel.Text = "";
            LMLabel.Text = "";
            LLLabel.Text = "";
            RHLabel.Text = "";
            RMLabel.Text = "";
            RLLabel.Text = "";
        }

        // Set different cases for the ATM to display to the user

        public void caseChange()
        {
            //these set the initial appearence of the different scenarios 
            //Account number window, pin window, withdrawal etc..
            if (setCase == "numAcc")
            {
                comDisplay.Text = "Account Number: ";
            }
            else if(setCase == "numPin")
            {
                comDisplay.Text = "Pin Number: ";
            }
            else if(setCase == "home")
            {
                LHLabel.Text = "Balance";
                LLLabel.Text = "Withdraw";
                comDisplay.Visible = false;
                userDisplay.Visible = false; 
                RLLabel.Text = "Exit";
            }
            else if (setCase == "removeFunds")
            {
                LHLabel.Text = "£" + extractOne;
                LMLabel.Text = "£" + extractTwo;
                LLLabel.Text = "£" + extractThree;
                RHLabel.Text = "£" + extractFour;
                RMLabel.Text = "£" + extractFive;
                comDisplay.Visible = false;
                userDisplay.Visible = false;
                RLLabel.Text = "Return";
            }
            else if(setCase == "accBal")
            {
                comDisplay.Text = "Account Balance is: £" + Details.ac[setRecord].getBalance(); // Gets and sends the account balance to the display
                comDisplay.Visible = true;
                RLLabel.Text = "Return";
            }
        }

        //initialization of the client
        public void setupDisplay()
        {
            this.ClientSize = new Size(sizeATM, sizeATM);

        }

        private void setButton_Click(object sender, EventArgs e)
        {
            Button t = sender as Button;
            if (setCase == "numAcc")
            {
                if (userDisplay.Text.Length < lengthA) // User input is limited to account number length limit
                {
                    userDisplay.Text = userDisplay.Text + t.Text; // Displays user input on the display
                }
            }
            else if (setCase == "numPin")
            {
                if (userDisplay.Text.Length < lengthP) // User input is limited to pin number length limit
                {
                    userDisplay.Text = userDisplay.Text + t.Text;
                }
            }

        }

        //Record button to confirm data inputted by the user
        private int n = 0;
        private void recordButton_Click(object sender, EventArgs e)
        {
            bool statusAcc = false;
            int userIn = 0;

            if (userDisplay.Text != "")
            {
                userIn = Convert.ToInt32(userDisplay.Text);
            }
 
            if(setCase == "numAcc") // Confirm the input for the users account numbers
            {
                for (int z = 0; z < Details.accNum; z++)
                {
                    if (Details.ac[z].getAccountNum() == userIn)
                    {
                        setCase = "numPin";
                        setRecord = z;
                        statusAcc = true;

                        caseEmpty();
                        caseChange();
                    }
                    else if(statusAcc == false) //there is no need to lock the account for giving the wrong data about the account number
                    {
                        caseEmpty();
                        comDisplay.Text = "Incorrect account details,try again: ";
                    }
                }
            }
            else if(setCase == "numPin") // Confirm the input for the users pin
            {
                if(Details.ac[setRecord].checkPin(userIn))
                {
                    setCase = "home";
                    caseEmpty();
                    caseChange();
                }
                else
                {
                    //in case if the wrong PIN is used more than three times, the program notifies the system
                    caseEmpty();
                    comDisplay.Text = "Incorrect Pin,  "+ (n+1) + "  attempts";
                    if (n >= 2)
                    {
                        comDisplay.Text = "Account has been locked ";
                        MessageBox.Show("The account has been locked due to incorrect attempts(3). Please contact your bank", "Locked");
                        n = 0;
                        
                    }
                    n++;
                }
            }
        }

        //Empty button to remove all text on the user display

        private void emptyButton_Click(object sender, EventArgs e)
        {
            userDisplay.Text = "";
        }

        //Close button to close down the current running simulation

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current simulation
        }

        private void userCollect(int withdrawl)
        {
            if (!Details.ac[setRecord].decrementBalance(withdrawl))
            {
                caseEmpty();

            }
        }

        //Buttons below are used in the display UI - Withdraw funds, go back to the home page and check the users balance
        private static readonly object locker = new object();
        // Check balance and remove funds (£10)
        // LH-left higher, LM-Left middle etc.
        private void LHButton_Click(object sender, EventArgs e)
        {
            a = Details.ac[setRecord].getBalance(); // the balance is acquired from the system database
            if (setCase == "home") // If on home page display current option
            {
                setCase = "accBal";
                caseEmpty();
                caseChange(); 
            }
            // the balance is compared with the withdrawal value
            else if ((setCase == "removeFunds") && a >= extractOne)
            {

                //the lock is used for limiting the threads during the critical points
                lock (locker)
                {
                    Details.ac[setRecord].decrementBalance(extractOne); // Reduce the current accounts funds
                    MessageBox.Show(this, "Please, collect your money", "Reminder");
                }
            }
            //if it is not enough money on the card it notifies straight away, no delays
            else if ((setCase == "removeFunds") && a < extractOne)
            {
                MessageBox.Show(this, "Insufficient funds...","Reminder");
            }
        }


        // Remove funds (£20), same as the first one

        private void LMButton_Click(object sender, EventArgs e)
        {
            a = Details.ac[setRecord].getBalance();
            if ((setCase == "removeFunds") && (a >= extractTwo) && setCase!="home")
            {
                lock (locker)
                {
                    Details.ac[setRecord].decrementBalance(extractTwo); // Reduce the current accounts funds
                    MessageBox.Show(this, "Please, collect your money", "Reminder");
                }
            }
            else if ((setCase == "removeFunds") && (a < extractTwo) && setCase != "home")
            {
                MessageBox.Show(this, "Insufficient funds...", "Reminder");
            }
        }

        // Allow users to check withdrawel options and remove funds (£40), same as the first one

        private void LLButton_Click(object sender, EventArgs e)
        {
            a = Details.ac[setRecord].getBalance();
            if (setCase == "home")
            {
                setCase = "removeFunds";
                caseEmpty();
                caseChange();
            }
            else if ((setCase == "removeFunds") && a >= extractThree)
            {
                lock (locker)
                {
                    Details.ac[setRecord].decrementBalance(extractThree); // Reduce the current accounts funds
                    MessageBox.Show(this, "Please, collect your money", "Reminder");
                }
            }
            else if ((setCase == "removeFunds") && a < extractThree)
            {
                MessageBox.Show(this, "Insufficient funds...", "Reminder");
            }
        }

        // Remove funds (£50), same as the first one

        private void RHButton_Click(object sender, EventArgs e)
        {
            a = Details.ac[setRecord].getBalance();
            if ((setCase == "removeFunds") && a >= extractFour)
            {
                lock (locker)
                {
                    Details.ac[setRecord].decrementBalance(extractFour); // Reduce the current accounts funds
                    MessageBox.Show(this, "Please, collect your money", "Reminder");
                }
            }
            else if ((setCase == "removeFunds") && (a < extractFour) && setCase != "home")
            {
                MessageBox.Show(this, "Insufficient funds...", "Reminder");
            }
        }

        // Remove funds (£100), same as the first one

        private void RMButton_Click(object sender, EventArgs e)
        {
            a = Details.ac[setRecord].getBalance();
            if ((setCase == "removeFunds") && a>= extractFive && setCase != "home")
            {
                lock (locker)
                {
                    Details.ac[setRecord].decrementBalance(extractFive); // Reduce the current accounts funds
                    MessageBox.Show(this, "Please, collect your money", "Reminder");
                }
            }
            else if ((setCase == "removeFunds") && a < extractFive && setCase != "home")
            {
                MessageBox.Show(this, "Insufficient funds...", "Reminder");
            }
        }

        // Allows the user to go back to the homepage and remove funds (£500), same as the first one
        private void RLButton_Click(object sender, EventArgs e)
        {
            if (setCase == "home")
            {
                this.Close(); // Close the current simulation
            }
            else if (setCase == "accBal" || setCase == "removeFunds") // If user is on the balance page or withdraw page display this to the user
            {
                setCase = "home";
                caseEmpty();
                caseChange();

            }

        }

    }
}
