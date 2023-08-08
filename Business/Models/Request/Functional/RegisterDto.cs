namespace Business.Models.Request.Functional;

public class RegisterDto
{
    public string Email { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string SurName { get; set; } = default!;
    public string PhoneNumber { get; set; }
    public string Password { get; set; } = default!;
}