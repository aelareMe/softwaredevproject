using Project.Interface;
using Project.Model;
using Project.Object;
using Project.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Presenter
{
    class LoginSignupPresenter
    {

        ILoginSignup iLogin;

        LoginSginupModel model = new LoginSginupModel();

        UserInfObject obj = new UserInfObject("","");
        public LoginSignupPresenter(ILoginSignup iLogin) {
            this.iLogin = iLogin;
        }


        public void startLogin() {

            DataTable dt = model.login(iLogin.username, iLogin.password);

            if (dt.Rows.Count > 0)
            {

                obj = new UserInfObject(dt.Rows[0]["user_name"].ToString(), dt.Rows[0]["user_name"].ToString());
                MessageBox.Show("Login Success");


                MainPage form = new MainPage();
                MainPagePresenter pres = new MainPagePresenter();
                form.txbName = obj.getUserName();
                form.Show();
                iLogin.currentForm.Hide();

            }
            else {
                MessageBox.Show("Login Failed Incorrect username or password");
            }

        }

        public void signup() {

            DataTable signup = model.signup(iLogin.username, iLogin.password);

            if (signup.Rows.Count>0)
            {
                MessageBox.Show("Success Signup");
            }
            else {
                MessageBox.Show("Signup Failed Username Already Taken");
            }
        }

    }
}
