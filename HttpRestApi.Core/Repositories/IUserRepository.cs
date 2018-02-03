using System.Collections.Generic;

namespace HttpRestApi.Core.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> Get();
        User Get(int id);
    }
}
