using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /*
     * Senaryo:
     * Mail konfigürasyonunun sadece bir instance olması yeterli.
     */

    public class MailConfigurator
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public bool EnableSSL { get; set; }

        private MailConfigurator()
        {
            // MailConfigurator sınıfından instance oluşturulmasını engellemek için private constructor kullanıyoruz.
        }

        private static MailConfigurator instance;
        public static MailConfigurator CreateInstance()
        {
            if (instance == null)
            {
                instance = new MailConfigurator();
            }
            return instance;
        }
    }
}
