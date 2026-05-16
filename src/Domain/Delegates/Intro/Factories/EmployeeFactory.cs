using Domain.Entities;
using Domain.Enums;

namespace Domain.Factories;

public static class EmployeeFactory
{
    public static IEmployee GetEmployeeInstance(EmployeeType employeeType, int id, string firstName, string lastName,
        decimal salary)
    {
        IEmployee employee = null!;
        switch (employeeType)
        {
            case EmployeeType.Teacher:
                employee = FactoryPattern<IEmployee, Teacher>.GetInstance();
                break;
            case EmployeeType.DeputyHeadMaster:
                employee = FactoryPattern<IEmployee, DeputyHeadMaster>.GetInstance();
                break;
            case EmployeeType.HeadOfDepartment:
                employee = FactoryPattern<IEmployee, HeadOfDepartment>.GetInstance();
                break;
            case EmployeeType.HeadMaster:
                employee = FactoryPattern<IEmployee, HeadMaster>.GetInstance();
                break;
        }

        if (employee is not null)
        {
            employee.Salary = salary;
            employee.Id = id;
            employee.Name = firstName;
            employee.LastName = lastName;
        }
        else
        {
            throw new ArgumentException($"Employee type {employeeType} not found");
        }

        return employee;
    }
}
