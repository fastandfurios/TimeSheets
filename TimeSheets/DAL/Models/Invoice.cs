﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TimeSheets.DAL.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int NumberInvoice { get; set; }
        public int NumberContract { get; set; }
    }
}
