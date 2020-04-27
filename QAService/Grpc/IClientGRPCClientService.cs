using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QAService.Grpc
{
    public interface IClientGRPCClientService
    {
        Task<bool> ClientFacilitySubscribesToModule(int clientId, string facilityCode);
    }
}
