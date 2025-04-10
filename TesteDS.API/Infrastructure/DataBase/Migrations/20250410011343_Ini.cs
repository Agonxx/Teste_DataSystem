using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TesteDS.API.Infrastructure.DataBase.Migrations
{
    /// <inheritdoc />
    public partial class Ini : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkerId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinishedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Workers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Workers",
                columns: new[] { "Id", "Name", "Position" },
                values: new object[,]
                {
                    { 1, "Rafael Santos", 3 },
                    { 2, "Fernanda Costa", 1 },
                    { 3, "Lucas Almeida", 2 },
                    { 4, "Juliana Martins", 3 },
                    { 5, "Bruno Ferreira", 2 },
                    { 6, "Camila Oliveira", 3 },
                    { 7, "Diego Rocha", 2 },
                    { 8, "Isabela Lima", 3 },
                    { 9, "Thiago Moreira", 2 },
                    { 10, "Larissa Ribeiro", 3 }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreateAt", "Description", "FinishedAt", "Status", "Title", "UpdateAt", "WorkerId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3135), "Corrigir o bug que impede o login de usuários com autenticação de dois fatores ativada.", null, 1, "Corrigir falha na autenticação de usuários", new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3419), 1 },
                    { 2, new DateTime(2025, 4, 9, 5, 49, 42, 555, DateTimeKind.Local).AddTicks(3779), "Gerar um relatório detalhado com os dados de performance do sistema nos últimos 30 dias.", null, 1, "Criar relatório de performance do sistema", new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3780), 2 },
                    { 3, new DateTime(2025, 4, 9, 14, 9, 42, 555, DateTimeKind.Local).AddTicks(3782), "Adicionar funcionalidade de busca por nome no módulo de usuários com debounce para otimizar a performance.", null, 2, "Implementar filtro de busca por nome", new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3783), 3 },
                    { 4, new DateTime(2025, 4, 9, 12, 29, 42, 555, DateTimeKind.Local).AddTicks(3785), "Refatorar o componente de grid para usar o novo padrão de exibição com QuickGrid.", null, 1, "Refatorar componente de grid de tarefas", new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3786), 4 },
                    { 5, new DateTime(2025, 4, 9, 13, 39, 42, 555, DateTimeKind.Local).AddTicks(3824), "Revisar e atualizar os endpoints da documentação Swagger da API de tarefas.", null, 2, "Atualizar documentação da API de tarefas", new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3824), 5 },
                    { 6, new DateTime(2025, 4, 9, 12, 59, 42, 555, DateTimeKind.Local).AddTicks(3827), "Realizar testes em diferentes dispositivos para garantir a responsividade da tela de login.", null, 2, "Testar responsividade da tela de login", new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3827), 3 },
                    { 7, new DateTime(2025, 4, 9, 17, 29, 42, 555, DateTimeKind.Local).AddTicks(3830), "Criar pipeline de integração contínua para builds automáticos sempre que houver push na branch develop.", null, 1, "Configurar CI/CD para branch develop", new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3830), 4 },
                    { 8, new DateTime(2025, 4, 9, 20, 49, 42, 555, DateTimeKind.Local).AddTicks(3832), "Desenvolver uma nova tela para cadastro de novos colaboradores com validações e máscara de campos.", null, 2, "Criar tela de cadastro de colaboradores", new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3833), 6 },
                    { 9, new DateTime(2025, 4, 9, 9, 9, 42, 555, DateTimeKind.Local).AddTicks(3836), "Criar integração com serviço de e-mail para envio automático de notificações sobre tarefas pendentes.", null, 1, "Integrar módulo de notificações por e-mail", new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3836), 7 },
                    { 10, new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3838), "Levantar e documentar os erros recorrentes encontrados nos logs do ambiente de produção na última semana.", null, 1, "Analisar logs de erro do ambiente de produção", new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3839), 8 },
                    { 11, new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3841), "Corrigir desalinhamentos no dashboard e aplicar o novo esquema de cores aprovado pela equipe de design.", null, 1, "Ajustar layout da página de dashboard", new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3842), 1 },
                    { 12, new DateTime(2025, 4, 9, 5, 49, 42, 555, DateTimeKind.Local).AddTicks(3844), "Implementar funcionalidade que permite exportar relatórios diretamente em formato PDF.", null, 1, "Adicionar exportação de relatórios em PDF", new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3845), 2 },
                    { 13, new DateTime(2025, 4, 9, 14, 9, 42, 555, DateTimeKind.Local).AddTicks(3847), "Escrever testes de unidade e integração cobrindo todos os fluxos de autenticação e autorização.", null, 2, "Criar testes automatizados para o módulo de autenticação", new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3848), 3 },
                    { 14, new DateTime(2025, 4, 9, 12, 29, 42, 555, DateTimeKind.Local).AddTicks(3850), "Agendar e conduzir reunião para revisar escopo das próximas entregas do sprint atual.", null, 1, "Realizar reunião de alinhamento com o cliente", new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3851), 4 },
                    { 15, new DateTime(2025, 4, 9, 13, 39, 42, 555, DateTimeKind.Local).AddTicks(3853), "Adicionar suporte ao modo escuro, com opção de alternância no menu do usuário.", null, 2, "Implementar dark mode na aplicação", new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3854), 5 },
                    { 16, new DateTime(2025, 4, 9, 12, 59, 42, 555, DateTimeKind.Local).AddTicks(3856), "Revisar os cálculos dos principais KPIs do painel administrativo e corrigir as fórmulas incorretas.", null, 2, "Corrigir inconsistência nos cálculos de KPI", new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3857), 3 },
                    { 17, new DateTime(2025, 4, 9, 17, 29, 42, 555, DateTimeKind.Local).AddTicks(3859), "Fazer upgrade das bibliotecas NuGet do projeto e testar para garantir compatibilidade com .NET 8.", null, 1, "Atualizar dependências do projeto", new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3860), 4 },
                    { 18, new DateTime(2025, 4, 9, 20, 49, 42, 555, DateTimeKind.Local).AddTicks(3862), "Analisar o tempo de resposta da API e identificar gargalos no carregamento de listas grandes.", null, 2, "Investigar queda de performance no carregamento de dados", new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3862), 6 },
                    { 19, new DateTime(2025, 4, 9, 9, 9, 42, 555, DateTimeKind.Local).AddTicks(3865), "Desenvolver um novo componente para botões com suporte a ícone à esquerda ou à direita.", null, 1, "Criar componente reutilizável de botão com ícone", new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3865), 7 },
                    { 20, new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3867), "Registrar todas as etapas e boas práticas envolvidas na publicação de novas versões no ambiente produtivo.", null, 2, "Documentar processo de publicação em produção", new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3868), 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_WorkerId",
                table: "Tasks",
                column: "WorkerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Workers");
        }
    }
}
