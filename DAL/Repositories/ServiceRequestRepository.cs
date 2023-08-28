using DAL.DataContext;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Contracts
{
    public class ServiceRequestRepository: IServiceRequestRepository, IDisposable
    {
        private HotelContext context;

        public  ServiceRequestRepository(HotelContext context)
        {
            this.context = context;
        }

        public async Task<List<ServiceRequest>> GetServiceRequests()
        {
            using (var context = new HotelContext())
            {
                return await context.ServiceRequests.ToListAsync();
            }
       
        }

        public async Task<ServiceRequest> GetServiceRequestByID(int id)
        {
            return await  context.ServiceRequests.FindAsync(id);
        }

        public void InsertServiceRequest( ServiceRequest  serviceRequest)
        {
            context.ServiceRequests.Add( serviceRequest);
        }

        public void DeleteServiceRequest(int  serviceRequestID)
        {
             ServiceRequest  serviceRequest = context. ServiceRequests.Find( serviceRequestID);
            context.ServiceRequests.Remove( serviceRequest);
        }

        public void UpdateServiceRequest( ServiceRequest  serviceRequest)
        {
            var entity = context.ServiceRequests.Find(serviceRequest.ServiceRequestId);
            context.Entry(entity).State = EntityState.Detached;
            context.Entry(serviceRequest).State = EntityState.Modified;
        }

        public async Task<List<ServiceRequest>> GetServiceRequestsByType(string type)
        {
            return await context.ServiceRequests.Where(sr => sr.ServiceType == type).ToListAsync(); 
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
