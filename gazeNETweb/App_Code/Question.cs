using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Creator
/// </summary>
public class Question
{

    private int question_ID ;
    private String question_type;
    private String question_text;
    private List<Image> image_options;
    
    private Database database = new Database();

    public int Question_ID { get => question_ID; set => question_ID = value; }
    public string Question_type { get => question_type; set => question_type = value; }
    public string Question_text { get => question_text; set => question_text = value; }
    public List<Image> Image_options { get => image_options; set => image_options = value; }

    public Question()
    {


        image_options = new List<Image>();
    }
     

    public void createQuestion(String type)
    {
        question_ID = getQuestionID(type);
        question_type = type;
        question_text = getQuestionText(question_ID);
        image_options = getQuestionImageOptions(question_ID);
    }


    public int getQuestionID(String q_type)
    {
        question_type = q_type;
        question_ID = database.getQuestionID(q_type);


        return question_ID;
    }

    private String  getQuestionText(int q_id)
    {

        question_text = database.getQuestionText(q_id);
        return question_text;
    }

    private List<Image> getQuestionImageOptions(int q_id)
    {

        image_options = database.getImageQuestionOptions(q_id,question_type);

        return image_options;
       
    }



}