using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookDAppLogics
{
    internal class FetchLastStatusTextAdapter
    {
        internal Client Client { get; set; }
        internal TextBoxProxy TextBox{ get; set; }

        internal void FetchLastStatusText() 
        {
            TextBox.TextBoxForm.Text = Client.FetchLastStatusText();
            TextBox.AlignStatus();
        }
    }
}
