﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteDS.API.Infrastructure.DataBase;

#nullable disable

namespace TesteDS.API.Infrastructure.DataBase.Migrations
{
    [DbContext(typeof(DBTesteDSContext))]
    partial class DBTesteDSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Models.TaskItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FinishedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("WorkerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkerId");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3135),
                            Description = "Corrigir o bug que impede o login de usuários com autenticação de dois fatores ativada.",
                            Status = 1,
                            Title = "Corrigir falha na autenticação de usuários",
                            UpdateAt = new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3419),
                            WorkerId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2025, 4, 9, 5, 49, 42, 555, DateTimeKind.Local).AddTicks(3779),
                            Description = "Gerar um relatório detalhado com os dados de performance do sistema nos últimos 30 dias.",
                            Status = 1,
                            Title = "Criar relatório de performance do sistema",
                            UpdateAt = new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3780),
                            WorkerId = 2
                        },
                        new
                        {
                            Id = 3,
                            CreateAt = new DateTime(2025, 4, 9, 14, 9, 42, 555, DateTimeKind.Local).AddTicks(3782),
                            Description = "Adicionar funcionalidade de busca por nome no módulo de usuários com debounce para otimizar a performance.",
                            Status = 2,
                            Title = "Implementar filtro de busca por nome",
                            UpdateAt = new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3783),
                            WorkerId = 3
                        },
                        new
                        {
                            Id = 4,
                            CreateAt = new DateTime(2025, 4, 9, 12, 29, 42, 555, DateTimeKind.Local).AddTicks(3785),
                            Description = "Refatorar o componente de grid para usar o novo padrão de exibição com QuickGrid.",
                            Status = 1,
                            Title = "Refatorar componente de grid de tarefas",
                            UpdateAt = new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3786),
                            WorkerId = 4
                        },
                        new
                        {
                            Id = 5,
                            CreateAt = new DateTime(2025, 4, 9, 13, 39, 42, 555, DateTimeKind.Local).AddTicks(3824),
                            Description = "Revisar e atualizar os endpoints da documentação Swagger da API de tarefas.",
                            Status = 2,
                            Title = "Atualizar documentação da API de tarefas",
                            UpdateAt = new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3824),
                            WorkerId = 5
                        },
                        new
                        {
                            Id = 6,
                            CreateAt = new DateTime(2025, 4, 9, 12, 59, 42, 555, DateTimeKind.Local).AddTicks(3827),
                            Description = "Realizar testes em diferentes dispositivos para garantir a responsividade da tela de login.",
                            Status = 2,
                            Title = "Testar responsividade da tela de login",
                            UpdateAt = new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3827),
                            WorkerId = 3
                        },
                        new
                        {
                            Id = 7,
                            CreateAt = new DateTime(2025, 4, 9, 17, 29, 42, 555, DateTimeKind.Local).AddTicks(3830),
                            Description = "Criar pipeline de integração contínua para builds automáticos sempre que houver push na branch develop.",
                            Status = 1,
                            Title = "Configurar CI/CD para branch develop",
                            UpdateAt = new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3830),
                            WorkerId = 4
                        },
                        new
                        {
                            Id = 8,
                            CreateAt = new DateTime(2025, 4, 9, 20, 49, 42, 555, DateTimeKind.Local).AddTicks(3832),
                            Description = "Desenvolver uma nova tela para cadastro de novos colaboradores com validações e máscara de campos.",
                            Status = 2,
                            Title = "Criar tela de cadastro de colaboradores",
                            UpdateAt = new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3833),
                            WorkerId = 6
                        },
                        new
                        {
                            Id = 9,
                            CreateAt = new DateTime(2025, 4, 9, 9, 9, 42, 555, DateTimeKind.Local).AddTicks(3836),
                            Description = "Criar integração com serviço de e-mail para envio automático de notificações sobre tarefas pendentes.",
                            Status = 1,
                            Title = "Integrar módulo de notificações por e-mail",
                            UpdateAt = new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3836),
                            WorkerId = 7
                        },
                        new
                        {
                            Id = 10,
                            CreateAt = new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3838),
                            Description = "Levantar e documentar os erros recorrentes encontrados nos logs do ambiente de produção na última semana.",
                            Status = 1,
                            Title = "Analisar logs de erro do ambiente de produção",
                            UpdateAt = new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3839),
                            WorkerId = 8
                        },
                        new
                        {
                            Id = 11,
                            CreateAt = new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3841),
                            Description = "Corrigir desalinhamentos no dashboard e aplicar o novo esquema de cores aprovado pela equipe de design.",
                            Status = 1,
                            Title = "Ajustar layout da página de dashboard",
                            UpdateAt = new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3842),
                            WorkerId = 1
                        },
                        new
                        {
                            Id = 12,
                            CreateAt = new DateTime(2025, 4, 9, 5, 49, 42, 555, DateTimeKind.Local).AddTicks(3844),
                            Description = "Implementar funcionalidade que permite exportar relatórios diretamente em formato PDF.",
                            Status = 1,
                            Title = "Adicionar exportação de relatórios em PDF",
                            UpdateAt = new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3845),
                            WorkerId = 2
                        },
                        new
                        {
                            Id = 13,
                            CreateAt = new DateTime(2025, 4, 9, 14, 9, 42, 555, DateTimeKind.Local).AddTicks(3847),
                            Description = "Escrever testes de unidade e integração cobrindo todos os fluxos de autenticação e autorização.",
                            Status = 2,
                            Title = "Criar testes automatizados para o módulo de autenticação",
                            UpdateAt = new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3848),
                            WorkerId = 3
                        },
                        new
                        {
                            Id = 14,
                            CreateAt = new DateTime(2025, 4, 9, 12, 29, 42, 555, DateTimeKind.Local).AddTicks(3850),
                            Description = "Agendar e conduzir reunião para revisar escopo das próximas entregas do sprint atual.",
                            Status = 1,
                            Title = "Realizar reunião de alinhamento com o cliente",
                            UpdateAt = new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3851),
                            WorkerId = 4
                        },
                        new
                        {
                            Id = 15,
                            CreateAt = new DateTime(2025, 4, 9, 13, 39, 42, 555, DateTimeKind.Local).AddTicks(3853),
                            Description = "Adicionar suporte ao modo escuro, com opção de alternância no menu do usuário.",
                            Status = 2,
                            Title = "Implementar dark mode na aplicação",
                            UpdateAt = new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3854),
                            WorkerId = 5
                        },
                        new
                        {
                            Id = 16,
                            CreateAt = new DateTime(2025, 4, 9, 12, 59, 42, 555, DateTimeKind.Local).AddTicks(3856),
                            Description = "Revisar os cálculos dos principais KPIs do painel administrativo e corrigir as fórmulas incorretas.",
                            Status = 2,
                            Title = "Corrigir inconsistência nos cálculos de KPI",
                            UpdateAt = new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3857),
                            WorkerId = 3
                        },
                        new
                        {
                            Id = 17,
                            CreateAt = new DateTime(2025, 4, 9, 17, 29, 42, 555, DateTimeKind.Local).AddTicks(3859),
                            Description = "Fazer upgrade das bibliotecas NuGet do projeto e testar para garantir compatibilidade com .NET 8.",
                            Status = 1,
                            Title = "Atualizar dependências do projeto",
                            UpdateAt = new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3860),
                            WorkerId = 4
                        },
                        new
                        {
                            Id = 18,
                            CreateAt = new DateTime(2025, 4, 9, 20, 49, 42, 555, DateTimeKind.Local).AddTicks(3862),
                            Description = "Analisar o tempo de resposta da API e identificar gargalos no carregamento de listas grandes.",
                            Status = 2,
                            Title = "Investigar queda de performance no carregamento de dados",
                            UpdateAt = new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3862),
                            WorkerId = 6
                        },
                        new
                        {
                            Id = 19,
                            CreateAt = new DateTime(2025, 4, 9, 9, 9, 42, 555, DateTimeKind.Local).AddTicks(3865),
                            Description = "Desenvolver um novo componente para botões com suporte a ícone à esquerda ou à direita.",
                            Status = 1,
                            Title = "Criar componente reutilizável de botão com ícone",
                            UpdateAt = new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3865),
                            WorkerId = 7
                        },
                        new
                        {
                            Id = 20,
                            CreateAt = new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3867),
                            Description = "Registrar todas as etapas e boas práticas envolvidas na publicação de novas versões no ambiente produtivo.",
                            Status = 2,
                            Title = "Documentar processo de publicação em produção",
                            UpdateAt = new DateTime(2025, 4, 9, 15, 49, 42, 555, DateTimeKind.Local).AddTicks(3868),
                            WorkerId = 8
                        });
                });

            modelBuilder.Entity("Domain.Models.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Workers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Rafael Santos",
                            Position = 3
                        },
                        new
                        {
                            Id = 2,
                            Name = "Fernanda Costa",
                            Position = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Lucas Almeida",
                            Position = 2
                        },
                        new
                        {
                            Id = 4,
                            Name = "Juliana Martins",
                            Position = 3
                        },
                        new
                        {
                            Id = 5,
                            Name = "Bruno Ferreira",
                            Position = 2
                        },
                        new
                        {
                            Id = 6,
                            Name = "Camila Oliveira",
                            Position = 3
                        },
                        new
                        {
                            Id = 7,
                            Name = "Diego Rocha",
                            Position = 2
                        },
                        new
                        {
                            Id = 8,
                            Name = "Isabela Lima",
                            Position = 3
                        },
                        new
                        {
                            Id = 9,
                            Name = "Thiago Moreira",
                            Position = 2
                        },
                        new
                        {
                            Id = 10,
                            Name = "Larissa Ribeiro",
                            Position = 3
                        });
                });

            modelBuilder.Entity("Domain.Models.TaskItem", b =>
                {
                    b.HasOne("Domain.Models.Worker", null)
                        .WithMany()
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
