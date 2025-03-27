namespace Nxty.Core.Api;

public class RequestId<TKey>
    where TKey : IEquatable<TKey>
{
    public TKey Id { get; init; } = default!;
}
