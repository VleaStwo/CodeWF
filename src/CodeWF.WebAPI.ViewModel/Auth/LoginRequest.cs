﻿namespace CodeWF.WebAPI.ViewModel.Auth;

public record LoginRequest(string UserName, string Password, bool? AutoLogin, string? Type);

public class LoginRequestType
{
    public const string Account = "account";
    public const string Mobile = "mobile";
}