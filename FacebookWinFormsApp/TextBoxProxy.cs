using System;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using System.Text.RegularExpressions;
using FacebookWrapper;
using System.IO;
using System.Net;
using System.Threading;

namespace FacebookDAppLogics
{
    internal class TextBoxProxy 
    {
        internal System.Windows.Forms.TextBox TextBoxForm { get; set; }

        internal TextBoxProxy(System.Windows.Forms.TextBox i_textBox)
        {
            TextBoxForm = i_textBox;
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
