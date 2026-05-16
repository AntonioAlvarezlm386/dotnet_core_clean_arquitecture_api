namespace Domain.Entities;

public class HeadMaster : EmployeeBase
{
    public override decimal Salary => base.Salary * 1.03m;
}
