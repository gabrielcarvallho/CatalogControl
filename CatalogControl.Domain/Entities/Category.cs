﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CatalogControl.Domain.Entities
{
    public class Category : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [JsonIgnore]
        public ICollection<Product>? Products { get; set; }
    }
}