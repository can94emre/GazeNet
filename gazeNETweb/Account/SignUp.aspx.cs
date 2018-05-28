using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SignUp : System.Web.UI.Page
{
    private Database db;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
   protected void SignUpBtn(object sender, EventArgs e)
    {
        db = new Database();
        long user_id = long.Parse(ID.Text.ToString());
        String user_name = name.Text.ToString();
        String user_birthday = birthday.Text.ToString();
        String user_job = job.Text.ToString();
        String user_password = password.Text.ToString();
        String user_confirmpassword = confirmpassword.Text.ToString();
        String user_gender = gender.Text.ToString();
        String user_email = usermail.Text.ToString();
        String user_ip = null;

        var host = Dns.GetHostEntry(Dns.GetHostName());
        foreach (var ip in host.AddressList)
        {
            if (ip.AddressFamily == AddressFamily.InterNetwork)
            {
               user_ip =  ip.ToString();
            }
        }
        db.InsertParticipant(user_id, user_gender, user_name, user_birthday, user_job, user_email,user_ip,user_password);

        if (user_password.Equals(user_confirmpassword))
        {
            String returnURL;
            if (Request.QueryString["ReturnUrl"] == null)
            {
                returnURL = "~/Account/Login.aspx";

                Response.Redirect(returnURL);

            }
        }
       
    }
}