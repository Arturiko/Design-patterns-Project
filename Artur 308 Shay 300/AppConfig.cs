using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Artur_308_Shay_300
{
    public class AppConfig
    {
        private static readonly string sr_FileName;

        private static readonly object sr_GetOrCreateContext = new object();

        private static AppConfig s_AppConfig;

        public static AppConfig Instance
        {
            get
            {
                if (s_AppConfig == null)
                {
                    lock (sr_GetOrCreateContext)
                    {
                        if (s_AppConfig == null)
                        {
                            s_AppConfig = fromFileOrDefault();
                        }
                    }
                }

                return s_AppConfig;
            }
        }

        public string AccessToken { get; set; }

        public bool KeepUserloggedIn { get; set; }

        private static AppConfig fromFileOrDefault()
        {
            AppConfig loadedApplicationSettings;

            if (File.Exists(sr_FileName))
            {
                using (FileStream stream = new FileStream(sr_FileName, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppConfig));
                    loadedApplicationSettings = (AppConfig)serializer.Deserialize(stream);
                }
            }
            else
            {
                loadedApplicationSettings = new AppConfig()
                {
                    KeepUserloggedIn = false,
                };
            }

            return loadedApplicationSettings;
        }

        static AppConfig()
        {
            sr_FileName = Application.ExecutablePath + ".settings.xml";
        }
        
        private AppConfig()
        {
        }

        public void SaveToFile()
        {
            using (Stream stream = new FileStream(sr_FileName, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(AppConfig));
                serializer.Serialize(stream, this);
            }
        }
    }
}
