using System.Diagnostics.CodeAnalysis;

namespace Core.Infrastructure;

[SuppressMessage("Naming", "S2326:Unused type parameters should be removed",
    Justification = "Required for this interface.")]
public interface IQuery<TResult>
{
}