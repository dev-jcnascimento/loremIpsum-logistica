using LoremIpsumLogistica.Api.Domain.Arguments.Address;
using LoremIpsumLogistica.Api.Domain.Entities;
using LoremIpsumLogistica.Api.Infra.Persistence.IRepositories;
using System.ComponentModel.DataAnnotations;

namespace LoremIpsumLogistica.Api.Domain.IServices.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IClientRepository _clientRepository;

        public AddressService(IAddressRepository addressRepository, IClientRepository clientRepository)
        {
            _addressRepository = addressRepository;
            _clientRepository = clientRepository;
        }

        public async Task<AddressResponse> CreateAsync(CreateAddressRequest request)
        {
            var address = new Address(
              request.ClientId,
              request.TypeAddress,
              request.ZipCode,
              request.Place,
              request.Number,
              request.Complement,
              request.District,
              request.State);
            var result = await _addressRepository.Create(address);
            return (AddressResponse)result;
        }
        public async Task<IEnumerable<AddressResponse>> GetAllAsync(int page, int size)
        {
            var pageSize = (size < 1) ? 10 : size;
            var offset = page > 0 ? (page - 1) * pageSize : 0;

            string query = @"select * from address ";
            query += $" limit {size} offset {offset}";

            return (IEnumerable<AddressResponse>)_addressRepository.GetAll(query);
        }
        public async Task<AddressResponse> GetByIdAsync(Guid id)
        {
            var address = await ExistAddress(id);
            return (AddressResponse)address;
        }
        public async Task<IEnumerable<AddressResponse>> GetByClientIdAsync(Guid clientId)
        {
            await ExistClient(clientId);
            var result = await _addressRepository.GetByClientId(clientId);
            return (IEnumerable<AddressResponse>)result;
        }
        public async Task<AddressResponse> UpdateAsync(UpdateAddressRequest request)
        {
            var address = await ExistAddress(request.Id);
            address.Update(
              request.TypeAddress,
              request.ZipCode,
              request.Place,
              request.Number,
              request.Complement,
              request.District,
              request.State);

            var result = await _addressRepository.Update(address);
            return (AddressResponse)result;
        }
        public async Task DeleteByIAsync(Guid id)
        {
            var address = await ExistAddress(id);
            await _addressRepository.Delete(address);
        }
        private async Task<Address> ExistAddress(Guid id)
        {
            var address = await _addressRepository.GetById(id);
            if (address == null) throw new ValidationException("Id Address not Found!");
            return address;
        }
        private async Task ExistClient(Guid id)
        {
            var client = await _clientRepository.GetById(id);
            if (client == null) throw new ValidationException("Id Client not Found!");
        }
    }
}
