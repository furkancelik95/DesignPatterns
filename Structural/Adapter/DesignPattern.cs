using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /*
     * Senaryo:
     * Bir dış kaynaktan ürünlerinizi çekiyorsunuz.
     * Bu dış kaynak size XML formatında veri gönderiyor.
     * Fakat sizin List<Product>'a ihtiyacınız var.
     */

    public class Product
    {

    }

    // 1. Adım: İstemcinin erişeceği Adaptör interface'i oluşturulur.
    public interface IProductCollectionAdapter
    {
        List<Product> GetProductsFromSource();
    }

    // 2. Adım: Adapte edilecek kaynak:
    public class XmlSource : IProductCollectionAdapter
    {
        public List<Product> GetProductsFromSource()
        {
            Console.WriteLine("XML verisi, objeye dönüştürüldü");
            return new List<Product>();
        }
    }

    public class ProductListAdapter : IProductCollectionAdapter
    {
        private readonly XmlSource source;

        public ProductListAdapter(XmlSource source)
        {
            this.source = source;
        }

        public List<Product> GetProductsFromSource()
        {
            return source.GetProductsFromSource();
        }
    }

}
