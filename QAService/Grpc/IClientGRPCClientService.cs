using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QAService.Grpc
{
    public interface IClientGRPCClientService
    {
        Task<bool> ClientFacilitySubscribesToModule(Int64 clientId, string facilityCode);
        Task<bool> ClientFacilitySubscribesToModuleByFacilityId(Int64 clientId, Int64 facilityId);
    }
}
