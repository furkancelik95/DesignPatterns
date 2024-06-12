using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /*
    }
     * Senaryo:
     * Hem PDF hem de HTML olarak alabileceğimiz Satış ve Performans rapolarınız var.
     * Geliştirme yapısını nasıl tasarlarısınız?    
     */
    public class Report 
    {
        public Format Format { get; set; }
    }

    public class  Format
    {
        
    }

    public class HTMLFormat : Format 
    {
    }
    public class PDFFormat : Format 
    {
    }
    public class SalesReport : Report { }
    public class PerformanceReport : Report { }
    //public class PDFSalesReport : SalesReport { }
    //public class PDFPerformanceReport : PerformanceReport { }
    //public class HTMLSalesReport : SalesReport { }
    //public class HTMLPerformanceReport : PerformanceReport { }

}
