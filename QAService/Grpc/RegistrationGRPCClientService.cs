using Grpc.Core;
using Grpc.Net.Client;
using Newtonsoft.Json;
using QAService.Application.Models;
using RegistrationService.API.Grpc;
using System;
using System.Threading.Tasks;

namespace QAService.Grpc
{
    public class RegistrationGRPCClientService : IRegistrationGRPCClientService
    {
        private string _grpcClientAddress;
        public RegistrationGRPCClientService(string address)
        {
            _grpcClientAddress = address;
        }



        public Task<Adt> RegistrationDataById(string documentId, Int64 clientId)
        {
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            var registrationChannel = GrpcChannel.ForAddress(_grpcClientAddress);
            var registrationClient = new RegistrationApiRetrieval.RegistrationApiRetrievalClient(registrationChannel);
            var adtMessageRequest = new AdtMessageRequest { Id = documentId, ClientId = clientId};
            var reply = registrationClient.FindAdtMessageById(adtMessageRequest);

            Adt message = JsonConvert.DeserializeObject<Adt>(reply.AdtMessage);

            return Task.FromResult(message);
        }

       
    }
}
