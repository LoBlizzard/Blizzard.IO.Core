using System.Threading.Tasks;

namespace Blizzard.IO.Core.Rpc
{
    public interface IRpcClient
    {
        TRes Request<TReq, TRes>(TReq request);
        Task<TRes> RequestASync<TReq, TRes>(TReq request);
    }
}
