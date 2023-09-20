using System;
using System.Collections.Generic;
using System.Collections;

namespace FacebookDAppLogics
{
    public class FacebookCollectionWrapper<T> : IEnumerable<T>
    {
        private readonly Func<IEnumerable<T>, IEnumerable<T>, int> r_ManipulateFunction;
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

        public FacebookCollectionWrapper(T[] i_FacebookObject, Func<IEnumerable<T>, IEnumerable<T>, int> i_ManipulateFunction = null)
        {
            m_CurrentFacebookObject = i_FacebookObject;
            r_ManipulateFunction = i_ManipulateFunction;
        }

        internal void SortCollection()
        {
            if (r_ManipulateFunction != null)
            {
                Array.Sort(
                    m_CurrentFacebookObject,
                    (user1, user2) =>
                {
                    return r_ManipulateFunction(new[] { user1 }, new[] { user2 });
                });
            }
        }
    }
}
