using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage2 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Current_User current_User = Current_User.Instance;
        Database db = new Database();
     
            userlabel.Text = "Welcome ,"+db.getUserName(current_User.User_id).ToUpper();
       

    }
    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {
        bool hasParent = (e.Item.Parent != null);

      
              
                        switch (e.Item.Value)
                        {
                            case "Manage":
                                Response.Redirect("~/Account/ManagePage.aspx");
                                break;
                            case "Home":
                                Response.Redirect("~/Common/HomePageAfterLog.aspx");
                                break;
                            case "Galery":
                                Response.Redirect("~/Common/GaleryPageAfterLog.aspx");
                                 break;
                            case "Contact Us":
                                Response.Redirect("~/Common/ContactPageAfterLog.aspx");
                                 break;
                            case "Log out":
                                Response.Redirect("~/Account/Login.aspx");
                                 break;
                            case "Survey":
                                Response.Redirect("~/SurveyPage.aspx");
                                 break;
                            case "About":
                                Response.Redirect("~/Common/AboutPageAfterLog.aspx");
                                 break;

        }
        
    }
}
