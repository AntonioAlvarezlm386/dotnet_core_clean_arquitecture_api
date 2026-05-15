using Domain.Entities;
using Domain.Enums;
using Domain.Factories;
using MediatR;

namespace Application.Employees.Queries;

public record GetEmployeesSalaryQuery() : IRequest<decimal>;

public class GetEmployeesSalaryQueryHandler : IRequestHandler<GetEmployeesSalaryQuery, decimal>
{
    public async Task<decimal> Handle(GetEmployeesSalaryQuery request, CancellationToken cancellationToken)
    {
        decimal totalSalaries = 0;
        List<IEmployee> employees = new();

        SeedData(employees);

        totalSalaries = employees.Sum(e => e.Salary);

        return totalSalaries;
    }

    public void SeedData(List<IEmployee> employees)
    {
        employees.AddRange(new IEmployee[]
        {
            EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 1, "Juan", "Pérez", 2500m),
            EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadMaster, 2, "María", "García", 4500m),
            EmployeeFactory.GetEmployeeInstance(EmployeeType.DeputyHeadMaster, 3, "Carlos", "López", 3800m),
            EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadOfDepartment, 4, "Ana", "Martínez", 3500m),
            EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 5, "Luis", "Rodríguez", 2600m),
        });
    }
}
