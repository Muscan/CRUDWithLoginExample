﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CRUDWithLoginExample.Utils
{
    class Functii
    {
        public static bool IsNotEmpty(TextBox txtBox)
        {
            if (txtBox.Text.Equals("")) return false;
            return true;
        }

        public static void MandatoryField(string field)
        {
            MessageBox.Show("Mandatory: " + field);
        }
        public static void Clear1Field(TextBox txt1)
        {
            txt1.Clear();
        }

        public static void Clear2Fields(TextBox txt1, TextBox txt2)

        {
            txt1.Clear();
            txt2.Clear();
        }

        public static void Clear4Fields(TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
          
        }

        
    }
}
