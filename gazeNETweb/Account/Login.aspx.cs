using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LoginBtn(object sender, EventArgs e)
    {
        Database connectionObject = new Database();
        bool result = connectionObject.userExists(Convert.ToInt64(ID.Text));
        if (result != false)
        {
            if (password.Text.Equals(connectionObject.getUserPassword(Convert.ToInt64(ID.Text))))
            {



                String returnUrl;
                // the login is successful
                if (Request.QueryString["ReturnUrl"] == null)
                {
                    returnUrl = "~/Account/ManagePage.aspx";
                    FormsAuthentication.SetAuthCookie(connectionObject.getUserName(Convert.ToInt64(ID.Text)), true);
                    FormsAuthentication.RedirectFromLoginPage(connectionObject.getUserName(Convert.ToInt64(ID.Text)), false);
                    Current_User current_User = Current_User.Instance;
                    current_User.User_id = Convert.ToInt64(ID.Text);
                    Response.Redirect(returnUrl);

                }
            }
        }
    }
    protected void ForgetPasswordBtn(object sender, EventArgs e)
    {
        String returnURL;
        if (Request.QueryString["ReturnUrl"] == null)
        {
            returnURL = "~/Common/Home.aspx";

            Response.Redirect(returnURL);

        }
    }
}