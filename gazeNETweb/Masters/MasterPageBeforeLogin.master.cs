using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {
        bool hasParent = (e.Item.Parent != null);



        switch (e.Item.Value)
        {
            case "About":
                Response.Redirect("~/Common/AboutPage.aspx");
                break;
            case "Home":
                Response.Redirect("~/Common/HomePageBeforeLog.aspx");
                break;
            case "Login":
                Response.Redirect("~/Account/Login.aspx");
                break;
            case "Sign Up":
                Response.Redirect("~/Account/SignUp.aspx");
                break;
            case "Galery":
                Response.Redirect("~/Common/GaleryPage.aspx");
                break;
            case "Contact Us":
                Response.Redirect("~/Common/ContactPage.aspx");
                break;


        }

    }
}
