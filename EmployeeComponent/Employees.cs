
using System.Collections.ObjectModel;


namespace EmployeeComponent
{
    public class Employees
    {
        public ObservableCollection<EmployeeViewModel> GetEmployees()
        {
            //ObservableCollection<EmployeeViewModel> 用于存储一组员工信息，
            //每个员工信息都是一个 EmployeeViewModel 对象，包含了员工的各种属性，如 ID、姓名、性别、年薪等。
            //问题1 这里的泛型好处是什么
            var employees = new ObservableCollection<EmployeeViewModel>();
      
            employees.Add(new EmployeeViewModel
            {
                Id = 1,
                FirstName = "John",
                LastName = "Green",
                AnnualSalary = 40000,
                Gender = 'm',
                IsManager = false
            });
            employees.Add(new EmployeeViewModel
            {
                Id = 2,
                FirstName = "Sally",
                LastName = "Jones",
                AnnualSalary = 55000,
                Gender = 'f',
                IsManager = true
            });
            employees.Add(new EmployeeViewModel
            {
                Id = 3,
                FirstName = "Bill",
                LastName = "Blog",
                AnnualSalary = 30000,
                Gender = 'm',
                IsManager = false
            });
            employees.Add(new EmployeeViewModel
            {
                Id = 4,
                FirstName = "Jamie",
                LastName = "Hopkins",
                AnnualSalary = 80000,
                Gender = 'm',
                IsManager = true
            });

            return employees;
        }
    }
}
