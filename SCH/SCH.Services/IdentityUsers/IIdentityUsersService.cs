namespace SCH.Services.IdentityUsers
{
    using SCH.Models.Users.ClientDtos;

    public interface IIdentityUsersService
    {
        Task<List<UserDomainDto>> GetBasicOnlyUsersAsync();
    }
}
