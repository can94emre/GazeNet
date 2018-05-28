using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Experiment
/// </summary>
public class Experiment
{
    private int q_count;
    private  List<Question> questions;
    private static Experiment instance;
    private Database database = new Database();
    private Experiment()
    {
        questions = new List<Question>();
        //database.insertExperiment(questions);
    }

    public static Experiment Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Experiment();
            }
            return instance;
        }
    }

    public List<Question> Questions { get => questions; set => questions = value; }
    public int Q_count { get => q_count; set => q_count = value; }
}