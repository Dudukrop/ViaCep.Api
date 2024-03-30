using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViaCep.Api.Integration.Interfaces;
using ViaCep.Api.Integration.Response;

namespace ViaCep.Api.Controllers
{
	[Route("ViaCepApi")]
	[ApiController]
	public class ViaCepController : ControllerBase
	{
		[HttpGet]
		[Route("{cep}")]
		public async Task<ActionResult<ViaCepResponse>> Get([FromServices] IViaCepIntegrationService _response,
			string cep)
		{
			var response = await _response.ObterDadosViaCep(cep);

			if (response == null)
				return BadRequest("Cep não informado");

			return Ok(response);
		}
	}
}
