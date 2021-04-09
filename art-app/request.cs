using System;

namespace art_app
{
    public class request
    {
        public int mastery { get; set; }
        public double vipupgrade { get; set; }
        public int duration { get; set; }
        public int count { get; set; }
        public double fee { get; set; }

        public request( int mastery , int count , string vip)
        {
            this.mastery = mastery;
            if (vip=="gold") {
                this.vipupgrade = 2;
                this.duration = 1;
            } else if (vip=="silver"){
                this.vipupgrade = 1.5;
                this.duration = 2;
            } else {
                this.vipupgrade = 1;
                this.duration = 3;
            }

        }
        public static void freedownload(ref int token)
        {
            token = token - 1;
        }

        private double calculate_fee()
        {
            double fee = (mastery * 10000 + 25000) * vipupgrade;
            return fee;
        }

        public void ShowRequestInformation()
        {
            fee = calculate_fee();
            Console.WriteLine("Please pay {0} to proceed", fee);
            Console.WriteLine("Thanks for buying");
        }
    }

}
