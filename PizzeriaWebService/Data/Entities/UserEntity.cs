namespace PizzeriaWebService.Data;

public class UserEntity
{
  public Guid Id { get; set; }

  public string? PhoneNumber { get; set; }

  public string? PasswordHash { get; set; }

  public string? Salt { get; set; }
}