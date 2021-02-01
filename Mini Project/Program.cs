using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    class Program
    {
        void PrintMenu()
        {
            ComplaintManagement complaintManagement = new ComplaintManagement();
            int Choice = 0;
            do
            {
                Console.WriteLine("1. Find the Complaints based on the year.");
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("2. Find the Complaint based on the name.");
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("3. Find the Complaint based on ID");
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("4. Get the number of days taken by bank to cose the complaint");
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("5. Get all the complaint Closed or Closed With Explanation");
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("6. Find all the Complaint which recieve timely response");
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("7. Enter Data to Input New Compalint");
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("8. Exit from the application");

                Console.WriteLine("_________________________________________________");

                Console.WriteLine("Enter the choice you want to peform");
                while (!int.TryParse(Console.ReadLine(), out Choice) || Choice > 9)
                {
                    Console.WriteLine("Invald entry please try again...");
                }

                switch (Choice)
                {
                    case 1:
                        complaintManagement.PrintAllComplaintsOfaGivenYear();
                        break;

                    case 2:
                        complaintManagement.PrintAllComplaintsOfaGivenName();
                        break;

                    case 3:
                        complaintManagement.PrintComplaintById();
                        break;

                    case 4:
                        complaintManagement.NumberofDaysToCloseComplaint();
                        break;

                    case 5:
                        complaintManagement.PrintComplaintClosedAndClosedWithExplanation();
                        break;

                    case 6:
                        complaintManagement.PrintComplaintRecieveTImelyResponse();
                        break;

                    case 7:
                        complaintManagement.TakeNewComplaint();
                        break;

                    case 8:
                        Console.WriteLine("THANK YOU FOR USING OUR APPLICATION");
                        break;

                    default:
                        Console.WriteLine("INVALID INPUT");
                        break;
                }

            } while (Choice!=8);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("*******************WELCOME TO THE APPLICATION********************");
            program.PrintMenu();
            Console.ReadKey();
        }
    }
}
