using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Genric_Service
{
    public class DBConnectionManager : IDisposable
    {
        private SqlConnection sqlConnection = new SqlConnection();
        public DBConnectionManager()
        {
            SqlConnection.Open();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        public SqlConnection SqlConnection { get => sqlConnection; private set => sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString; }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }
                SqlConnection.Close();
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