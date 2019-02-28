//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HomeFoodies.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int OrderID { get; set; }
        public string OrderNo { get; set; }
        public System.DateTime OrderDate { get; set; }
        public int CustomerID { get; set; }
        public int CurrentStatusID { get; set; }
        public double TotalOrderAmount { get; set; }
        public double CommisionPercentage { get; set; }
        public bool IsCustomerConfirmed { get; set; }
        public bool IsSupplierConfirmed { get; set; }
        public string VerificationCode { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual StatusCode StatusCode { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
