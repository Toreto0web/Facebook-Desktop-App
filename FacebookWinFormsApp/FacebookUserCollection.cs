using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.IO;
using System.Net;
using System.Threading;
using System.Reflection;

namespace FacebookDApp
{
    class FacebookUserCollection
    {
        private User[] Friends { get; set; }

        public FacebookUserCollection(User[] friends)
        {
            Friends = friends;
        }

        public void SortCollection(in string i_attributeName)
        {
            PropertyInfo property = typeof(User).GetProperty(i_attributeName);
            if (property != null)
            {
                Array.Sort(Friends, (user1, user2) =>
                {
                    IComparable value1 = (IComparable)property.GetValue(user1);
                    IComparable value2 = (IComparable)property.GetValue(user2);
                    return value1.CompareTo(value2);
                });
            }
            else
            {
                Console.WriteLine($"Attribute '{i_attributeName}' not found.");
            }
        }
    }
}
