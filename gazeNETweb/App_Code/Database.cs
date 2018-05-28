using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;
/// <summary>
/// Summary description for Database
/// </summary>
public class Database
{

    private MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;

    public Database()
    {
        Initialize();
    }

  

    private void Initialize()
    {
        server = "localhost";
        database = "gazenet";
        uid = "root";
        password = "zehra61.95";
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        connection = new MySqlConnection(connectionString);
    }

   

    private bool OpenConnection()
    {
        try
        {
            connection.Open();
            return true;
        }
        catch (MySqlException ex)
        {
            switch (ex.Number)
            {
                case 0:
                    //0: Cannot connect to server.
                    break;

                case 1045:
                    //1045: Invalid user name and/or password. 
                    break;
            }
            return false;
        }
    }
    private bool CloseConnection()
    {
        try
        {
            connection.Close();
            return true;
        }
        catch (MySqlException ex)
        {
            //exception message
            return false;
        }
    }
    public void InsertParticipant(long participantID, String gender, String participantName, String date, String job, String participantMail, String IPAdress, String participantPassword)
    {
        string query = "INSERT INTO Participant (PARTICIPANT_ID,PARTICIPANT_GENDER,PARTICIPANT_NAME,PARTICIPANT_BIRTHDAY," +
            "PARTICIPANT_JOB,PARTICIPANT_MAIL,IP_ADRESS ,PARTICIPANT_PASSWORD)" +
            " VALUES(" + participantID + ",'" + gender + "','" + participantName + "','" + date + "','" + job + "'" +
            ",'" + participantMail + "','" + IPAdress + "','" + participantPassword + "')";

        //open connection

        if (this.OpenConnection() == true)
        {
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, connection);

            //Execute command
            cmd.ExecuteNonQuery();

            //close connection
            this.CloseConnection();
        }
    }
    public bool userExists(long ID)
    {
        MySqlCommand cmd = new MySqlCommand("Select count(*) from Participant where PARTICIPANT_ID= " + ID, this.connection);
        connection.Open();
        var result = cmd.ExecuteScalar();
        connection.Close();
        if (result != null)
            return true;

        return false;

    }
    public string getUserName(long ID)
    {
        MySqlCommand cmd = new MySqlCommand("Select PARTICIPANT_NAME from Participant where PARTICIPANT_ID= " + ID, this.connection);
        connection.Open();
        MySqlDataReader reader;
        reader = cmd.ExecuteReader();
        string result = "";

        if (reader.Read())
        {
            result = reader.GetString("Participant_NAME").ToString();
        }
        connection.Close();
        return result;
    }
    public String getUserPassword(long ID)
    {
        MySqlCommand cmd = new MySqlCommand("Select PARTICIPANT_PASSWORD from Participant where PARTICIPANT_ID= " + ID, this.connection);
        connection.Open();
        MySqlDataReader reader;
        reader = cmd.ExecuteReader();
        string result = "";

        if (reader.Read())
        {
            result = reader.GetString("Participant_Password").ToString();
        }
        connection.Close();
        return result;
    }

    public void changePassword(long userID,String pass)
    {
        MySqlCommand cmd = new MySqlCommand("UPDATE Participant SET Participant_Password ='" + pass + "' WHERE PARTICIPANT_ID=" + userID, this.connection);
        connection.Open();
        cmd.ExecuteNonQuery();

        connection.Close();


    }

    public void changeMail(long userID, String mail)
    {
        MySqlCommand cmd = new MySqlCommand("UPDATE Participant SET Participant_Mail ='" + mail + "' WHERE PARTICIPANT_ID=" + userID, this.connection);
        connection.Open();
        cmd.ExecuteNonQuery();

        connection.Close();


    }

    public  int getQuestionID(String type)
    {

        MySqlCommand cmd = new MySqlCommand("select QUESTION_ID from gazenet.question WHERE QUESTION_TYPE='" + type + "'", this.connection);
        connection.Open();
        MySqlDataReader reader;
        reader = cmd.ExecuteReader();
        List<int> q_ids = new List<int>();
      

        while (reader.Read())
        {
            q_ids.Add(Int32.Parse(reader.GetString("QUESTION_ID").ToString())) ;
          
        }

        int ID = q_ids[0];
        connection.Close();

        return ID;

    }

    public String getQuestionText(int id)
    {

        MySqlCommand cmd = new MySqlCommand("select QUESTION_TEXT from gazenet.question WHERE QUESTION_ID=" + id, this.connection);
        connection.Open();
        MySqlDataReader reader;
        reader = cmd.ExecuteReader();
        String text=null;


        if (reader.Read())
        {
          text =  reader.GetString("QUESTION_TEXT").ToString();

        }

       
        connection.Close();

        return text;

    }

    public List<Image> getImageQuestionOptions(int id,String type)
    {

        MySqlCommand cmd = new MySqlCommand("select IMG from gazenet.images_option WHERE REFERRED_ID=" + id, this.connection);
        connection.Open();
        MySqlDataReader reader;
        reader = cmd.ExecuteReader();
        List<Image> options = new List<Image>();


        if (type.Equals("Visual")) {
            while (reader.Read())
            {

                byte[] img = (byte[])reader["IMG"];
                if (img == null)
                {

                }
                else
                {
                    MemoryStream memoryStream = new MemoryStream(img);
                    Image image = Image.FromStream(memoryStream);
                    options.Add(image);
                }

            }
        }
        else if(type.Equals("verbal"))
        {


        }
                
       


        connection.Close();

        return options;

    }
  
}