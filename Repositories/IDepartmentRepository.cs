﻿using Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IDepartmentRepository
    {
        List<Department> GetDepartments();
        void AddDepartment(Department department);
        void UpdateDepartment(Department department);
        void DeleteDepartment(Department department);
        public List<Employee> GetEmployeesByDepartmentId(int departmentId);
    }
}
