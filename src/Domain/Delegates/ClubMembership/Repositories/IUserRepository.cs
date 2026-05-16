using Domain.Delegates.ClubMembership.Models;

namespace Domain.Delegates.ClubMembership.Repositories;

public interface IUserRepository : IRepository<User>
{
    Task<User?> GetByEmailAsync(string email);
    Task<bool> EmailExistsAsync(string email);
}
