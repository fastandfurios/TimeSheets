﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheets.DAL.Models;
using TimeSheets.DTO;

namespace TimeSheets.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<bool> RegisterEmployee(Employee employee);
        Task<IEnumerable<Employee>> GetAllEmployee();
        Task<JobDto> GetJobEmployee(int id, int idJ);
        Task<IEnumerable<JobDto>> GetJobsEmployee(int id);
        Task<Job> GetJob(int id);
        Task<IEnumerable<Job>> GetJobs();
        Task<bool> ChangeEmployee(int id, Employee employee);
        Task<JobDto> ChangeTimeSheet(int id, TimeSheet timeSheet);
        Task<bool> DeleteEmployee(int id);
    }
}
