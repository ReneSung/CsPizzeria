namespace PizzeriaWebService.Data;

public class UserEntity
{
  private Guid Id { get; set; }
  
  private string? PhoneNumber { get; set; }
  
  private string? PasswordHash { get; set; }
  
  private string? Salt { get; set; }
}