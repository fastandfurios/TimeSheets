﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TimeSheets.DAL.Models;

namespace TimeSheets.DTO
{
    public class JobEmployeeDto
    {
        public int Id { get; set; } 
        [JsonIgnore] public int EmployeeIDJ { get; set; }
        public string CustomerName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public IList<TimeSheetDto> TimeSheets { get; set; }
    }
}