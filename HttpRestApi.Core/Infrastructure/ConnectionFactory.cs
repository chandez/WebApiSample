using System.Data;

namespace HttpRestApi.Core.Infrastructure
{
    public class ConnectionFactory : IConnectionFactory
    {
        IDbConnection _connection;

        public ConnectionFactory(IDbConnection connection)
        {
            _connection = connection;
        }

        public IDbConnection GetConnection
        {
            get
            {                
                _connection.Open();
                return _connection;
            }
        }

        #region IDisposable Support
        private bool disposedValue = false;

        public virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    //_connection = null;
                    //throw new NotImplementedException();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}
