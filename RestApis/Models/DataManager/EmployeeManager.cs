using RestApis.Models.Repository;
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
            throw new NotImplementedException();
        }

        public void Delete(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Employee Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Employee dbEntity, Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
