using System;
namespace SecurtyToken.Jwt;

using Microsoft.AspNetCore.Authorization;

public class JwtAuthorize : AuthorizeAttribute
{
    public JwtAuthorize()
    {
        Policy = "JwtToken";
    }
}