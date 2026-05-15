namespace Domain.Entities;

public class Teacher : EmployeeBase
{
    public override decimal Salary => base.Salary * 1.02m;
}
