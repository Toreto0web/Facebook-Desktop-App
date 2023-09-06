using System;
using System.Reflection;

namespace FacebookDAppLogics
{
    public class FacebookCollectionWrapper<T>
    {
        private T[] m_CurrentFacebookObject;

        public FacebookCollectionWrapper(T[] i_FacebookObject)
        {
            m_CurrentFacebookObject = i_FacebookObject;
        }

        internal void SortCollection(in string i_attributeName)
        {
            PropertyInfo property = typeof(T).GetProperty(i_attributeName);
            if (property != null)
            {
                Array.Sort(m_CurrentFacebookObject, (user1, user2) =>
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
