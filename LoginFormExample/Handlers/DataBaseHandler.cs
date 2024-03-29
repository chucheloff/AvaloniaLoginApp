using System;
using System.Data.SQLite;

namespace LoginFormExample.Handlers
{
    public class DataBaseHandler
    {
        static void CreateAndTestDatabase()
      {
         SQLiteConnection sqlite_conn;
         sqlite_conn = CreateConnection();
         CreateTable(sqlite_conn);
         InsertData(sqlite_conn);
         ReadData(sqlite_conn);
      }

      static SQLiteConnection CreateConnection()
      {
         using (var sqliteConn =
                // Create a new database connection:
                new SQLiteConnection(@"Data Source=./res/database.db;Version=3;New=True;Compress=True;"))
         {
            try
            {
               sqliteConn.Open();
            }
            catch (Exception ex)
            {

            }
            return sqliteConn;
         }
      }

      static void CreateTable(SQLiteConnection conn)
      {
         string Createsql = "CREATE TABLE SampleTable (Col1 VARCHAR(20), Col2 INT)";
         string Createsql1 = "CREATE TABLE SampleTable1 (Col1 VARCHAR(20), Col2 INT)";
         var sqlite_cmd = conn.CreateCommand();
         sqlite_cmd.CommandText = Createsql;
         sqlite_cmd.ExecuteNonQuery();
         sqlite_cmd.CommandText = Createsql1;
         sqlite_cmd.ExecuteNonQuery();

      }

      static void InsertData(SQLiteConnection conn)
      {
         SQLiteCommand sqlite_cmd;
         sqlite_cmd = conn.CreateCommand();
         sqlite_cmd.CommandText = "INSERT INTO SampleTable (Col1, Col2) VALUES ('Test Text ', 1);";
         sqlite_cmd.ExecuteNonQuery();
         sqlite_cmd.CommandText = "INSERT INTO SampleTable (Col1, Col2) VALUES ('Test1 Text1 ', 2);";
         sqlite_cmd.ExecuteNonQuery();
         sqlite_cmd.CommandText = "INSERT INTO SampleTable (Col1, Col2) VALUES ('Test2 Text2 ', 3);";
         sqlite_cmd.ExecuteNonQuery();


         sqlite_cmd.CommandText = "INSERT INTO SampleTable1 (Col1, Col2) VALUES ('Test3 Text3 ', 3);";
         sqlite_cmd.ExecuteNonQuery();

      }

      static void ReadData(SQLiteConnection conn)
      {
         SQLiteDataReader sqlite_datareader;
         SQLiteCommand sqlite_cmd;
         sqlite_cmd = conn.CreateCommand();
         sqlite_cmd.CommandText = "SELECT * FROM SampleTable";

         sqlite_datareader = sqlite_cmd.ExecuteReader();
         while (sqlite_datareader.Read())
         {
            string myreader = sqlite_datareader.GetString(0);
            Console.WriteLine(myreader);
         }
         conn.Close();
      }
    }
}