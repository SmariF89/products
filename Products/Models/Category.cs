﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Products.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string description { get; set; }
    }
}