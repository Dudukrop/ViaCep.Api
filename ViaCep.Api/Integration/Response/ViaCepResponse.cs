﻿using System.ComponentModel.DataAnnotations;

namespace ViaCep.Api.Integration.Response
{
	public class ViaCepResponse
	{
        [Required(ErrorMessage = "CEP necessário")]
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        public string Ibge { get; set; }
        public string Gia { get; set; }
        public string DDD { get; set; }
        public string Siafi { get; set; }
    }
}
