using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DF984515MIS4200.Models
{
    public class OrderDetails
    {
        public int orderdetailsID { get; set; }
        public int qtyOrdered { get; set; }
        public decimal price { get; set; }
        public int orderID { get; set; }
        public virtual Orders Order { get; set; }
        public int productID { get; set; }
        public virtual Products Product { get; set; }
    }
}