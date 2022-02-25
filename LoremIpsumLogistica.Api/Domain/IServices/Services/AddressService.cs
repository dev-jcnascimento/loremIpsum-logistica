using LoremIpsumLogistica.Api.Domain.Arguments.Address;

namespace LoremIpsumLogistica.Api.Domain.IServices.Services
{
    public class AddressService : IAddressService
    {
        public Task<AddressResponse> Create(CreateAddressRequest request)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<AddressResponse>> GetAll(int page, int size)
        {
            throw new NotImplementedException();
        }
        public Task<AddressResponse> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<AddressResponse>> GetByClient(Guid clientId)
        {
            throw new NotImplementedException();
        }
        public Task<AddressResponse> Update(UpdateAddressRequest request)
        {
            throw new NotImplementedException();
        }
        public Task DeleteByI(Guid id)
        {
            throw new NotImplementedException();
        }

    }
}
