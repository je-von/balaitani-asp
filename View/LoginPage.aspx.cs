﻿using balaitani_psd.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace balaitani_psd.View
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string username = emailTxt.Text;
            string password = passwordTxt.Text;

            User user = UserController.GetUser(username, password);

            if (user == null)
            {
                //login gagal
                errorLbl.Text = "Email or password incorrect!";
                return;
            }

            Session["user"] = user;

            Response.Redirect("HomePage.aspx");
        }
    }
}