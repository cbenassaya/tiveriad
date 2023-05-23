using System;

namespace Tiveriad.Repositories;

public interface IWithTenant
{

}
public interface IWithTenant<TKey>  :IWithTenant where TKey : IEquatable<TKey>
{
    /// <summary>
    /// Id of the related tenant.
    /// </summary>
    public TKey TenantId { get; set; }
}

