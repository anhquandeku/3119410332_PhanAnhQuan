﻿using Microsoft.AspNetCore.Mvc.Rendering;
using PayMent.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayMent.Services
{
    public interface IEmployee
    {
        Task CreateAsync(Employee employee);
        Task UpdateAsync(Employee employee);
        Task UpdateById(int id);
        Employee GetById(int id);
        Task Delete(int employeeId);
        IEnumerable<Employee> GetAll();
        decimal UnionFees(int id);
        decimal StudentLoanRepaymentAmount(int id, decimal totalAmount);
        //update 22/11
        IEnumerable<SelectListItem> GetAllEmployeesForPayroll();
    }
}