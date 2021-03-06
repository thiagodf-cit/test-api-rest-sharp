using System;
using Test.Api.Correios.Models;
using RestSharp;
using Xunit;
using FluentAssertions;
using Newtonsoft.Json;
using Test.Api.Correios.Utils;

namespace Test.Api.Correios
{
    public class Program
    {
        private ReadCepDb readCepDb = ReadCepDb.ReadCep();
        private IRestResponse GetCep(object cep)
        {
            var rsClient = new RestClient("http://viacep.com.br/ws/" + cep + "/json/");
            var rsRequest = new RestRequest(Method.GET) { RequestFormat = DataFormat.Json };

            return rsClient.Execute(rsRequest);
        }

        //Retornar o Get com os dados e statuscode válidos.
        [Fact]
        public void Sucesso()
        {
            //Arrange
            var cepValid = readCepDb.CepValid;

            //Act
            var response = GetCep(cepValid);
            var json = JsonConvert.DeserializeObject<CorreiosResponse>(response.Content);

            //Assert
            json.Cep.Should().Be("01138-000");
            json.Logradouro.Should().Be("Rua James Holland");
            json.Complemento.Should().Be("");
            json.Bairro.Should().Be("Barra Funda");
            json.Localidade.Should().Be("São Paulo");
            json.UF.Should().Be("SP");
            json.Unidade.Should().Be("");
            json.Ibge.Should().Be("3550308");
            json.Gia.Should().Be("1004");

            response.StatusCode.Should().Be(200);
        }
        
        [Fact]
        public void Exception()
        {
             //Arrange
            var cepInvalid = readCepDb.CepInvalid;

            //Act
            var response = GetCep(cepInvalid);
            var json = JsonConvert.DeserializeObject<CorreiosResponse>(response.Content);

            //Assert
            json.Cep.Should().BeNull();
            json.Logradouro.Should().BeNull();
            json.Complemento.Should().BeNull();
            json.Bairro.Should().BeNull();
            json.Localidade.Should().BeNull();
            json.UF.Should().BeNull();
            json.Unidade.Should().BeNull();
            json.Ibge.Should().BeNull();
            json.Gia.Should().BeNull();
            
            response.StatusCode.Should().Be(200);
        }
    }
}
