using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ManagePage : System.Web.UI.Page
{
    private Current_User current_User = Current_User.Instance;
    private Database db = new Database();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Account Page.aspx");
    }

    protected void ChangePassword_Click(object sender, EventArgs e)
    {
        if (Password.Equals(db.getUserPassword(current_User.User_id))){
            db.changePassword(current_User.User_id,new_password.Text);
        }
    }
}