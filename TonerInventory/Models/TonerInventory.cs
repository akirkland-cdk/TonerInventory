using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TonerInventory.Models
{
    public class TonerDetails
    {
        public string TonerName { get; set; }
        public short QuantityOnHand { get; set; }
        public short ReorderQuantity { get; set; }
        public short NumberOfPrinters { get; set; }
        public bool Active { get; set; }
        public int CostPerToner { get; set; }
    }
}