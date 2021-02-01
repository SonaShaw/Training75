using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MiniProject
{
    class ComplaintManagement
    {
        List<Complaint> complaints = new List<Complaint>();
        Complaint complaint = new Complaint();
     

        public ComplaintManagement()
        {
            complaints = System.IO.File.ReadAllLines(@"C:\Users\user\Desktop\My Trainig Work\MiniProjectSolution\complaints.csv")
                                           .Skip(1)
                                           .Select(c => Complaint.FromCsv(c))
                                           .ToList();

        }

       
        public void PrintAllComplaintsOfaGivenYear()
        {
            try
            {
                Console.WriteLine("Enter the year");
                string year = Console.ReadLine();
                var year_wise_complaint = complaints.Where(c => c.Date_received.Substring(c.Date_received.LastIndexOf("/") + 1) == year);
                foreach (var item in year_wise_complaint)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("****************************");
                Console.WriteLine(e.StackTrace);
            }
        }


        public void PrintAllComplaintsOfaGivenName()
        {
            try
            {
                Console.WriteLine("Enter the Name");
                string name = Console.ReadLine();

                var name_wise_complaint = complaints.Where(c => c.Company == name);

                foreach (var item in name_wise_complaint)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("****************************");
                Console.WriteLine(e.StackTrace);
            }
        }


        public void PrintComplaintById()
        {
            try
            {
                Console.WriteLine("Enter the id for viewing the Complaint");
                int id;
                while (!int.TryParse(Console.ReadLine(), out id) || id < 0)
                {
                    Console.WriteLine("Invald entry please try again...");
                }
                string sid = id.ToString();

                Complaint complain_by_id = complaints.Find(c => c.Complaint_ID == sid);
                if (complain_by_id != null)
                    Console.WriteLine(complain_by_id);
                else
                    Console.WriteLine("NO COMPLAINT FOUND");
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void NumberofDaysToCloseComplaint()
        {
            try
            {
                Console.WriteLine("Enter the id for which you want data");
                string id = Console.ReadLine();

                Complaint complaint = complaints.Where(c => c.Complaint_ID == id).First();
                if (complaint != null)
                {
                    string date_recieved = complaint.Date_received;
                    int year = Convert.ToInt32(date_recieved.Substring(6, 4));
                    int month = Convert.ToInt32(date_recieved.Substring(3, 2));
                    int day = Convert.ToInt32(date_recieved.Substring(0, 2));

                    DateTime date_recieved_local = new DateTime(year, month, day);

                    string date_recieved_to_company = complaint.Date_sent_to_company;
                    int year_to_company = Convert.ToInt32(date_recieved.Substring(6, 4));
                    int month_to_company = Convert.ToInt32(date_recieved.Substring(3, 2));
                    int day_to_company = Convert.ToInt32(date_recieved.Substring(0, 2));

                    DateTime date_recieved_to_comapny_local = new DateTime(year, month, day);

                    System.TimeSpan diff = date_recieved_to_comapny_local.Subtract(date_recieved_local);
                    Console.WriteLine("the diffrence in date is " + diff);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("****************************");
                Console.WriteLine(e.StackTrace);
            }
        }


        public void PrintComplaintClosedAndClosedWithExplanation()
        {
            try
            {
                var allcomplaints = complaints.GroupBy(c => c.Company_response_to_consumer);
                foreach (var all_item in allcomplaints)
                {
                    Console.WriteLine("ALL COMPLAINTS WITH CLOSED ARE" + all_item.Key);
                    foreach (var item in all_item)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("**********************************************");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("****************************");
                Console.WriteLine(e.StackTrace);
            }
        }


        public void PrintComplaintRecieveTImelyResponse()
        {
            try
            {
                var get_timely_response = complaints.Where(c => c.Timely_response == "Yes");
                foreach (var item in get_timely_response)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("****************************");
                Console.WriteLine(e.StackTrace);
            }
        }


        public void TakeNewComplaint()
        {
            Console.WriteLine("Enter the Date Recieved");

        }

        
    }
}
