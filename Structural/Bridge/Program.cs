﻿// See https://aka.ms/new-console-template for more information
using Bridge;

Console.WriteLine("Hello, World!");

/*
 * is-a miras(inheritance) durumunu, has-a ise özellik durumunu ifade eder.
 * Problem:
 * Bir nesne; geliştirme sürecinde sürekli miras alarak ilerlerse; kaos oluşmaktadır. Bu kaosu nasıl önleriz?
 */

SalesReport salesReport = new SalesReport();
salesReport.Format = new PDFFormat();