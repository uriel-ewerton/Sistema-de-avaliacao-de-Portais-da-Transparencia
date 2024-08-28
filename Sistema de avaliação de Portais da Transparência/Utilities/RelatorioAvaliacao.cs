using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Drawing;
using System;
using System.Collections.Generic;
using SAPT.DTO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAPT.Controller;

namespace SAPT.Utilities
{
    public class RelatorioAvaliacao : IDocument
    {
        private AvaliacaoDTO Avaliacao { get; }

        public RelatorioAvaliacao(AvaliacaoDTO avaliacao)
        {
            Avaliacao = avaliacao;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container
                .Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(1, Unit.Centimetre);
                    page.DefaultTextStyle(TextStyle.Default.FontSize(9));

                    page.Header().Element(ComposeHeader);
                    page.Content().Element(ComposeContent);
                    page.Footer().Element(ComposeFooter);
                });
        }

        void ComposeHeader(IContainer container)
        {
            FuncionarioController funcionarioController = new();
            container.Row(row =>
            {
                row.RelativeItem().Column(column =>
                {
                    column.Item().Text("IDENTIFICAÇÃO DA ENTIDADE").Bold();
                    column.Item().Text($"Identificação da entidade pública: {Avaliacao.Segmento}");
                    column.Item().Text($"Município: {Avaliacao.Municipio}");
                    column.Item().Text($"Data base da avaliação: {Avaliacao.DataAvaliacao:dd/MM/yyyy}");
                    column.Item().Text($"Avaliador: {funcionarioController.BuscarPorId(Avaliacao.IdUsuario).Login}");
                    column.Item().Text("");
                });
            });
        }

        void ComposeContent(IContainer container)
        {
            container.Table(table =>
            {
                // Definindo as colunas
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn(1);
                    columns.RelativeColumn(2);
                    columns.RelativeColumn((float)1.8);
                    columns.RelativeColumn((float)1.2);
                    columns.RelativeColumn(2);
                    columns.RelativeColumn(2); // Adicionado para "Justificativa"
                });

                // Cabeçalho da tabela
                table.Header(header =>
                {
                    header.Cell().Element(CellStyle).Text("ITEM");
                    header.Cell().Element(CellStyle).Text("CRITÉRIO");
                    header.Cell().Element(CellStyle).Text("CLASSIFICAÇÃO");
                    header.Cell().Element(CellStyle).Text("AVALIAÇÃO");
                    header.Cell().Element(CellStyle).Text("LINK COM EVIDÊNCIA");
                    header.Cell().Element(CellStyle).Text("JUSTIFICATIVA"); // Adicionado
                });

                CriterioController criterioController = new();

                List<CriterioDTO> criterios = criterioController.ListarCriteriosJoinRespostas(Avaliacao);

                // Usa HashSet para verificar presença de matrizes e dimensões de maneira mais eficiente
                HashSet<string> matrizes = new HashSet<string>();
                HashSet<string> dimensoes = new HashSet<string>();
                int index = 0;

                // Conteúdo da tabela
                foreach (CriterioDTO criterio in criterios)
                {
                    // Adiciona uma linha para a matriz, se for nova
                    if (matrizes.Add(criterio.Matriz))
                    {
                        table.Cell().ColumnSpan(6).Element(CellStyle).Background(Colors.Grey.Lighten2).Text(criterio.Matriz).Bold();
                    }

                    // Adiciona uma linha para a dimensão, se for nova
                    if (!string.IsNullOrEmpty(criterio.Dimensao) && dimensoes.Add(criterio.Dimensao))
                    {
                        table.Cell().ColumnSpan(6).Element(CellStyle).Background(Colors.Grey.Lighten4).Text(criterio.Dimensao).Bold();
                    }

                    // Conteúdo de cada linha de critério
                    table.Cell().Element(CellStyle).Text((index + 1).ToString()); // ITEM
                    table.Cell().Element(CellStyle).Text(criterio.Pergunta); // CRITÉRIO
                    table.Cell().Element(CellStyle).Text(criterio.Classificacao); // CLASSIFICAÇÃO
                    table.Cell().Element(CellStyle).Text(Avaliacao.Respostas[index].Resposta ? "Sim" : "Não"); // AVALIAÇÃO

                    // Determina onde o link deve ser exibido
                    if (Avaliacao.Respostas[index].Resposta)
                    {
                        table.Cell().Element(CellStyle).Text(Avaliacao.Respostas[index].Link); // LINK COM EVIDÊNCIA
                        table.Cell().Element(CellStyle).Text(""); // JUSTIFICATIVA
                    }
                    else
                    {
                        table.Cell().Element(CellStyle).Text(""); // LINK COM EVIDÊNCIA
                        table.Cell().Element(CellStyle).Text(Avaliacao.Respostas[index].Link); // JUSTIFICATIVA
                    }

                    index++;
                }
            });
        }


        void ComposeFooter(IContainer container)
        {
            container.AlignCenter().Text(text =>
            {
                text.Span("Página ");
                text.CurrentPageNumber();
                text.Span(" de ");
                text.TotalPages();
            });
        }

        IContainer CellStyle(IContainer container)
        {
            return container.Border(1).Padding(5).AlignMiddle().AlignLeft();
        }
    }
}


