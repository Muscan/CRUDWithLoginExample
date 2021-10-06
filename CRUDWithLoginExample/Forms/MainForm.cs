using CRUDWithLoginExample.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CRUDWithLoginExample.Forms;
using CRUDWithLoginExample.Classes;
using static CRUDWithLoginExample.Utils.Functii;

namespace CRUDWithLoginExample.Forms
{
    public partial class frmMain : Form
    {
        ControllerUser control = new ControllerUser();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
          
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            control.AfisareUsers(lstUsers);
        }

        private void btnPrintAllUsers_Click(object sender, EventArgs e)
        {
            control.AfisareUsers(lstUsers);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty(txtBoxDeleteUser) == false)
            {
                MandatoryField("User to delete.");
            }
            else
            {
                control.DeleteUser(txtBoxDeleteUser.Text);
                control.AfisareUsers(lstUsers);
                txtBoxDeleteUser.Clear();

            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            control.AfisareUsers(lstUsers);
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty(txtBoxEditName) == false)
            {
                MandatoryField("User ");
            }
            else if (IsNotEmpty(txtBoxEditPassword) == false)
            {
                MandatoryField("Password ");
            }
            else
            {
                string editUser = txtBoxEditName.Text;
                string editPassword = txtBoxEditPassword.Text;
                bool isAdmin = checkBoxEditIsAdmin.Checked;

                User usr = new User(editUser, editPassword, isAdmin);

                control.updateUser(usr);
                control.AfisareUsers(lstUsers);
                ClearLoginFields(txtBoxEditName, txtBoxEditPassword);
                checkBoxEditIsAdmin.Checked = false;


            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
