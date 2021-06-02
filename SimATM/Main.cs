using System.Windows.Forms;
using System;

namespace SimATM
{
    static class Details
    {

        public const int accNum = 3;
        public static Account[] ac = new Account[accNum];

        // Sets starting status for data race to ON

        public static bool statusDR = true;

        [STAThread]

        // launching the central bank form
        static void Main()
        {
            declareAcc();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ComCen());
        }

        // Declares given account details
        public static void declareAcc()
        {
            ac[0] = new Account(300, 1111, 111111);
            ac[1] = new Account(750, 2222, 222222);
            ac[2] = new Account(3000, 3333, 333333);
        }

        // Sets state of data race (ON or OFF)

        public static void statusSwitchDR()
        {
            if (statusDR == true)
            {
                statusDR = false;
            }
            else
            {
                statusDR = true;
            }
        }
        //
        // Return data race status (ON or OFF)

        public static bool recStatusDR()
        {
            return statusDR;
        }

    }
}
