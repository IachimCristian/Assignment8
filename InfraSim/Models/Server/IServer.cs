using System.Collections.Generic;
using InfraSim.Models.Capability;
using InfraSim.Models.State;

namespace InfraSim.Models.Server
{
    /// <summary>
    /// Interface for server components that can handle requests
    /// </summary>
    public interface IServer : IServerStateHandler
    {
        ServerType ServerType { get; }
        IServerCapability ServerCapability { get; }
        int RequestsCount { get; set; }
        
        /// <summary>
        /// Handles a specified number of requests
        /// </summary>
        /// <param name="requestsCount">The number of requests to handle</param>
        void HandleRequests(int requestsCount);
    }
} 