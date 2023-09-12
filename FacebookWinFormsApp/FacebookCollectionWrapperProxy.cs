using System;
using System.Reflection;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Collections.Generic;
using System.Collections;

namespace FacebookDAppLogics
{
    public class FacebookCollectionWrapperProxy<T> : IEnumerable<T>
    {
        private T[] m_CurrentFacebookObject;

        public T[] getTempLatedObject()
        {
            return m_CurrentFacebookObject;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in m_CurrentFacebookObject)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        
        public FacebookCollectionWrapperProxy(T[] i_FacebookObject)
        {
            m_CurrentFacebookObject = i_FacebookObject;
        }

        internal void SortCollection(in string i_AttributeName)
        {
            PropertyInfo property = typeof(T).GetProperty(i_AttributeName);
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
                Console.WriteLine($"Attribute '{i_AttributeName}' not found.");
            }
        }
    }
}
