using EntityInterface.Core;

namespace EntityInterface.SqliteAdapter;

public static class EntityInterfaceOptionsExtension
{
    public static void UseSqliteAdapter(this EntityInterfaceOptions options, string connectionString)
    {
        IEntityInterfaceDataProvider provider = new SqliteDataProvider(connectionString);

        options.SetDataProvider(provider);
    }
}