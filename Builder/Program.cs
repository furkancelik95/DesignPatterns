// See https://aka.ms/new-console-template for more information
using Builder;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 * 
 * Oluşturulması için birçok aşamadan geçmesi gereken; kompleks bir nesneniz var. Bu nesneniz geliştirilebilir bir nesne olmasını gerekiyor.
 * Bu aşamaları nasıl stabil (tüm implementasyonlarda aynı olacak biçimde) hale getirirsiniz
 */

ReportBuilderDirector director = new ReportBuilderDirector();
director.Builder = new WeeklyEmployeePerformanceReportBuilder();

var report = director.Builder.GetBuildingReport();