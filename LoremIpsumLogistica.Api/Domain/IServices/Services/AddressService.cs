using LoremIpsumLogistica.Api.Domain.Arguments.Address;
using LoremIpsumLogistica.Api.Domain.Entities;
using LoremIpsumLogistica.Api.Domain.Enums;
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
            var client = ExistClient(request.ClientId);
            if (client == null) throw new ValidationException("Id Player not Exist!");
            var address = new Address(
              request.ClientId,
              ValidationTypeAddress(request.TypeAddress),
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

            var result = _addressRepository.GetAllAddress(pageSize, offset);
            return result.Select(x => (AddressResponse)x).ToList();
        }
        public async Task<AddressResponse> GetByIdAsync(Guid id)
        {
            var address = await ExistAddress(id);
            return (AddressResponse)address;
        }
        public async Task<IEnumerable<AddressResponse>> GetByClientIdAsync(Guid clientId)
        {
            var client = ExistClient(clientId);
            if (client == null) return null;
            var result = await _addressRepository.GetByClientId(clientId);
            return result.Select(x => (AddressResponse)x).ToList();
        }
        public async Task<AddressResponse> UpdateAsync(UpdateAddressRequest request)
        {
            var client = ExistClient(request.ClientId);
            if (client == null) throw new ValidationException("Id Player not Exist!");

            var address = await ExistAddress(request.Id);
            address.Update(
              ValidationTypeAddress(request.TypeAddress),
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
        private object ExistClient(Guid id)
        {
            var client =  _clientRepository.GetById(id);
            if (client == null) return null;
            return client;
        }
        private TypeAddress ValidationTypeAddress(string genre)
        {
            var result = TypeAddress.Unidentified;
            if (genre.ToUpper().Equals(TypeAddress.Commercial.ToString().ToUpper())) result = TypeAddress.Commercial;
            if (genre.ToUpper().Equals(TypeAddress.Residential.ToString().ToUpper())) result = TypeAddress.Residential;
            return result;
        }
        private int ParseInt(string requestString)
        {
            var parceInt = int.Parse(requestString);
            return parceInt;
        }
    }
}
