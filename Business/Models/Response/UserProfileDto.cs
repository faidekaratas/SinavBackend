﻿using Infrastructure.Data.Postgres.Entities;

namespace Business.Models.Response;

public class UserProfileDto
{
    public int Id { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string SurName { get; set; } = default!;
    public string PhoneNumber { get; set; }
    public UserType UserType { get; set; }


}