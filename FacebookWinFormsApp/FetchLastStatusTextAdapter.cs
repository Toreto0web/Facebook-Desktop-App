using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookDApp
{
    public class FetchLastStatusTextAdapter
    {
        public Client Client { get; set; }
        public TextBoxProxy TextBox{ get; set; }

        public void FetchLastStatusText() 
        {
            TextBox.TextBoxForm.Text = Client.FetchLastStatusText();
            TextBox.AlignStatus();
        }
    }
}
