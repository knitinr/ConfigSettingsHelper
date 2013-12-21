using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigUtilities
{
    public abstract class BaseConfigHelper<T> where T : new()
    {
        public static T GetInstance()
        {
            return new T();
        }

        public BaseConfigHelper() { }
        public BaseConfigHelper(string aPath) { Path = aPath; }

        private string mPath = null;
        public string Path
        {
            get
            {
                if (mPath == null)
                {
                    return System.Reflection.Assembly.GetEntryAssembly().Location;
                }
                else
                {
                    return mPath;
                }
            }
            set { mPath = value; }
        }

        private System.Configuration.Configuration mConfiguration = null;

        protected System.Configuration.Configuration Configuration
        {
            get
            {
                if (mConfiguration == null)
                {
                    mConfiguration = System.Configuration.ConfigurationManager.OpenExeConfiguration(Path);
                }
                return mConfiguration;
            }
        }

    }
}
