using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Current_User
/// </summary>
public sealed class Current_User
{
    private static Current_User instance = null;
    private long user_id;
    private static readonly object padlock = new object();

    Current_User()
    {
    }

    public static Current_User Instance
    {
        get
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new Current_User();
                }
                return instance;
            }
        }
    }
    public long User_id { get => user_id; set => user_id = value; }
}