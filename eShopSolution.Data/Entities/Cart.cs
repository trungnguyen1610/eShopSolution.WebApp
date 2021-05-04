using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Cart
    {
        public int Id { set; get; }
        public int ProductId { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }
        //Thuộc tính Id là một mã định danh duy nhất, Guid là kiểu bao gồm các chuỗi bao gồm chữ cái và số dài như 43ec09f2-7f70-4f4b-9559-65011d5781bb.Vì các Guid là ngẫu nhiên và khó có thể trùng lặp nên chúng thường được sử dụng làm ID.
        public Guid UserId { get; set; }

        public virtual Product Product { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
