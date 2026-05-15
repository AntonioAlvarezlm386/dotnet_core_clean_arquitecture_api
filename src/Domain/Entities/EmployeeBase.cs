namespace Domain.Entities;

public abstract class EmployeeBase : IEmployee
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public virtual decimal Salary { get; set; }
}
