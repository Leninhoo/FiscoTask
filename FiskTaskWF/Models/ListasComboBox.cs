using DevExpress.CodeParser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Runtime.CompilerServices;
using System.IO;

namespace FiscoTask.Models
{
    public class ListasComboBox
    {
        // Caminho absoluto para o JSON (pasta "Lists" ao lado do .exe)
        private readonly string _jsonPath;

        // Cache opcional – evita ler o disco toda vez
        private Dictionary<string, List<string>> _dados = new();

        public ListasComboBox()
        {
            // Ex.: C:\Projeto\bin\Debug\net6.0-windows\Listas\Listas.json
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            _jsonPath = Path.Combine(baseDir, "Listas", "Listas.json");

            CarregarJson();
        }

        /// Lê o arquivo JSON e armazena tudo em um dicionário.
        /// Se o arquivo não existir, cria um dicionário vazio (evita exceção).

        private void CarregarJson()
        {
            if (!File.Exists(_jsonPath))
            {
                // Se o arquivo desaparecer em tempo de execução, deixa o dicionário vazio.
                _dados = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);
                return;
            }

            var json = File.ReadAllText(_jsonPath);
            // O tipo alvo deve ser Dictionary<string, List<string>>
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            _dados = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(json, options)
                     ?? new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);
        }

        // ---------- Métodos públicos (usados nas ComboBox) ----------
        public List<string> Fase() => GetLista("Fase");
        public List<string> Situacao() => GetLista("Situacao");
        public List<string> TipoProcesso() => GetLista("TipoProcesso");
        public List<string> AndamentosProcesso() => GetLista("AndamentosProcesso");

        // ---------- Helpers ----------
        private List<string> GetLista(string chave)
        {
            // Se a chave não existir, devolve lista vazia (não lança exceção)
            return _dados.TryGetValue(chave, out var lista) ? lista : new List<string>();
        }


        /// Força recarregar o JSON (útil se você editar o arquivo enquanto o programa está aberto).

        public void Refresh()
        {
            CarregarJson();
        }
    }
}
