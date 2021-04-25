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

        public DataTable UpdateScheduledStudy(int studyID,int percent)
        {

            string sql = "UPDATE schedule_study set study_percent = " + percent + " " +
                         "WHERE study_details_id =" + studyID + " RETURNING *";

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
