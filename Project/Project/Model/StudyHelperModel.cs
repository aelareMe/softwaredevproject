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
    class StudyHelperModel
    {
        Transactions trans = new Transactions();

        public DataTable UpdateStudyProgress(int studyProgressId,int percent)
        {

            string sql = "UPDATE study_progress set study_percent = " + percent + " " +
                         "WHERE study_progress_id =" + studyProgressId + " RETURNING *";

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


        public DataTable LoadCurrentProgress(int studyProgressId)
        {

            string sql = "Select * from study_progress where study_progress_id  = "+ studyProgressId + "";

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
