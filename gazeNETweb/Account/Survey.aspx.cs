using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Windows;
using System.Web.UI.WebControls;
using System.Drawing;


public partial class Account_Survey : Page
{
    private int count;
    private static int index = 0;
    private List<Question> questions = new List<Question>();
    String path;
    protected void Page_Load(object sender, EventArgs e)
    {

        questions = Experiment.Instance.Questions;

        count = Experiment.Instance.Questions.Count;

          List<System.Drawing.Image> options =  questions[index].Image_options;


            path = Server.MapPath("~") + @"\temp\img" + 0 + ".png";
            options[0].Save(path,System.Drawing.Imaging.ImageFormat.Png);
        
    


        if (index != count) { 
        
            q_text.Text = questions[index].Question_text;


            choice1.ImageUrl = getPathName();



        }




    }

    private string getPathName()
    {
        String s = Server.MapPath("~") + @"\temp\img" + 0 + ".png";
        return s;
    }

    protected void next_button_Click(object sender, EventArgs e)
    {
        if(index != count)
        {
            q_text.Text = questions[index].Question_text;
            
            
        }
       
    }

 
}