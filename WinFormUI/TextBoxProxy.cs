using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WinFormUI
{
    internal class TextBoxProxy 
    {
        private TextBox TextBoxForm;

        internal TextBoxProxy(string i_TextBoxString, TextBox i_TextBox)
        {
            i_TextBox.Invoke(new Action(() => TextBoxForm = i_TextBox));
            i_TextBox.Invoke(new Action(() => TextBoxForm.Text = i_TextBoxString));
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
