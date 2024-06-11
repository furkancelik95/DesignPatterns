using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /*
     * Bir uygulama ADO.NET ile db ile konuşamktadır. DB sağlayıcısı Oracle vs MSSQL'dir.
     * Bu durumda hangi nesneler ile çalışacağımızı BELİRTMEDEN doğru business nesnelerini nasıl üretebiliriz?
     */

    // 1. Adım: Nesne ailesinin elementlerini, önce interface olarak tanımla:
    public interface IConnection
    {
        void Open();
        void Close();
    }

    public interface ICommand
    {
        void Execute();
    }

    // 2. Adım: Elementleri somut nesnelere dönüştür.

    public class MssqlConnection : IConnection
    {
        public void Open()
        {
            Console.WriteLine("MS SQL bağlantısı açıldı.");
        }

        public void Close()
        {
            Console.WriteLine("MS SQL bağlantısı kapandı.");
        }
    }
    public class OracleConnection : IConnection
    {
        public void Open()
        {
            Console.WriteLine("Oracle bağlantısı açıldı.");
        }

        public void Close()
        {
            Console.WriteLine("Oracle bağlantısı kapandı.");
        }
    }

    public class MSSqlCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("MS SQL komutu çalıştırıldı.");
        }
    }

    public class OracleCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Oracle komutu çalıştırıldı.");
        }
    }

    // 3. Adım: Bu somut nesneleri "aile" olarak bir arada oluşturan Factory tasarla:

    public interface IDbFactory
    {
        IConnection CreateConnection();
        ICommand CreateCommand();
    }

    public class MSSQLDbFactory : IDbFactory
    {
        public IConnection CreateConnection()
        {
            return new MssqlConnection();
        }

        public ICommand CreateCommand()
        {
            return new MSSqlCommand();
        }
    }

    public class OracleDbFactory : IDbFactory
    {
        public IConnection CreateConnection()
        {
            return new OracleConnection();
        }

        public ICommand CreateCommand()
        {
            return new OracleCommand();
        }
    }

    // 4. Adım: Factory'yi kullanarak nesneleri üret:

    public class DbFactoryCreator<T> where T : class, IDbFactory, new()
    {
        private T factory = new T();

        public void ExecuteCommand()
        {
            var connection = factory.CreateConnection();
            var command = factory.CreateCommand();
            connection.Open();
            command.Execute();
            connection.Close();
        }
    }
}
