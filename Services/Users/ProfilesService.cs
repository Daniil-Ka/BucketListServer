using Microsoft.AspNetCore.Mvc;

namespace BucketListServer.Services.Users;

public class ProfilesService
{
    [HttpGet("name={name}")]
    public Profile GetProfile(string name)
    {
        throw new NotImplementedException();
    }
}