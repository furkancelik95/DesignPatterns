// See https://aka.ms/new-console-template for more information
using AbstractFactory;

Console.WriteLine("Hello, World!");
/*
 * Concrete sınıfları bilmeden, nesne aileleri üretmenizi sağlayan tasarım desenidir.
 * 
 * Nesne aileleri: Bir işlem için kullanılan bir arada olması gereken ama birbirinden bağımsız nesneler.
 * 
 */

DbFactoryCreator<MSSQLDbFactory> sqlDbFactory = new DbFactoryCreator<MSSQLDbFactory>();
sqlDbFactory.ExecuteCommand();

Console.WriteLine();

DbFactoryCreator<OracleDbFactory> oracleDbFactory = new DbFactoryCreator<OracleDbFactory>();
oracleDbFactory.ExecuteCommand();