using Project.Interface;
using Project.Model;
using Project.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Presenter
{
    class SettingsPresenter
    {
        ISettings isettings;
        SettingsModel model = new SettingsModel();
        public SettingsPresenter(ISettings isettings) {
            this.isettings = isettings;
        }


        public  void updateProfile() {



            DataTable response = model.UpdateProfile(isettings.userName,
                isettings.password, isettings.name, isettings.id);

            if (response.Rows.Count > 0) {
                UserInfObject obj = new UserInfObject(true, isettings.userName,
                   isettings.password, isettings.name, isettings.id);
                isettings.mainPageForm.userInfo = obj;
                MessageBox.Show("Success Editing Your Profile ");
             //   exit(frm);
            }
        }

        public void exit(Form frm) {
            isettings.mainPageForm.Close();
           frm.Close();
            Login login = new Login();
            login.Show();
        }
    }
}
