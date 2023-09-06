using System;
using FacebookWrapper.ObjectModel;
using System.Reflection;

namespace FacebookDAppLogics
{
    internal class FacebookCollection<T>
    {
        private T[] m_MyCollection;

        internal FacebookCollection(User[] friends)
        {
            m_MyCollection = friends;
        }

        internal void SortCollection(in string i_attributeName)
        {
            PropertyInfo property = typeof(User).GetProperty(i_attributeName);
            if (property != null)
            {
                Array.Sort(m_MyCollection, (user1, user2) =>
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
