using QAService.Application.Models.DTORaw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QAService.Grpc
{
    public interface IRegistrationGRPCClientService
    {
        Task<Hl7Adt> RegistrationDataById(string documentId, Int64 clientId);
    }
}

