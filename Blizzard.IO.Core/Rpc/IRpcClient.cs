﻿using System.Threading.Tasks;

namespace Blizzard.IO.Core.Rpc
{
    public interface IRpcClient
    {
        TRespond Request<TRequest , TRespond>(TRequest request)
        where TRequest:class
        where TRespond:class;
        Task<TRespond> RequestAsync<TRequest , TRespond>(TRequest request)
        where TRequest : class
        where TRespond : class;
    }
}
