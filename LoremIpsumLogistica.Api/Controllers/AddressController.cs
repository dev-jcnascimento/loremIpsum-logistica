using LoremIpsumLogistica.Api.Domain.Arguments.Address;
using LoremIpsumLogistica.Api.Domain.Arguments.Hateoas;
using LoremIpsumLogistica.Api.Domain.IServices;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LoremIpsumLogistica.Api.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/addresses/v{version:apiVersion}")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;
        private readonly IUrlHelper _urlHelper;

        public AddressController(IAddressService addressService, IUrlHelper urlHelper)
        {
            _addressService = addressService;
            _urlHelper = urlHelper;
        }

        [HttpPost]
        public async Task<ActionResult<AddressResponse>> CreateAsync(CreateAddressRequest request)
        {
            try
            {
                var address = await _addressService.CreateAsync(request);

                GerarLinks(address);

                return StatusCode(201, address);
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AddressResponse>>> GetAllAsync(int? page, int? size)
        {
            var address = await _addressService.GetAllAsync((int)page, (int)size);

            address.ToList().ForEach(c => GerarLinks(c));

            return Ok(address);
        }

        [HttpGet("{id}", Name = nameof(GetByIdAsync))]
        public async Task<ActionResult> GetByIdAsync(Guid id)
        {
            try
            {
                var address = await _addressService.GetByIdAsync(id);

                GerarLinks(address);

                return Ok(address);
            }
            catch (ValidationException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("getByClientId")]
        public async Task<ActionResult<IEnumerable<AddressResponse>>> GetByClientIdAsync(Guid clientId)
        {
            try
            {
                var address = await _addressService.GetByClientIdAsync(clientId);

                address.ToList().ForEach(c => GerarLinks(c));

                return Ok(address);
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut(Name = nameof(UpdateAsync))]
        public async Task<ActionResult<AddressResponse>> UpdateAsync(UpdateAddressRequest request)
        {
            try
            {
                var address = await _addressService.UpdateAsync(request);
                return Ok(address);
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
            return NoContent();
        }

        [HttpDelete("{id}", Name = nameof(DeleteByIAsync))]
        public async Task<ActionResult> DeleteByIAsync(Guid id)
        {
            try
            {
                await _addressService.DeleteByIAsync(id);
            }
            catch (ValidationException ex)
            {
                return NotFound(ex.Message);
            }
            return NoContent();
        }
        private void GerarLinks(AddressResponse address)
        {
            address.Links.Add(new LinkDTO(_urlHelper.Link(nameof(GetByIdAsync), new { id = address.Id }), rel: "self-address", metodo: "GET"));
            address.Links.Add(new LinkDTO(_urlHelper.Link(nameof(UpdateAsync), new { id = address.Id }), rel: "update-address", metodo: "PUT"));
            address.Links.Add(new LinkDTO(_urlHelper.Link(nameof(DeleteByIAsync), new { id = address.Id }), rel: "delete-address", metodo: "DELETE"));
        }

    }
}

