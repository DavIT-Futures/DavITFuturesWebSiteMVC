using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace davIT.Models
{
    public class EmailMessage
    {
        private string recipient = @"dawit@interia.pl";
        public string Sender { get; set; }
        public string Message { get; set; }
        public string PhoneNumber { get; set; }
        public HttpRequestBase Request { get; set; }

        public EmailMessage()
        {

        }

        public EmailMessage(string sender, string message, string phoneNumber, HttpRequestBase request)
        {
            this.Message = message;
            this.Sender = sender;
            this.PhoneNumber = phoneNumber;
            this.Request = request;
        }

        internal static void Send(object obj)
        {
            EmailMessage emailMsg = obj as EmailMessage;
            if (emailMsg != null && !string.IsNullOrEmpty(emailMsg.Message))
            {
                MailMessage m = new MailMessage();
                SmtpClient sc = new SmtpClient();
                m.From = new MailAddress(emailMsg.recipient, "DavIT Form");
                m.To.Add(new MailAddress(emailMsg.recipient, "DavIT Form"));

                m.Subject = string.Format("Wiadomosc ze strony, email: {0}, tel. nr: {1}, IP: {2}", emailMsg.Sender, emailMsg.PhoneNumber, GetVisitorIpAddress(emailMsg.Request));
                m.Body = string.Format("Treść: {0},{1}Email: {2},{3}Tel: {4},{5}IP: {6}", emailMsg.Message, Environment.NewLine, emailMsg.Sender, Environment.NewLine, emailMsg.PhoneNumber, Environment.NewLine, GetVisitorIpAddress(emailMsg.Request));
                sc.Host = "poczta.interia.pl";
                sc.Port = 587;
                sc.Credentials = new System.Net.NetworkCredential("dawit@interia.pl", "Interia_99");
                sc.EnableSsl = true;
                sc.Send(m);
            }
        }

        private static string GetVisitorIpAddress(HttpRequestBase Req)
        {
            try
            {
                string stringIpAddress = null;
                stringIpAddress = Req.ServerVariables["HTTP_X_FORWARDED_FOR"];
                if (stringIpAddress == null) //may be the HTTP_X_FORWARDED_FOR is null
                {
                    stringIpAddress = Req.ServerVariables["REMOTE_ADDR"];
                }
                return stringIpAddress;
            }
            catch
            {
                return "exception";
            }
        }
    }
}