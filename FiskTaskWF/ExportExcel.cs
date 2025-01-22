using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;


namespace FiscoTask
{
    public class ExportExcel
    {

        public static void ExportarParaExcel(DataGridView dataGridView)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Workbook|*.xlsx" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                        using (ExcelPackage package = new ExcelPackage())
                        {
                            var ws = package.Workbook.Worksheets.Add("Dados Exportados");

                            // Adicionar cabeçalhos
                            for (int i = 0; i < dataGridView.Columns.Count; i++)
                            {
                                ws.Cells[1, i + 1].Value = dataGridView.Columns[i].HeaderText;
                                ws.Cells[1, i + 1].Style.Font.Bold = true;
                                ws.Cells[1, i + 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            }

                            // Adicionar dados
                            for (int i = 0; i < dataGridView.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataGridView.Columns.Count; j++)
                                {
                                    ws.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value?.ToString();
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
