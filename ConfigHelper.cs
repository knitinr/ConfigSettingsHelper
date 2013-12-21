using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigUtilities
{
    public class ConfigHelper : BaseConfigHelper<ConfigHelper>
    {
        public ConfigHelper() { }
        public ConfigHelper(string aPath) : base(aPath) { }

        public string this[string key] {
            get
            {
                if (Configuration.AppSettings.Settings.AllKeys.Contains(key))
                {
                    return Configuration.AppSettings.Settings[key].Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (Configuration.AppSettings.Settings.AllKeys.Contains(key))
                {
                    Configuration.AppSettings.Settings[key].Value = value;
                }
                else
                {                    
                    Configuration.AppSettings.Settings.Add(key, value);
                }

                Configuration.Save();
            }
        }
    }
}
