using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SimplewebApi.Model
{
    [Table("Product")]     //mapping of table Product with class product
    public class Product
    {
        [Key]   //primary key column
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

    }
}
