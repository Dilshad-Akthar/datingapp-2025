using System;
using API.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace API.Entities;

public class AppUser
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    
    public required string DisplayName { get; set; }
    public required string  Email { get; set; }

    public required byte[] PassswordHash { get; set; }
    public required byte[] PassswordSalt { get; set; }

    internal ActionResult<UserDto> ToDto()
    {
        throw new NotImplementedException();
    }
}
