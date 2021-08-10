﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheets.DAL.Models;
using TimeSheets.Responses.DTO;

namespace TimeSheets.DAL.Interfaces
{
    public interface IContractsRepository
    {
        IEnumerable<ContractDto> AddContracts(Contract contract);
        IEnumerable<ContractDto> GetAllContracts();
        IEnumerable<ContractDto> DeleteContracts(int id);
    }
}