﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TimeSheets.DAL.Models
{
    public class Employee
    {
        [JsonIgnore] public int Id { get; set; }
        public string FullName { get; set; }
        [JsonIgnore] public bool IsDeleted { get; set; }
    }
}
