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

namespace FacebookDApp
{
    class Post
    {

        public void postPost(string text)
        {
            try
            {
                Status postedStatus = m_LoggedInUser.PostStatus(text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Done!");
            }
        }

        public void PostFuturePost(DateTime time, string text)
        {
            if (time <= DateTime.Now)
            {
                MessageBox.Show("The time you entered already passed");
            }
            else
            {
                DateTime currentTime = DateTime.Now;

                TimeSpan timeDifference = time - currentTime;
                MessageBox.Show($"please wait {timeDifference.TotalSeconds.ToString()} seconds");
                Thread.Sleep((int)timeDifference.TotalMilliseconds);

                postPost(text);
            }
        }
    }
}
