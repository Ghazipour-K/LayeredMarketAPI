//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Market.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShoppingCardTable
    {
        public string CID { get; set; }
        public string PID { get; set; }
        public string SID { get; set; }
        public int Quantity { get; set; }
        public System.DateTime PurchasedDate { get; set; }
    
        public virtual CustomerTable CustomerTable { get; set; }
        public virtual DistributionScheduleTable DistributionScheduleTable { get; set; }
        public virtual ProductTable ProductTable { get; set; }
    }
}