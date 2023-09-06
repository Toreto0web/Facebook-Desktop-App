using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormUI
{
    internal class FetchSortableAttributesComboBoxAdapter
    {
        private string[] Attributes;
        private System.Windows.Forms.ComboBox ComboBox;

        public FetchSortableAttributesComboBoxAdapter(in string[] i_AttributesList, System.Windows.Forms.ComboBox i_comboBox)
        {
            Attributes = i_AttributesList;
            ComboBox = i_comboBox;
        }

        public void fillSortableAttributesComboBox()
        {
            foreach (string str in Attributes)
            {
                ComboBox.Invoke(new Action(() => ComboBox.Items.Add(str)));
            }
        }
    }
}
