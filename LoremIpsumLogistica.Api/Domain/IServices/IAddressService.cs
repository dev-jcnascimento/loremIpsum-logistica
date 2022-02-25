namespace LoremIpsumLogistica.Api.Domain.IServices
{
    public interface IAddressService
    {
        Task<AddressResponse> Create(CreateAddressRequest request);
        Task<IEnumerable<AddressResponse>> GetAll(int page, int size);
        Task<AddressResponse> GetById(Guid id);
        Task<IEnumerable<AddressResponse>> GetByClient(Guid clientId);
        Task<AddressResponse> Update(Guid id, UpdateAddressRequest request);
        Task DeleteByI(Guid id);
    }
}
