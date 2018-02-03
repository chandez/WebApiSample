using System;
using System.Data;

namespace HttpRestApi.Core.Infrastructure
{
    public interface IConnectionFactory : IDisposable
    {
        IDbConnection GetConnection { get; }
    }
}
