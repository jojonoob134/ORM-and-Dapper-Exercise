using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    public class Department : IDepartmentRepository
    {
        public int DepartmentId { get; set; }

        public string Name { get; set; }

        public IQueryable<Department> GetAllDepartments()
        {
            throw new NotImplementedException();
        }
    }
}
