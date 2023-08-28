using BLL.Models;

namespace BLL.Services.Contracts
{
    public interface IServiceRequestService
    {


        Task<List<ServiceRequest>> GetServiceRequests();
        Task<ServiceRequest> GetServiceRequestByID(int serviceRequestId);
        void InsertServiceRequest(ServiceRequest serviceRequest);
        void DeleteServiceRequest(int serviceRequestId);
        void UpdateServiceRequest(ServiceRequest serviceRequest);
        Task<List<ServiceRequest>> GetServiceRequestsByType(string type);
    }
}
