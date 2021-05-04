using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
   public class Category
    {
        public int Id { get; set; }
        public int SortOrder { get; set; }
        //co hien ra o trang home k
        public bool IsShowOnHome { get; set; }
        public int? ParentId { get; set; }
        public Status Status { get; set; }
        //relationship giua product va category quan he nhieu nhieu
        public virtual IEnumerable<ProductInCategory> ProductInCategories { get; set; }
        public virtual IEnumerable<CategoryTranslation> CategoryTranslations { get; set; }
    }
}
