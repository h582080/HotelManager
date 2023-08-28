using DAL.DataContext;
using BLL.Models;
using DAL.Repositories.Contracts;
using AutoMapper;
using BLL.Services.Contracts;


namespace BLL.Services
{
    public class ServiceRequestService : IServiceRequestService
    {
        private IServiceRequestRepository _serviceRequestRepository;
        private Mapper _mapper;

        public ServiceRequestService()
        {
            this._serviceRequestRepository = new ServiceRequestRepository(new HotelContext());
            var _config = new MapperConfiguration(cfg => cfg.CreateMap<DAL.Models.ServiceRequest, ServiceRequest>().ReverseMap());
            _mapper = new Mapper(_config);
        }

        public async Task<List<ServiceRequest>> GetServiceRequests()
        {
            return  _mapper.Map<List<DAL.Models.ServiceRequest>,List<ServiceRequest>> (await _serviceRequestRepository.GetServiceRequests());
        }

        public async Task<ServiceRequest> GetServiceRequestByID(int id)
        {
            return _mapper.Map<DAL.Models.ServiceRequest,ServiceRequest>(await _serviceRequestRepository.GetServiceRequestByID(id));
        }


        public async Task<List<ServiceRequest>> GetServiceRequestsByType(string type)
        {
            return _mapper.Map<List<DAL.Models.ServiceRequest>, List<ServiceRequest>> (await _serviceRequestRepository.GetServiceRequestsByType(type));
        }
        public void InsertServiceRequest(ServiceRequest serviceRequest)
        {
            try
            {
                var s = _mapper.Map<ServiceRequest, DAL.Models.ServiceRequest>(serviceRequest);

                _serviceRequestRepository.InsertServiceRequest(s);
                _serviceRequestRepository.Save();
            }
            catch
            {
                throw;
            }
        }
        public void DeleteServiceRequest(int id)
        {
            try
            {
                _serviceRequestRepository.DeleteServiceRequest(id);
                _serviceRequestRepository.Save();
            }
            catch
            {
                throw;
            }

        }

        public void UpdateServiceRequest(ServiceRequest serviceRequest)
        {
            try
            {
                var s = _mapper.Map<ServiceRequest, DAL.Models.ServiceRequest>(serviceRequest);
                _serviceRequestRepository.UpdateServiceRequest(s);
                _serviceRequestRepository.Save();
            }
            catch
            {
                throw;
            }

        }

     
    }
}
