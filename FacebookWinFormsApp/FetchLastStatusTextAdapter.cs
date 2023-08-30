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
        public System.Windows.Forms.TextBox TextBox { get; set; }

        public void FetchLastStatusText() 
        {
            TextBox.Invoke(new Action(() => TextBox.Text = Client.FetchLastStatusText()));
        }
    }
}
