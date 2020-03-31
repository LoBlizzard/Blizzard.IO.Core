using System;
using System.Threading.Tasks;

namespace Blizzard.IO.Core.Rpc
{
    public interface IRpcServer
    {
        void Respond<TReq, TRes>(Func<TReq, TRes> callback);
        void RespondAsync<TReq, TRes>(Func<TReq, Task<TRes>> callback);
    }
}
