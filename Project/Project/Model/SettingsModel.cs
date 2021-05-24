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
    class SettingsModel
    {
        Transactions trans = new Transactions();

        public DataTable UpdateProfile(string userName, string password,string name, int userId)
        {
            string sql = " update  user_info Set user_name = '"+userName+"', user_password = '"+password+"', " +
                "name = '"+name+"' where user_id  = "+userId+"  RETURNING * ";
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
