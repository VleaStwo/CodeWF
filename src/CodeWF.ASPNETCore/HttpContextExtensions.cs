﻿using Microsoft.AspNetCore.Http;

namespace CodeWF.ASPNETCore;

public static class HttpContextExtensions
{
    public static string? GetClientIP(this HttpContext context)
    {
        var ip = context.Request.Headers["X-Forwarded-For"].ToString();
        if (string.IsNullOrEmpty(ip))
        {
            ip = context.Connection.RemoteIpAddress?.ToString();
        }

        return ip;
    }
}