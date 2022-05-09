using LGA.Clima.Data.Properties;

namespace LGA.Clima.Data.Connection
{
    public abstract class DataContext
    {

        public DataContext(string? connectionString)
        {
            if (connectionString == null)
                throw new ArgumentNullException(Resources.CONNECTION_STRING_NULL_EXCEPTION);

            ConnectionString = connectionString;
        }

        public string ConnectionString { get; }

    }
}
