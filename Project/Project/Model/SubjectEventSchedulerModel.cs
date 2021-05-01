using Project.DbConnect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Model
{
    class SubjectEventSchedulerModel
    {
        Transactions trans = new Transactions();

        public DataTable LoadAllSubjects(int userId)
        {

            string sql = "Select  study_id,study_name,study_decription,study_limit from subject " +
                "where user_id = " + userId + "";
            DataTable dt = new DataTable();
            trans.OpenConnection();
            trans.startTransaction();
            try
            {

                dt = trans.Datasource(sql);
                trans.commitQuery();
                trans.closeTransaction();
            }
            catch (Exception e)
            {
                trans.closeTransaction();
                MessageBox.Show(e.Message);
            }

            return dt;

        }


        public DataTable LoadAllMainPageSubjects(int userId)
        {

            string sql = "Select study_name as \"Subject Name\",study_decription as \"Description\"from subject " +
                "where user_id = " + userId + "";
            DataTable dt = new DataTable();
            trans.OpenConnection();
            trans.startTransaction();
            try
            {

                dt = trans.Datasource(sql);
                trans.commitQuery();
                trans.closeTransaction();
            }
            catch (Exception e)
            {
                trans.closeTransaction();
                MessageBox.Show(e.Message);
            }

            return dt;

        }



        public DataTable AddEventToSubject(int studyID,string timeStart,
            string eventName,int eventType, int numberOfDaysAccomplish, int numberOfSessionsDay)
        {

            string sql = "INSERT INTO schedule_study (study_id,time_start," +
                "study_description,type,no_days_accomplish ,no_sessions_day )VALUES(" + studyID + "" +
                ",'"+ timeStart + "','"+ eventName +"',"+eventType+ "," + numberOfDaysAccomplish + "," +
                "" + numberOfSessionsDay + ")RETURNING * ";
            DataTable dt = new DataTable();
            trans.OpenConnection();
            trans.startTransaction();
            try
            {

                dt = trans.Datasource(sql);
                trans.commitQuery();
                trans.closeTransaction();
            }
            catch (Exception e)
            {
                trans.closeTransaction();
                MessageBox.Show(e.Message);
            }

            return dt;

        }



        public DataTable LoadSubjectStudyTime(int studyID)
        {

            string sql = "SELECT study_id,study_details_id, study_description AS \"Description\" ," +
                "time_start AS \"Scheduled Date\", no_days_accomplish AS \"No of Days To Accomplish\" , " +
                "no_sessions_day AS \"No of Sessions Per Day\"" +
                "FROM schedule_study WHERE study_id = "+ studyID + "";
            DataTable dt = new DataTable();
            trans.OpenConnection();
            trans.startTransaction();
            try
            {

                dt = trans.Datasource(sql);
                trans.commitQuery();
                trans.closeTransaction();
            }
            catch (Exception e)
            {
                trans.closeTransaction();
                MessageBox.Show(e.Message);
            }

            return dt;

        }

        public DataTable GetScheduledStudy(int userID,string range)
        {

            string sql = "SELECT schedule_study.study_details_id as \"_StudyDetails\"," +
                         "schedule_study.type as \"_ScheduleType\",subject.study_id as \"_StudyID\"," +
                         "subject.study_name as \"Subject Code\", subject.study_name as \"Subject Name\"," +
                         "schedule_study.study_description as \"Description\",study_progress.study_time  as \"Study Time\" " +
                         "FROM schedule_study " +
                         "INNER JOIN subject ON schedule_study.study_id = subject.study_id " +
                         "INNER JOIN study_progress on schedule_study.study_details_id = study_progress.study_details_id "+
                         "INNER JOIN user_info ON subject.user_id = user_info.user_id " +
                         "where now()::time(0) > (study_time - interval '" + range + "' MINUTE )::time(0)  AND " +
                         "now()::time(0) < (study_time + interval '" + range + "' MINUTE )::time(0) AND " +
                         "user_info.user_id = " + userID + "";


            DataTable dt = new DataTable();
            trans.OpenConnection();
            trans.startTransaction();
            try
            {

                dt = trans.Datasource(sql);
                trans.commitQuery();
                trans.closeTransaction();
            }
            catch (Exception e)
            {
                trans.closeTransaction();
                MessageBox.Show(e.Message);
            }

            return dt;

        }

        public DataTable GetPercentsPerType(int userID) {

            string sql = "Select subject.study_name as \"Subject Code\", "+
                         "schedule_study.type as \"_type\", "+
                         "schedule_study.study_description as \"Description\", "+
                         "schedule_study.study_details_id, "+
                         "s1.sum_type as \"Total Percent\" , s1.count as \"Percent Denomitator\" "+
                         "from user_info "+
                         "inner join subject on user_info.user_id = subject.user_id " +
                         "inner join schedule_study on subject.study_id = schedule_study.study_id "+
                         "inner join (Select SUM(study_progress.study_percent) as \"sum_type\", " +
                         "schedule_study.study_details_id , ctr.count " +
                         "from schedule_study " +
                         "inner join study_progress on schedule_study.study_details_id = study_progress.study_details_id " +        
                         "inner join ( Select count(study_progress.study_progress_id )as \"count\", " +
                         "schedule_study.type as \"typee\" " +
                         "from study_progress "+
                         "inner join schedule_study on study_progress.study_details_id = schedule_study.study_details_id "+
                         "group by typee) as \"ctr\" on schedule_study.type = ctr.typee " +
                         "group by schedule_study.study_details_id, schedule_study.type,ctr.count) as s1 " +
                         "on schedule_study.study_details_id = s1.study_details_id " +
                         "WHERE user_info.user_id = "+ userID + "";
            DataTable dt = new DataTable();
            trans.OpenConnection();
            trans.startTransaction();
            try
            {

                dt = trans.Datasource(sql);
                trans.commitQuery();
                trans.closeTransaction();
            }
            catch (Exception e)
            {
                trans.closeTransaction();
                MessageBox.Show(e.Message);
            }

            return dt;

        }



        public DataTable InsertStudyProgress(int studyDetailsID,string studyTime)
        {
            string sql = "INSERT into study_progress(study_details_id ,study_time )" +
                "VALUES("+studyDetailsID+",'"+studyTime+"')RETURNING * ";


            DataTable dt = new DataTable();
            trans.OpenConnection();
            trans.startTransaction();
            try
            {

                dt = trans.Datasource(sql);
                trans.commitQuery();
                trans.closeTransaction();
            }
            catch (Exception e)
            {
                trans.closeTransaction();
                MessageBox.Show(e.Message);
            }

            return dt;

        }


        public DataTable GettStudyProgress(int studyDetailsID)
        {
            string sql = "Select study_progress_id ,study_percent ," +
                "study_time::time(0) as \"Scheduled Time\" ," +
                "schedule_study.study_description  as  \"Study Name\" " +
                "FROM study_progress " +
                "INNER JOIN schedule_study on study_progress.study_details_id = schedule_study.study_details_id " +
                "WHERE schedule_study.study_details_id = " + studyDetailsID + "" +
                "Order by  study_time::time(0) ASC";

            
            DataTable dt = new DataTable();
            trans.OpenConnection();
            trans.startTransaction();
            try
            {

                dt = trans.Datasource(sql);
                trans.commitQuery();
                trans.closeTransaction();
            }
            catch (Exception e)
            {
                trans.closeTransaction();
                MessageBox.Show(e.Message);
            }

            return dt;

        }

    }
}
