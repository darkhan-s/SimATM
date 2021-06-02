using System;
using System.Windows.Forms;

namespace SimATM
{
    //main program
    static class Program
    {

        public const int ACCOUNT_NO = 3;
        public static Account[] acc = new Account[ACCOUNT_NO];
        public static bool isDataRace = true;
        /*Sets up example ATM example accounts*/
        public static void initializeAccounts()
        {
            acc[0] = new Account(300, 1111, 111111);
            acc[1] = new Account(750, 2222, 222222);
            acc[2] = new Account(3000, 3333, 333333);
        }
        //enabling/disabling the data race simulation
        public static void changeDataRace()
        {
            if (isDataRace == true)
            {
                isDataRace = false;
            }
            else
            {
                isDataRace = true;
            }
        }

        //acquiring the data race state
        public static bool getIsDataRace()
        {
            return isDataRace;
        }

        //this is required for multithreading 
        [STAThread]

        //initializing the program
        static void Main()
        {
            initializeAccounts();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CentralComputer());
        }
    }
}
