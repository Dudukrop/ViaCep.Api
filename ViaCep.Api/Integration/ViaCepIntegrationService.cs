using Microsoft.AspNetCore.Mvc;
using ViaCep.Api.Integration.Interfaces;
using ViaCep.Api.Integration.Refit;
using ViaCep.Api.Integration.Response;

namespace ViaCep.Api.Integration
{
	public class ViaCepIntegrationService : IViaCepIntegrationService
	{
		private readonly IViaCepIntegrationRefit _refit;
        public ViaCepIntegrationService(IViaCepIntegrationRefit refit)
        {
			_refit = refit;
        }
        public async Task<ViaCepResponse> ObterDadosViaCep(string cep)
		{
			var response = await _refit.ObterDados(cep);

			if (response != null && response.IsSuccessStatusCode) 
				return response.Content;

			return null;
		}
	}
}
