// Ignore Spelling: Facebook App

using System;
using System.Collections.Generic;
using System.Collections;

namespace FacebookDAppLogics
{
    public class FacebookCollectionWrapper<T> : IEnumerable<T>
    {
        private readonly Func<IEnumerable<T>, IEnumerable<T>, int> r_SortFunction;
        private T[] m_CurrentFacebookObject;

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

        public FacebookCollectionWrapper(T[] i_FacebookObject, Func<IEnumerable<T>, IEnumerable<T>, int> i_SortFunction = null)
        {
            m_CurrentFacebookObject = i_FacebookObject;
            r_SortFunction = i_SortFunction;
        }

        internal void SortCollection()
        {
            if (r_SortFunction != null)
            {
                Array.Sort(
                    m_CurrentFacebookObject,
                    (user1, user2) =>
                {
                    return r_SortFunction(new[] { user1 }, new[] { user2 });
                });
            }
        }
    }
}
