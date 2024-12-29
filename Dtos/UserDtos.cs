namespace BookStore_API.Dtos;

public record SignUpDto(
    string Name,
    string Username,
    string Email,
    string Password
);
public record LogInDto(
    // UsedId can be either email or username. That is, users can either use username or email to sign-in
    string UsedId,
    string Password
);