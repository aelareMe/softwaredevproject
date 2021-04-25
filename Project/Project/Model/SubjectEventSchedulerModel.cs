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



        public DataTable AddEventToSubject(int studyID,string timeStart,string eventName,int eventType)
        {

            string sql = "INSERT INTO schedule_study (study_id,time_start,study_description,type)VALUES("+ studyID + "" +
                ",'"+ timeStart + "','"+ eventName +"',"+eventType+")RETURNING * ";
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

            string sql = "SELECT study_id, study_description AS \"Description\" ,time_start AS \"Scheduled Time\"" +
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
                         "schedule_study.study_description as \"Description\" " +
                         "FROM schedule_study " +
                         "INNER JOIN subject ON schedule_study.study_id = subject.study_id " +
                         "INNER JOIN user_info ON subject.user_id = user_info.user_id " +
                         "where now()> (time_start - interval '"+ range + "' MINUTE )  AND " +
                         "now() < (time_start + interval '" + range + "' MINUTE ) AND " +
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

        public DataTable GetAllPercentage(int userID) {

            string sql = "SELECT  schedule_study.study_percent, schedule_study.type "+
                          "FROM schedule_study "+
                          "INNER JOIN subject ON schedule_study.study_id = subject.study_id "+
                          "INNER JOIN user_info ON subject.user_id = user_info.user_id "+
                          "WHERE user_info.user_id = "+userID+"";


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
