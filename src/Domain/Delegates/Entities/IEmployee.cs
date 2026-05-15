namespace Domain.Entities;

public interface IEmployee
{
    int Id { get; set; }
    string Name { get; set; }
    string LastName { get; set; }
    decimal Salary { get; set; }
}
