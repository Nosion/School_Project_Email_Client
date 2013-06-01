using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace EmailClient
{
    public class SqlHandler
    {
        public SQLiteConnection sqliteCon;

        public void CreateDB()
        {
            

            //http://blog.tigrangasparian.com/2012/02/09/getting-started-with-sqlite-in-c-part-one/
            string dbConnString = @"Data Source=db.sqlite; Version=3;"; // Creating the connection string with filepath to the DB
            sqliteCon = new SQLiteConnection(dbConnString); // Creating new connection string instance.
            try
            {

                sqliteCon.Open(); // Open database


                // Defining the SQL Create table string 
                string crtMessagetblSQL = "CREATE TABLE IF NOT EXISTS [Messages] (" +
                    "[msgID] TEXT NOT NULL PRIMARY KEY," +
                    "[msgSender] TEXT NULL," +
                    "[msgSubject] TEXT NULL," +
                    "[msgBody] TEXT NULL" +
                    ")";

                using (SQLiteTransaction sqlTrans = sqliteCon.BeginTransaction())
                {
                    SQLiteCommand crtComm = new SQLiteCommand(crtMessagetblSQL, sqliteCon);

                    crtComm.ExecuteNonQuery();

                    //   crtComm.Dispose();

                    sqlTrans.Commit(); // Commit changes into the DB
                } // End using

                sqliteCon.Close(); // Closes DB connection

            } // End try

            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            } // End catch

        }

        public void InsertMsgInto(List<OpenPop.Mime.Message> list)
        {


            string dbConnString = @"Data Source=db.sqlite; Version=3;"; // Creating the connection string with filepath to the DB
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnString); // Creating new connection string instance.
            sqliteCon.Open(); // Open database

            SQLiteTransaction sqlTrans;

            SQLiteCommand comInsert = new SQLiteCommand("INSERT OR IGNORE INTO messages (msgID, msgSender, msgSubject, msgBody) VALUES (@msgID, @msgSender, @msgSubject, @msgBody)", sqliteCon);

            foreach (OpenPop.Mime.Message message in list)
            {
                if (message.Headers.MessageId != null)
                {
                    comInsert.Parameters.AddWithValue("@msgID", message.Headers.MessageId);
                    comInsert.Parameters.AddWithValue("@msgSender", message.Headers.From.Address);
                    comInsert.Parameters.AddWithValue("@msgSubject", message.Headers.Subject);
                    if (!message.MessagePart.IsMultiPart)
                    {
                        comInsert.Parameters.AddWithValue("@msgBody", message.MessagePart.GetBodyAsText());
                    }
                    else
                    {
                        OpenPop.Mime.MessagePart plaintext = message.FindFirstPlainTextVersion();
                        comInsert.Parameters.AddWithValue("@msgBody", plaintext.GetBodyAsText());
                    }

                    sqlTrans = sqliteCon.BeginTransaction();
                    int result = comInsert.ExecuteNonQuery();

                    sqlTrans.Commit(); // Commit changes into the DB

                } // End if

            } // End foreach

            comInsert.Dispose();

            sqliteCon.Close();
        }



        public List<Msg> listDbMsg()
        {
            SQLiteCommand cmdRead = new SQLiteCommand("SELECT * FROM Messages", sqliteCon);
            
            sqliteCon.Open(); // Open database
            SQLiteDataReader reader = cmdRead.ExecuteReader();

            List<Msg> dbMsgList = new List<Msg>();
            try
            {
                while (reader.Read())
                {
                    string msgID = reader.GetString(0);
                    string msgSender = reader.GetString(1);
                    string msgSubject = reader.GetString(2);
                    string msgBody = reader.GetString(3);
                    dbMsgList.Add(new Msg() { MsgID = msgID, MsgSender = msgSender, MsgSubject = msgSubject, MsgBody = msgBody });
                }
                return dbMsgList;     
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            finally
            {
                reader.Close(); // Close connection
                sqliteCon.Close();
            }
            
        }


    }
}
