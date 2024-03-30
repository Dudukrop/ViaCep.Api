using ViaCep.Api.Integration.Response;

namespace ViaCep.Api.Integration.Interfaces
{
	public interface IViaCepIntegrationService
	{
		Task<ViaCepResponse> ObterDadosViaCep(string cep);
	}
}
