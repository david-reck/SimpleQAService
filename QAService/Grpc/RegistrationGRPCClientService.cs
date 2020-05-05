using Grpc.Net.Client;
using Newtonsoft.Json;
using QAService.Application.Models.DTORaw;
using RegistrationService.API.Grpc;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public Task<Hl7Adt> RegistrationDataById(string documentId, Int64 clientId)
        {
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            var registrationChannel = GrpcChannel.ForAddress(_grpcClientAddress);
            var registrationClient = new RegistrationApiRetrieval.RegistrationApiRetrievalClient(registrationChannel);
            var adtMessageRequest = new AdtMessageRequest { Id = documentId, ClientId = clientId};
            var reply = registrationClient.FindAdtMessageById(adtMessageRequest);

            Hl7Adt message = JsonConvert.DeserializeObject<Hl7Adt>(reply.AdtMessage);

            return Task.FromResult(message);
        }
    }
}
