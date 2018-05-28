using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Account_Question_Count : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void q_count_TextChanged(object sender, EventArgs e)
    {
        Experiment experiment = Experiment.Instance;
        experiment.Q_count = Int32.Parse(q_count.Text);
        
        String returnURL;
      
            returnURL = "~/Account/Select_Types.aspx";

            Response.Redirect(returnURL);

        
    }
}