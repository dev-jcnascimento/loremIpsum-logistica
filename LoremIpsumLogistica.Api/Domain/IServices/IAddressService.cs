using LoremIpsumLogistica.Api.Domain.Arguments.Address;

namespace LoremIpsumLogistica.Api.Domain.IServices
{
    public interface IAddressService
    {
        Task<AddressResponse> CreateAsync(CreateAddressRequest request);
        Task<IEnumerable<AddressResponse>> GetAllAsync(int page, int size);
        Task<AddressResponse> GetByIdAsync(Guid id);
        Task<IEnumerable<AddressResponse>> GetByClientIdAsync(Guid clientId);
        Task<AddressResponse> UpdateAsync(UpdateAddressRequest request);
        Task DeleteByIAsync(Guid id);
    }
}
