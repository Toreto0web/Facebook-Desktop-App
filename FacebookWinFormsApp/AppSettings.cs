using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FacebookDApp
{
    class AppSettings
    {
        public Point m_LastWindowLocation { get; set; }
        public Size m_LastWindowSize { get; set; }
        public bool m_RememberUser { get; set; }
        public string m_LastAccessToken { get; set; }
    }
}
