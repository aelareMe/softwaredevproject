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
    class AddSubjectModel
    {
        Transactions trans = new Transactions();


        public DataTable AddSubject(string studyName,string desc,int userId)
        {

            string sql = "INSERT INTO subject ( study_name,study_decription,study_limit,user_id)" +
                "VALUES('"+ studyName + "' ," +"'"+desc+"', 300 ,"+userId+" ) RETURNING * ";
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
