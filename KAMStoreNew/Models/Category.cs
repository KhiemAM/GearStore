﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KAMStoreNew.Models
{
    public class Category
    {
        [Key]
        public long CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}