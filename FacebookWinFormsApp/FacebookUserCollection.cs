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
    public class FacebookUserCollection 
    {
        private User[] Friends { get; set; }

        public FacebookUserCollection(User[] friends)
        {
            Friends = friends;
        }

        public void SortCollection<TAttr>(string attributeName) where TAttr : IComparable
        {
            PropertyInfo property = typeof(User).GetProperty(attributeName);
            if (property != null)
            {
                Func<User, TAttr> attributeSelector = user => (TAttr)property.GetValue(user);
                Array.Sort(Friends, (user1, user2) => attributeSelector(user1).CompareTo(attributeSelector(user2)));
            }
            else
            {
                Console.WriteLine($"Attribute '{attributeName}' not found.");
            }
        }
    }
}
