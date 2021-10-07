﻿using CRUDWithLoginExample.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CRUDWithLoginExample.Classes;
using static CRUDWithLoginExample.Utils.Functii;

namespace CRUDWithLoginExample.Forms
{
    public partial class LoginUserRole : Form
    {
        ControllerUser control = new ControllerUser();
        public LoginUserRole()
        {
            InitializeComponent();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnEditLoggedUser_Click(object sender, EventArgs e)
        {

            if (IsNotEmpty(txtBoxNewName) == false)
            {
                MandatoryField("New User Name! ");
            }
            else if (IsNotEmpty(txtBoxNewPassword) == false)
            {
                MandatoryField("New Password! ");
            }
            else
            {
                string updateName = txtBoxNewName.Text;
                string updatePassword = txtBoxNewPassword.Text;
                //save and check with the logged user. TBD
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            Clear1Field(txtBoxNewName);
            Clear1Field(txtBoxNewPassword);
        }
    }
}
