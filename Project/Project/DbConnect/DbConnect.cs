using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.DbConnect
{
    class Transactions
    {
        NpgsqlConnection conn = new NpgsqlConnection();
        NpgsqlCommand command = new NpgsqlCommand();
        NpgsqlTransaction transaction;

        private string dataBaseName = "postgres_production";

        public bool OpenConnection()
        {
            bool isConnected = false;
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                else
                {
                    string sql = "Server=localhost;Port=5432; User Id=postgres;Password=root; Database=" + dataBaseName + ";";
                    conn = new NpgsqlConnection(sql);
                    conn.Open();
                    isConnected = true;
                }


            }
            catch (Exception e)
            {
                isConnected = false;

            }
            finally
            {
                conn.Close();
            }

            return isConnected;

        }


        public string builDatabaseStr() {

            string dropStr = "DROP TABLE  IF EXISTS  study_progress ; DROP TABLE  IF EXISTS  subject ; DROP TABLE  IF EXISTS  user_info ;";
            string createTableUsers = "CREATE TABLE user_info( " +
                "user_id serial2 PRIMARY KEY, " +
                "user_name VARCHAR (255) UNIQUE NOT NULL, " +
                "user_password VARCHAR(255) NOT NULL, " +
                "NAME VARCHAR(255) NOT NULL); ";
            string createTableSubject = " CREATE TABLE subject ( " +
                "study_id serial2 PRIMARY KEY, " +
                "study_name VARCHAR(255), " +
                "study_decription VARCHAR(255), " +
                "study_limit int8, " +
                "user_id int8, " +
                "CONSTRAINT fkuser_id FOREIGN KEY(user_id) REFERENCES user_info(user_id) ON DELETE CASCADE ON UPDATE CASCADE);";
            string createTableScheduleStudy = " CREATE TABLE schedule_study ( " +
                "study_details_id serial2 PRIMARY KEY, " +
                "study_id int8, " +
                "no_days_accomplish int8," +
                "no_sessions_day int8, " +
                "type int8, " +
                "study_description VARCHAR(255), " +
                "time_start timestamp, " +
                "CONSTRAINT fkstudy_id FOREIGN KEY(study_id) REFERENCES subject(study_id) " +
                "ON DELETE CASCADE ON UPDATE CASCADE); ";
            string createTableStudyProgress = " CREATE TABLE study_progress (" +
                "study_progress_id serial2 PRIMARY KEY," +
                "study_details_id int8, " +
                "study_percent int2 DEFAULT 0, " +
                "study_time time, " +
                "CONSTRAINT fkstudy_details_id FOREIGN KEY(study_details_id) REFERENCES schedule_study(study_details_id) " +
                "ON DELETE CASCADE ON UPDATE CASCADE); ";

            string str = dropStr + createTableUsers + createTableSubject + createTableScheduleStudy + createTableStudyProgress;

            return str;

        }


        public bool createDatabase() {

            bool successCreatingDatabase = false;

            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                else
                {


                    string sql = "Server=localhost;Port=5432; User Id=postgres;Password=root";
                    conn = new NpgsqlConnection(sql);
                    command = new NpgsqlCommand("CREATE DATABASE "+ dataBaseName + " WITH OWNER = postgres ENCODING = 'UTF8' TABLESPACE = pg_default CONNECTION LIMIT = -1; ",conn);
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                    successCreatingDatabase = true;
                }


            }
            catch (Exception e)
            {
                successCreatingDatabase = false;

            }
            finally
            {
                conn.Close();
            }

            return successCreatingDatabase;
        }



        public bool createTables() {
            bool successCreatingTable = false;

            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                else
                {


                    string sqlCon = "Server=localhost;Port=5432; User Id=postgres;Password=root; Database=" + dataBaseName + ";";
                    conn = new NpgsqlConnection(sqlCon);
                    conn.Open();
                    command = new NpgsqlCommand(builDatabaseStr(), conn);
                    command.ExecuteNonQuery();
                    conn.Close();
                    successCreatingTable = false;
                }


            }
            catch (Exception e)
            {
                successCreatingTable = false;

            }
            finally
            {
                conn.Close();
            }

            return successCreatingTable;

        }



        public void rollBackQuery()
        {
            transaction.Rollback();

            conn.Close();
        }

        public void startTransaction()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            transaction = conn.BeginTransaction();
            command.Connection = conn;
            command.CommandTimeout = 0;
            command.Transaction = transaction;
        }

        public void closeTransaction()
        {

            conn.Close();

        }

        public void commitQuery()
        {
            try
            {
                transaction.Commit();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }

        }

        public DataTable Datasource(string sql)
        {
            DataSet dataSet = new DataSet();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            da.Fill(dataSet, "Custom_Command");
            da.Dispose();
            return dataSet.Tables["Custom_Command"];

        }



    }
}
