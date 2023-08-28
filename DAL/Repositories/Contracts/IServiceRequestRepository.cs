using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Contracts
{
    public interface IServiceRequestRepository : IDisposable
    {


        Task<List<ServiceRequest>> GetServiceRequests();
        Task<ServiceRequest> GetServiceRequestByID(int serviceRequestId);
        void InsertServiceRequest(ServiceRequest serviceRequest);
        void DeleteServiceRequest(int serviceRequestId);
        void UpdateServiceRequest(ServiceRequest serviceRequest);
        Task<List<ServiceRequest>> GetServiceRequestsByType(string type);

        void Save();
    }
}
