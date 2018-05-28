using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Select_Types : System.Web.UI.Page
{
    private int q_count = Experiment.Instance.Q_count;

    protected void Page_Load(object sender, EventArgs e)
    {
        Panel pnlDropDownList = new Panel();
        pnlDropDownList.ID = "pnlDropDownList";


        Label t_Label = new Label();
        t_Label.Text = "Please select question type for each question..";
        Form.Controls.AddAt(5,pnlDropDownList);
        pnlDropDownList.Controls.Add(t_Label);
        pnlDropDownList.Controls.Add(new LiteralControl("<br />"));
        pnlDropDownList.Controls.Add(new LiteralControl("<br />"));
        

        int cnt = 1;

       
        for (int i = 0; i < q_count; i++)
        {
         
            DropDownList ddl = new DropDownList();

            Label label = new Label();

            ddl.ID = "ddlDynamic-" + Convert.ToString(cnt + i);
            label.ID = "lblDynamic-"+ Convert.ToString(cnt + i);
            label.Text = Convert.ToString(cnt+i)+".     ";
            ddl.Items.Add(new ListItem("--Select--", ""));

            ddl.Items.Add(new ListItem("Visual", "1"));

            ddl.Items.Add(new ListItem("Yes/No", "2"));


            ddl.AutoPostBack = true;

            if (i == q_count - 1)
            {
                ddl.SelectedIndexChanged += new EventHandler(OnLastSelectedIndexChanged);


            }
            else
            {
                ddl.SelectedIndexChanged += new EventHandler(OnSelectedIndexChanged);
            }

            pnlDropDownList.Controls.Add(label);
            pnlDropDownList.Controls.Add(ddl);



            pnlDropDownList.Controls.Add(new LiteralControl("<br />"));
            pnlDropDownList.Controls.Add(new LiteralControl("<br />"));

             


        }


    }

    private void OnLastSelectedIndexChanged(object sender, EventArgs e)
    {
        Question q = new Question();

        DropDownList dropDownList = (DropDownList)sender;
        q.Question_type = dropDownList.SelectedItem.Text;
        q.createQuestion(dropDownList.SelectedItem.Text);
        Experiment.Instance.Questions.Add(q);

        String returnURL;
        if (Request.QueryString["ReturnUrl"] == null)
        {
            returnURL = "~/Account/Survey.aspx";

            Response.Redirect(returnURL);

        }
    }

   

    private void OnSelectedIndexChanged(object sender, EventArgs e)
    {
        Question q = new Question();

        DropDownList dropDownList = (DropDownList)sender;
        q.Question_type = dropDownList.SelectedItem.Text;
        q.createQuestion(dropDownList.SelectedItem.Text);
        Experiment.Instance.Questions.Add(q);

    }
}