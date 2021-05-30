﻿using RestApis.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApis.Models.DataManager
{
    public class EmployeeManager : IDataRepository<Employee>

    {
        readonly EmployeeContext _employeeContext;

        public EmployeeManager (EmployeeContext context)
        {
            _employeeContext = context;
        }
        public void Add(Employee entity)
        {
            _employeeContext.Employees.Add(entity);
            _employeeContext.SaveChanges();
        }

        public void Delete(Employee entity)
        {
            _employeeContext.Employees.Remove(entity);
            _employeeContext.SaveChanges();
        }

        public Employee Get(long id)
        {
            return _employeeContext.Employees.FirstOrDefault(e => e.EmployeeId == id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employeeContext.Employees.ToList();
        }

        public void Update(Employee employee, Employee entity)
        {
            employee.FirstName = entity.FirstName;
            employee.LastName = entity.LastName;
            employee.Email = entity.Email;
            employee.DOB = entity.DOB;
            employee.PhoneNumber = entity.PhoneNumber;

            _employeeContext.SaveChanges();
        }
    }
}
