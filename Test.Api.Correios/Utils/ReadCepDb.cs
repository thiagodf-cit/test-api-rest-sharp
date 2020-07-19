using System.IO;
using Newtonsoft.Json;

namespace Test.Api.Correios.Utils
{
    public class ReadCepDb
    {
        public string CepValid { get; set; }
        public string CepInvalid { get; set; }
        
        public static ReadCepDb ReadCep()
        {
            var cepDb = File.ReadAllText("./../../../Utils/Db/cep.json");
            
            return JsonConvert.DeserializeObject<ReadCepDb>(cepDb);
        }
        
    }
}