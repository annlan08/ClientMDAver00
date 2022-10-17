using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ClientMDA.Models
{
    public class SMTPModel
    {

        public void sendmail(List<string> MailList, string Subject, string Body)
        {
            MailMessage msg = new MailMessage();
            msg.To.Add(string.Join(",", MailList.ToArray()));
            msg.From = new MailAddress("annlan08@gmail.com", "測試郵件", System.Text.Encoding.UTF8);//郵件標題 
            msg.Subject = Subject;                                                                  //郵件標題編碼  
            msg.SubjectEncoding = System.Text.Encoding.UTF8;                                        //郵件內容
            msg.Body = Body;
            msg.IsBodyHtml = true;
            msg.BodyEncoding = System.Text.Encoding.UTF8;//郵件內容編碼 
            msg.Priority = MailPriority.Normal;//郵件優先級 
                                               //建立 SmtpClient 物件 並設定 Gmail的smtp主機及Port 
            #region //其它 Host
            /*
             *  outlook.com smtp.live.com port:25
             *  yahoo smtp.mail.yahoo.com.tw port:465
            */
            #endregion

            SmtpClient MySmtp = new SmtpClient("smtp.gmail.com", 587);           //設定你的帳號密碼
            MySmtp.Credentials = new System.Net.NetworkCredential("annlan08@gmail.com", "ssbb19970513");
            MySmtp.EnableSsl = true;
            MySmtp.Send(msg);
        }
    }
}
