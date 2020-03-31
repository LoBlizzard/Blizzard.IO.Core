using System;
using System.Threading.Tasks;

namespace Blizzard.IO.Core.Rpc
{
    public interface IRpcServer
    {
        void Respond<TRequest, TRespond>(Func<TRequest, TRespond> callback);
        void RespondAsync<TRequest, TRespond>(Func<TRequest, Task<TRespond>> callback);
    }
}
