using DevExpress.XtraRichEdit; // Adicione esta referência
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


//classe utilizada para expotação dos dados de tarefas para excel, especialmente para minha saída do escritório.

namespace FiscoTask.Models
{
    public class ExportExcelTarefasCompleto
    {

        // Modificamos o método para aceitar um DataTable, que é a fonte de dados real.
        // Opcionalmente, passamos o nome da coluna que contém o arquivo docx.
        public static void ExportarParaExcel(DataTable dataTable, string nomeColunaArquivo = "Arquivo")
        {
            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Não há dados para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Workbook|*.xlsx" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        ExcelPackage.License.SetNonCommercialPersonal("AndreCruz");
                        using (var package = new ExcelPackage())
                        {
                            var ws = package.Workbook.Worksheets.Add("Dados Exportados");

                            // Instancia o servidor de documentos FORA do loop para melhor performance.
                            using (var server = new RichEditDocumentServer())
                            {
                                // Adicionar cabeçalhos
                                for (int i = 0; i < dataTable.Columns.Count; i++)
                                {
                                    ws.Cells[1, i + 1].Value = dataTable.Columns[i].ColumnName;
                                    ws.Cells[1, i + 1].Style.Font.Bold = true;
                                    ws.Cells[1, i + 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                }

                                // Adicionar dados
                                for (int i = 0; i < dataTable.Rows.Count; i++)
                                {
                                    for (int j = 0; j < dataTable.Columns.Count; j++)
                                    {
                                        string nomeColunaAtual = dataTable.Columns[j].ColumnName;

                                        // Verifica se a coluna atual é a que contém o arquivo
                                        if (nomeColunaAtual.Equals(nomeColunaArquivo, StringComparison.OrdinalIgnoreCase))
                                        {
                                            // Pega o valor como byte array
                                            if (dataTable.Rows[i][j] is byte[] fileData && fileData.Length > 0)
                                            {
                                                try
                                                {
                                                    // Carrega o documento na memória e extrai o texto puro
                                                    using (var ms = new MemoryStream(fileData))
                                                    {
                                                        server.LoadDocument(ms, DocumentFormat.OpenXml);
                                                        ws.Cells[i + 2, j + 1].Value = server.Text;
                                                    }
                                                }
                                                catch (Exception)
                                                {
                                                    // Caso o arquivo esteja corrompido ou em formato inválido
                                                    ws.Cells[i + 2, j + 1].Value = "[Erro ao ler anotação]";
                                                }
                                            }
                                            else
                                            {
                                                // Se não houver arquivo, a célula fica em branco
                                                ws.Cells[i + 2, j + 1].Value = string.Empty;
                                            }
                                        }
                                        else
                                        {
                                            // Para todas as outras colunas, o comportamento é o mesmo de antes
                                            ws.Cells[i + 2, j + 1].Value = dataTable.Rows[i][j]?.ToString();
                                        }
                                    }
                                }
                            }

                            // Ajustar colunas
                            ws.Cells.AutoFitColumns();

                            // Salvar o arquivo
                            File.WriteAllBytes(sfd.FileName, package.GetAsByteArray());
                            MessageBox.Show("Exportação concluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao exportar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
