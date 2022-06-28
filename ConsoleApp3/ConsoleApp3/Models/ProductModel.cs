using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Models
{
    public class ProductModel : IEntity
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public string RowGuid { get; set; } = Guid.NewGuid().ToString();
    }
}
