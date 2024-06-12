using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /*
     * Senaryo:
     * 
     * Karmaşık süreçlerden geçerek (farklı db, dosya okuma gibi) rapor oluşturan bir nesneniz var.
     */

    // 1. Adım: Ne üreteceksiniz? (Product)
    public class Report
    {
        public string Title { get; set; }
        public string Data { get; set; }
        public string Graph { get; set; }
    }

    // 2. Adım: Bu karmaşık aşamaları belirten, interface veya abstract class (Builder)

    public interface IReportBuilder
    {
        void BuildTitle();
        void BuildData();
        void BuildGraph();
        Report GetBuildingReport();
    }

    // 3. Adım: (2. adımdaki) interface'i implemente eden sınıfları oluşturun (ConcreteBuilder)

    public class WeeklySalesReportBuilder : IReportBuilder
    {
        private Report report = new Report();

        public void BuildData()
        {
            report.Data = "Haftalık Satış Verisi";
        }

        public void BuildGraph()
        {
            report.Graph = "Haftalık Satış Grafiği";
        }

        public void BuildTitle()
        {
            report.Title = "Haftalık Satış Raporu";
        }

        public Report GetBuildingReport()
        {
            return report;
        }
    }

    public class WeeklyEmployeePerformanceReportBuilder : IReportBuilder
    {
        private Report report = new Report();

        public void BuildData()
        {
            report.Data = "Haftalık Çalışan Performans Verisi";
        }

        public void BuildGraph()
        {
            report.Graph = "Haftalık Çalışan Performans Grafiği";
        }

        public void BuildTitle()
        {
            report.Title = "Haftalık Çalışan Performans Raporu";
        }

        public Report GetBuildingReport()
        {
            return report;
        }
    }

    // 4. Adım: Product nesnesini düzenli bir biçimde üretecek olan Director sınıfı: (Director)

    public class  ReportBuilderDirector
    {
        public IReportBuilder Builder {get; set;}

        public Report GetReport()
        {
            Builder.BuildTitle();
            Builder.BuildData();
            Builder.BuildGraph();
            return Builder.GetBuildingReport();
        }
    }

}
