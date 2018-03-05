using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using Mono.Data.Sqlite;
using System.Data;
using System;


public class UserDataBase : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string conn = "URI=file:" + Application.dataPath + "/Plugins/Users.s3db"; //Path tot database.
        IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open(); //Open connection to the database.
        IDbCommand dbcmd = dbconn.CreateCommand();
        string sqlQuery = "SELECT * " + "FROM Userinfo";
        dbcmd.CommandText = sqlQuery;
        IDataReader reader = dbcmd.ExecuteReader(); 
        while (reader.Read())
        {
            int id = reader.GetInt32(0);
            string Name = reader.GetString(1);
            string Email = reader.GetString(2);

            Debug.Log("value = " + id + " name " + Name + " email " + Email);
        }
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        dbconn.Close();
        dbconn = null;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
