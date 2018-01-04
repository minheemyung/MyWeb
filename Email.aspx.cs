using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace Sample
{
    public partial class Email : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void emailSubmit_click(object sender, EventArgs e)
        {
            SendEmail(sender,e);
        }
        protected void SendEmail(object sender, EventArgs e)
        {

            string strBody = "";
            strBody = strBody + "User Name:  " + name.Value + "<br />" + 
                "Date :  " + DateTime.Now + "<br />" + 
                "Machine name:  " + Environment.MachineName + "<br />"   + 
                "Message:  " + comments.Value + "<br />" + "<br />" + "<br />";
            MailMessage mm = new MailMessage();
            mm.From = new MailAddress(emailFrom.Value);
            mm.To.Add(new MailAddress("admin@minheedev.com"));
            //if (chkEmailCC.Checked)
            //{
            //    MailAddress copy = new MailAddress(emailFrom.Value);
            //    mm.CC.Add(copy);
            //}
            mm.Subject = "MinheeDev Visitor Message";
            mm.Body = strBody;
            mm.IsBodyHtml = true;
      
            SmtpClient smtp = new SmtpClient();
            //smtp.Host = "smtpout.secureserver.net"; //smtp.gmail.com, relay-hosting.secureserver.net
            smtp.Host = "relay-hosting.secureserver.net";
            smtp.Port = 25;    // SMTP port no    
           // smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            //smtp.Credentials = new NetworkCredential("minnie.myung1001@gmail.com", "Mmh#%!#!");
            smtp.Credentials = new NetworkCredential("admin@minheedev.com", "Mission3513#");
            //smtp.UseDefaultCredentials = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            try
            {
                smtp.Send(mm);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('The message has been sent successfully.');", true);
                name.Value = string.Empty;
                emailFrom.Value = string.Empty;
                comments.Value = string.Empty;
            }
            catch (System.Net.Mail.SmtpException ex)
            {
               // lblMsg.Text = ex.Message;// ex.ToString();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('The message has not been sent(smtp).');", true);

                //Response.Write("Could not send an email : \n\n\n" + ex.Message);
                // ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('couldn't send an email');", true);

            }
            catch (Exception exe)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('The message has not been sent(exception).');", true);

                //lblMsg.Text = "\n\n\n" + exe.ToString();
            }
            // smtp.Send(mm);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SendEmail(sender, e);
        }

        //protected void SendEmail(object sender, EventArgs e)
        //{

        //    string strBody = "";
        //    strBody = strBody + "User Name:  " + name.Value + "<br />" +
        //        "Date :  " + DateTime.Now + "<br />" +
        //        "Machine name:  " + Environment.MachineName + "<br />" +
        //        "Message:  " + comments.InnerHtml + "<br />" + "<br />" + "<br />";
        //    MailMessage mm = new MailMessage();
        //    mm.From = new MailAddress(emailFrom.Value);
        //    mm.To.Add(new MailAddress("admin@minheedev.com"));
        //    mm.Subject = "MinheeDev Visitor Message";
        //    mm.Body = strBody;
        //    mm.IsBodyHtml = true;

        //    SmtpClient smtp = new SmtpClient();
        //    //smtp.Host = "smtpout.secureserver.net"; //smtp.gmail.com, relay-hosting.secureserver.net
        //    smtp.Host = "relay-hosting.secureserver.net";
        //    smtp.Port = 25;    // SMTP port no    
        //                       // smtp.EnableSsl = true;
        //    smtp.UseDefaultCredentials = false;
        //    //smtp.Credentials = new NetworkCredential("minnie.myung1001@gmail.com", "Mmh#%!#!");
        //    smtp.Credentials = new NetworkCredential("admin@minheedev.com", "Mission3513#");
        //    //smtp.UseDefaultCredentials = true;
        //    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        //    try
        //    {
        //        smtp.Send(mm);
        //        ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('The message has been sent successfully.');", true);
        //    }
        //    catch (System.Net.Mail.SmtpException ex)
        //    {
        //        lblMsg.Text = ex.Message;// ex.ToString();
        //                                 //Response.Write("Could not send an email : \n\n\n" + ex.Message);
        //                                 // ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('couldn't send an email');", true);

        //    }
        //    catch (Exception exe)
        //    {
        //        lblMsg.Text = "\n\n\n" + exe.ToString();
        //    }
        //    // smtp.Send(mm);
        //}

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    SendEmail(sender, e);
        //}
        //protected void SendEmail(object sender, EventArgs e)
        //{




        //    using (MailMessage mm = new MailMessage(txtEmail.Text, emailTo.text))
        //    {
        //        mm.Subject = txtSubject.Text;
        //        mm.Body = comments.InnerText;
        //        //if (fuAttachment.HasFile)
        //        //{
        //        //    string FileName = Path.GetFileName(fuAttachment.PostedFile.FileName);
        //        //    mm.Attachments.Add(new Attachment(fuAttachment.PostedFile.InputStream, FileName));
        //        //}
        //        mm.IsBodyHtml = false;
        //        SmtpClient smtp = new SmtpClient();
        //        smtp.Host = "smtp.gmail.com";
        //        smtp.EnableSsl = true;
        //        NetworkCredential NetworkCred = new NetworkCredential(txtEmail.Text, txtPassword.Text);
        //        smtp.UseDefaultCredentials = true;
        //        smtp.Credentials = NetworkCred;
        //        smtp.Port = 587;
        //        smtp.Send(mm);
        //        ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Email sent.');", true);
        //    }
        //}
    }
}