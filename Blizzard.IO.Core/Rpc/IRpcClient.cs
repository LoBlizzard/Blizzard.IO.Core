using System.Threading.Tasks;

namespace Blizzard.IO.Core.Rpc
{
    public interface IRpcClient
    {
        TRespond Request<TRequest , TRespond>(TRequest request);
        Task<TRespond> RequestASync<TRequest , TRespond>(TRequest request);
    }
}
