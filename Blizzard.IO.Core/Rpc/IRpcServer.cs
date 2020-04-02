using System;
using System.Threading.Tasks;

namespace Blizzard.IO.Core.Rpc
{
    public interface IRpcServer
    {
        void Respond<TRequest, TRespond>(Func<TRequest, TRespond> callback)
        where TRequest : class
        where TRespond : class;

        void RespondAsync<TRequest, TRespond>(Func<TRequest, Task<TRespond>> callback)
        where TRequest : class
        where TRespond : class;

        void Stop();
    }
}
