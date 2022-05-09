
namespace LGA.Clima.Data.Connection
{
    public class DbClimaDataContext : DataContext
    {
        public DbClimaDataContext(ConnectionStrings connectionStrings) : base(connectionStrings.DbClima) { }

    }
}
