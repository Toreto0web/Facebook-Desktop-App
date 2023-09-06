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
            textBox.Invoke(new Action(() => TextBoxForm = textBox));
            textBox.Invoke(new Action(() => TextBoxForm.Text = i_textBoxString));
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
                TextBoxForm.Invoke(new Action(() => TextBoxForm.TextAlign = HorizontalAlignment.Right));
            }
            else 
            {
                TextBoxForm.Invoke(new Action(() => TextBoxForm.TextAlign = HorizontalAlignment.Left));
            }
        }
    }
}
