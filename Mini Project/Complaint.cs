using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    class Complaint
    {
        public Complaint()
        {
        }

        public Complaint(string date_received, string product, string sub_product, string issue, string sub_issue, string company, string state, string zIP_code, string submitted_via, string date_sent_to_company, string company_response_to_consumer, string timely_response, string consumer_disputed, string complaint_ID) :this()
        {
            Date_received = date_received;
            Product = product;
            Sub_product = sub_product;
            Issue = issue;
            Sub_issue = sub_issue;
            Company = company;
            State = state;
            ZIP_code = zIP_code;
            Submitted_via = submitted_via;
            Date_sent_to_company = date_sent_to_company;
            Company_response_to_consumer = company_response_to_consumer;
            Timely_response = timely_response;
            Consumer_disputed = consumer_disputed;
            Complaint_ID = complaint_ID;
        }

        public string Date_received { get; set; }
        public string Product { get; set; }
        public string Sub_product { get; set; }
        public string Issue { get; set; }
        public string Sub_issue { get; set; }
        public string Company { get; set; }
        public string State { get; set; }
        public string ZIP_code { get; set; }
        public string Submitted_via { get; set; }
        public string Date_sent_to_company { get; set; }
        public string Company_response_to_consumer { get; set; }
        public string Timely_response { get; set; }
        public string Consumer_disputed { get; set; }
        public string Complaint_ID { get; set; }

        public override string ToString()
        {
            return "Date_received: "+ Date_received+"\n"+
                   "Product: " + Product+ "\n" +
                   "Sub_product: " + Sub_product + "\n" +
                   "Issue: " + Issue + "\n" +
                   "Sub_issue: " + Sub_issue + "\n" +
                   "Company: " + Company + "\n" +
                   "State: " + State + "\n" +
                   "ZIP_code: " + ZIP_code + "\n" +
                   "Submitted_via: " + Submitted_via + "\n" +
                   "Date_sent_to_company: " + Date_sent_to_company + "\n" +
                   "Company_response_to_consumer: " + Company_response_to_consumer + "\n" +
                   "Timely_response: " + Timely_response + "\n" +
                   "Consumer_disputed: " + Consumer_disputed + "\n" +
                   "Complaint_ID: " + Complaint_ID + "\n" ;
        }

        public static Complaint FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Complaint complaint = new Complaint();

            //string[] date = values[0].Split('/');
            //int year = Convert.ToInt32(date[2]);
            //int day = Convert.ToInt32(date[1]);
            //int month = Convert.ToInt32(date[0]);
            //complaint.Date_received = new DateTime(year, month, day);

            complaint.Date_received = values[0];
            complaint.Product = values[1];
            complaint.Sub_product = values[2];
            complaint.Issue = values[3];
            complaint.Sub_issue = values[4];
            complaint.Company = values[5];
            complaint.State = values[6];
            complaint.ZIP_code = values[7]; 
            complaint.Submitted_via = values[8];

            //int year_to_company, day_to_comapny, month_to_company;
            //if (values[9] == "")
            //{
            //    year_to_company = 0;
            //    day_to_comapny = 0;
            //    month_to_company = 0;
            //}
            //else
            //{
            //    string[] date_to_company = values[9].Split('/');
            //    year_to_company = Convert.ToInt32(date_to_company[2]);
            //    day_to_comapny = Convert.ToInt32(date_to_company[1]);
            //    month_to_company = Convert.ToInt32(date_to_company[0]);
            //    complaint.Date_sent_to_company = new DateTime(year_to_company, month_to_company, day_to_comapny);
            //}


            complaint.Date_sent_to_company = values[9];
            complaint.Company_response_to_consumer = values[10];
            complaint.Timely_response = values[11];
            complaint.Consumer_disputed = values[12];
            complaint.Complaint_ID = values[13];

            return complaint;
        }

    }
}
