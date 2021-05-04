using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Language
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public bool IsDefault { get; set; }
        //language co the co nhieu product danh muc
        public virtual IEnumerable<ProductTranslation> ProductTranslations { get; set; }
        //chua nhieu category danh muc
        public virtual IEnumerable<CategoryTranslation> CategoryTranslations { get; set; }

    }
}
