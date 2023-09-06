using System;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using System.Text.RegularExpressions;
using FacebookWrapper;
using System.IO;
using System.Net;
using System.Threading;

namespace WinFormUI
{
    internal class TextBoxProxy 
    {
        private System.Windows.Forms.TextBox TextBoxForm;

        internal TextBoxProxy(string i_textBoxString, System.Windows.Forms.TextBox textBox)
        {
            TextBoxForm = textBox;
            TextBoxForm.Text = i_textBoxString;
            AlignStatus();
        }

        private bool isStatusInEnglish()
        {
            string pattern = @"[^a-zA-Z]";
            
            return Regex.IsMatch(TextBoxForm.Text, pattern);
        }

        internal void AlignStatus() 
        {
            if (isStatusInEnglish()) 
            {
                TextBoxForm.TextAlign = HorizontalAlignment.Right;
            }
            else 
            {
                TextBoxForm.TextAlign = HorizontalAlignment.Left;
            }
        }
    }
}
