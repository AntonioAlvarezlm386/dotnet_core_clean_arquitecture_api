using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Delegates.ClubMembership.Models;

public class User
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Incia que esta propiedad sera el id
    public int Id { get; set; }

    public string EmailAddress { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Password { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string PhoneNumber { get; set; }

    public string AddressFirstLine { get; set; }

    public string AddressSecondLine { get; set; }

    public string AddressCity { get; set; }

    public string PostCode { get; set; }

}