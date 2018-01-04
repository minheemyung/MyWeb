using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

namespace Sample
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
               // TabName.Value = Request.Form[TabName.UniqueID];
            }
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

    }
}