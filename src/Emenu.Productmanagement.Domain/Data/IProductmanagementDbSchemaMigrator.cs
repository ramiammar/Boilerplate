using System.Threading.Tasks;

namespace Emenu.Productmanagement.Data;

public interface IProductmanagementDbSchemaMigrator
{
    Task MigrateAsync();
}
