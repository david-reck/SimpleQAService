using QAService.Application.Models;
using System;
using System.Threading.Tasks;

namespace QAService.Grpc
{
    public interface IRegistrationGRPCClientService
    {
        Task<Adt> RegistrationDataById(string documentId, Int64 clientId);


    }
}

