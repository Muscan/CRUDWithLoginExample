using CRUDWithLoginExample.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
    }
}
