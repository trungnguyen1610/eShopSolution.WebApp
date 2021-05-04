using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    //su dung fluent API Configuration thay vi Attribute [table]
    public class Product
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        //ngay tao
        public DateTime DateCreate { get; set; }
        //khoa seo
     
        public string SeoAlias { get; set; }
        //relationship giua product va category quan he nhieu nhieu
        public virtual IEnumerable<ProductInCategory> ProductInCategories { get; set; }
        public virtual IEnumerable<Cart> Carts { get; set; }
        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
        public virtual IEnumerable<ProductTranslation> ProductTranslations { get; set; }

    }
}
