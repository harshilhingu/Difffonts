using System;
using System.ComponentModel.DataAnnotations;

namespace Difffonts.Models
{
    public class FontsModel
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public  string cornerrounding { get; set; }
        public string weight { get; set; }
        public decimal Price { get; set; }
    }
}