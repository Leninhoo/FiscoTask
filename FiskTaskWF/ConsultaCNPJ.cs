using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace FiscoTask
{
    public class ConsultaCNPJ
    {

        private static readonly HttpClient _httpClient = new HttpClient();

        public async Task<EmpresaAPI> BuscarEmpresaCNPJ(string cnpj)
        {
            try
            {
                string url = $"https://minhareceita.org/{cnpj}";

                HttpResponseMessage response = await _httpClient.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }
                string jsonResponse = await response.Content.ReadAsStringAsync();
                EmpresaAPI empresa = JsonConvert.DeserializeObject<EmpresaAPI>(jsonResponse);

                return empresa;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro: {ex.Message}");
            }
        }

    }
}
