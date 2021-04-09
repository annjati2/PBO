using System;

namespace art_app
{
    public class function
    {
        public static bool Menu( ref int token)
        {
            Console.WriteLine($"Do you want to make a request or download a free art? (You have another {token} token for this account. ) ");
            Console.WriteLine("[1] Make a request");
            Console.WriteLine("[2] Download a free art");
            Console.WriteLine("[3] Quit app");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    makerequest();
                    return true;
                case "2":
                    Console.WriteLine("Do you really want to download a free art? One token will be spend. (yes/no)");
                    answer = Console.ReadLine();
                    if ((token > 0) && (answer == "yes"))
                    {
                        request.freedownload(ref token);
                        Console.WriteLine("One token used");
                    }
                    else if (token == 0)
                    {
                        Console.WriteLine("You don't have any token left");
                    }
                    return true;
                case "3":
                    Console.WriteLine("Thank you");
                    return false;
                default :
                    Console.WriteLine("Thank you");
                    return false;
            }
        }

        public static void makerequest()
        {
            Console.WriteLine("Input the star of illustrator that you want to make a commission with (1 - 10) : ");
            int mastery = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("How many art will you request?");
            int count = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("Do you want to request a VIP commission? (1 - 3)" );
            Console.WriteLine("[1] Gold" );
            Console.WriteLine("[1] Silver" );
            Console.WriteLine("[1] Bronze" );
            string vip = Console.ReadLine();
            request member = new request(mastery , count , vip);
            member.ShowRequestInformation();
        }

        
    }
}