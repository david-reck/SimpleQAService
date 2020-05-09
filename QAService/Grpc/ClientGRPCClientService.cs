using ClientService.API.Grpc;
using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QAService.Grpc
{
    public class ClientGRPCClientService : IClientGRPCClientService
    {
        private string _grpcClientAddress;
        private string _moduleCode;
            public ClientGRPCClientService(string address, string module)
        {
            _grpcClientAddress = address;
            _moduleCode = module;
        }
        public Task<bool> ClientFacilitySubscribesToModule(Int64 clientId, string facilityCode)
        {
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            var clientChannel = GrpcChannel.ForAddress(_grpcClientAddress);
            var clientClient = new ClientApiRetrieval.ClientApiRetrievalClient(clientChannel);
            var modulesRequest = new ModulesRequest { ClientId = clientId, FacilityCode = facilityCode };
            var clientServieReply = clientClient.FindModulesByClientIdAndFacilityCode(modulesRequest);

            foreach (Modules m in clientServieReply.Data) 
            {
                if (m.ModuleCode == _moduleCode) { return Task.FromResult(true); }
            }

            return Task.FromResult(false);
        }

        public Task<bool> ClientFacilitySubscribesToModuleByFacilityId(Int64 clientId, Int64 facilityId)
        {
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            var clientChannel = GrpcChannel.ForAddress(_grpcClientAddress);
            var clientClient = new ClientApiRetrieval.ClientApiRetrievalClient(clientChannel);
            var modulesRequest = new ModuleFacilityIdRequest { ClientId = clientId, FacilityId = facilityId };
            var clientServieReply = clientClient.FindModulesByClientIdAndFacilityId(modulesRequest);

            foreach (Modules m in clientServieReply.Data)
            {
                if (m.ModuleCode == _moduleCode) { return Task.FromResult(true); }
            }

            return Task.FromResult(false);
        }
    }
}
