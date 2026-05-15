namespace Domain.Entities;

public class DeputyHeadMaster : EmployeeBase
{
    public override decimal Salary => base.Salary * 1.05m;
}
