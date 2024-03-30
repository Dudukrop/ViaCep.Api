using Refit;
using ViaCep.Api.Integration.Response;

namespace ViaCep.Api.Integration.Refit
{
	public interface IViaCepIntegrationRefit
	{
		[Get("/ws/{cep}/json")]
		Task<ApiResponse<ViaCepResponse>> ObterDados(string cep);
	}
}
