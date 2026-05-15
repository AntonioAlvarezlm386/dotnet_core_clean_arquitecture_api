namespace Domain.Entities;

public class HeadOfDepartment : EmployeeBase
{
    public override decimal Salary => base.Salary * 1.015m;
}
