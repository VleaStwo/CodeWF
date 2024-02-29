﻿namespace CodeWF.Auth;

public class Account
{
    public Account()
    {
    }

    public Account(LocalAccountEntity entity)
    {
        if (null == entity)
        {
            return;
        }

        Id = entity.Id;
        CreateTimeUtc = entity.CreateTimeUtc;
        LastLoginIp = entity.LastLoginIp.Trim();
        LastLoginTimeUtc = entity.LastLoginTimeUtc.GetValueOrDefault();
        Username = entity.Username.Trim();
    }

    public Guid Id { get; set; }
    public string Username { get; set; }
    public DateTime? LastLoginTimeUtc { get; set; }
    public string LastLoginIp { get; set; }
    public DateTime CreateTimeUtc { get; set; }
}