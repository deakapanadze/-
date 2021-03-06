using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public DateTime DateOfOutItems { get; set; }
        public string UserName { get; set; }
        public DateTime DateCreated { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int Quantity { get; set; }
        public int StructureID { get; set; }
        public string StructureName { get; set; }
        public string CategoryName { get; set; }
    }
}
