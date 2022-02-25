using LoremIpsumLogistica.Api.Domain.Arguments.Client;
using LoremIpsumLogistica.Api.Domain.Arguments.Hateoas;
using LoremIpsumLogistica.Api.Domain.IServices;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LoremIpsumLogistica.Api.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/clients/v{version:apiVersion}")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        private readonly IUrlHelper _urlHelper;

        public ClientController(IClientService clientService, IUrlHelper urlHelper)
        {
            _clientService = clientService;
            _urlHelper = urlHelper;
        }

        [HttpPost]
        public async Task<ActionResult<ClientResponse>> CreateAsync(CreateClientRequest request)
        {
            try
            {
                var client = await _clientService.CreateAsync(request);

                GerarLinks(client);

                return StatusCode(201, client);
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientResponse>>> GetAllAsync(int? page, int? size)
        {
            var client = await _clientService.GetAllAsync((int)page, (int)size);

            client.ToList().ForEach(c => GerarLinks(c));

            return Ok(client);
        }

        [HttpGet("{id}", Name = nameof(GetByIdAsync))]
        public async Task<ActionResult> GetByIdAsync(Guid id)
        {
            try
            {
                var client = await _clientService.GetByIdAsync(id);

                GerarLinks(client);

                return Ok(client);
            }
            catch (ValidationException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("getByName")]
        public async Task<ActionResult<IEnumerable<ClientResponse>>> GetByNameAsync(string firstName, string lastName)
        {
            try
            {
                var client = await _clientService.GetByNameAsync(firstName, lastName);

                client.ToList().ForEach(c => GerarLinks(c));

                return Ok(client);
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut(Name = nameof(UpdateAsync))]
        public async Task<ActionResult<ClientResponse>> UpdateAsync(UpdateClientRequest request)
        {
            try
            {
                var client = await _clientService.UpdateAsync(request);
                return Ok(client);
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
                await _clientService.DeleteByIAsync(id);
            }
            catch (ValidationException ex)
            {
                return NotFound(ex.Message);
            }
            return NoContent();
        }
        private void GerarLinks(ClientResponse client)
        {
            client.Links.Add(new LinkDTO(_urlHelper.Link(nameof(GetByIdAsync), new { id = client.Id }), rel: "self-client", metodo: "GET"));
            client.Links.Add(new LinkDTO(_urlHelper.Link(nameof(UpdateAsync), new { id = client.Id }), rel: "update-client", metodo: "PUT"));
            client.Links.Add(new LinkDTO(_urlHelper.Link(nameof(DeleteByIAsync), new { id = client.Id }), rel: "delete-client", metodo: "DELETE"));
        }

    }
}
