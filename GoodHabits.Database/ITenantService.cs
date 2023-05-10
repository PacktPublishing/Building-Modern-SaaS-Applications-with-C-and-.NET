namespace GoodHabits.Database;
public interface ITenantService
{
    public string GetConnectionString();
    public Tenant GetTenant();
}
