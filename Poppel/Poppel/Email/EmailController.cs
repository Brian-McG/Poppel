using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Poppel.Email
{
    class EmailController
    {
        /*
        public void testEmail()
        {
            Customer test = new Customer();
            test.Email = "mcgbri004@myuct.ac.za";
            test.Name = "Brian Mc George";
            test.Phone = "-";
            test.ID = "123";
            string message = "Dear " + test.Name + "\nOrder summary for order on <x>:\n\n" + "6 x Coke - R 123\n2 x Fanta 6 Pack - R77\n5 x Pack of 100 Jelly Tots - R44\n-------------------------------\nTotal: x\n\n Delivery Details:\nAddress:\n4 Test Road\nDurbanville\nCape Town\n7550";
            sendEmail(test, "Order Summary", message);
        }

        public void sendEmail(Customer cust, string header, string sendMessage)
        {
            if (cust.Name != null)
            {
                var fromAddress = new MailAddress("noreply.poppel@gmail.com", "Poppel");
                var toAddress = new MailAddress(cust.Email, cust.Name);
                string fromPassword = "poppel2014";
                string subject = header;
                string body = sendMessage;

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                    Timeout = 20000
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = header,
                    Body = sendMessage
                })

                    smtp.Send(message);
            }
        }
         */
    }
}

