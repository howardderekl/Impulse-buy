using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Impulsebuy.Db.Catalog.Models
{
    public class Brand
    {
        public string Name { get; set; }
        public string SeoTitle { get; set; }
        [StringLength(5000)]
        public string Description { get; set; }
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }
    }
}
