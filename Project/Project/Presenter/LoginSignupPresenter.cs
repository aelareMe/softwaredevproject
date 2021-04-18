﻿using Project.Interface;
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

        ILogin iLogin;
        ISignup iSignup;

        LoginSginupModel model = new LoginSginupModel();
    
        UserInfObject obj = new UserInfObject("","","");
        public LoginSignupPresenter(ILogin iLogin) {
            this.iLogin = iLogin;
        }

        public LoginSignupPresenter(ISignup iSignup,ILogin iLogin= null)
        {
            this.iLogin = iLogin;
            this.iSignup = iSignup;
        }


        public void startLogin() {

            DataTable dt = model.login(iLogin.username, iLogin.password);

            if (dt.Rows.Count > 0)
            {

                obj = new UserInfObject(dt.Rows[0]["user_name"].ToString(),
                    dt.Rows[0]["user_name"].ToString() , dt.Rows[0]["name"].ToString(),
                    Int32.Parse(dt.Rows[0]["id"].ToString()), true);
                MessageBox.Show("Login Success");


                MainPage form = new MainPage();
                MainPagePresenter pres = new MainPagePresenter();
                form.txbName = obj.getName();
                form.Show();
                iLogin.currentForm.Hide();

            }
            else {
                MessageBox.Show("Login Failed Incorrect username or password");
            }

        }

        public void signup() {

            DataTable signup = model.signup(iSignup.username,
                iSignup.password , iSignup.name);

            if (signup.Rows.Count>0)
            {
                MessageBox.Show("Success Signup");
                gotoLogin();
            }
    
        }

        public void gotoSignup() {
            Signup form = new Signup();
            MainPagePresenter pres = new MainPagePresenter();
            form.Show();
            iLogin.currentForm.Hide();
        }

        public void gotoLogin() {
            Login form = new Login();
            MainPagePresenter pres = new MainPagePresenter();
            form.Show();
            iSignup.currentForm.Hide();
        }

    }
}
