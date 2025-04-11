# 📋 Data System - Gerenciador de Tarefas

Este projeto é uma aplicação completa para **gerenciamento de tarefas**, desenvolvida como parte de um teste técnico.  

## 🧩 Tecnologias utilizadas:

#### ⚙️ Backend (API)
- ASP.NET Core Web API  
- Entity Framework Core (acesso a dados)  
- SQL Server (banco de dados relacional)  
- Swagger (documentação e testes dos endpoints)

#### 🖥️ Frontend
- Blazor (interface web moderna em C#)
- Radzen Blazor Components (componentes visuais prontos)

## 🚀 Funcionalidades da API

A API permite o gerenciamento completo de tarefas, com suporte a operações CRUD e controle de status. Também oferece consulta de trabalhadores disponíveis para atribuição.

- `POST /TaskItem/Create`  
  Cria uma nova tarefa

- `GET /TaskItem/GetById`  
  Retorna os detalhes de uma tarefa específica pelo ID

- `GET /TaskItem/GetAll`  
  Lista todas as tarefas cadastradas

- `PUT /TaskItem/Update`  
  Atualiza todas as informações de uma tarefa existente

- `PUT /TaskItem/UpdateStatus`  
  Atualiza apenas o status de uma tarefa (ex: de Pendente para Concluída)

- `DELETE /TaskItem/DeleteById`  
  Remove uma tarefa com base no ID

- `GET /Worker/GetAll`  
  Lista todos os trabalhadores disponíveis
  
## 🧪 Como rodar o projeto localmente

### 🔄 Pré-requisitos

- [.NET 6 SDK ou superior](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- Visual Studio ou VS Code com extensão C#

### 🧰 Passos para executar

1. Clone o repositório

```bash
git clone https://github.com/Agonxx/Teste_DataSystem
cd Teste_DataSystem
```

4. Execute a migration para criar o banco:

```bash
Add-Migration InitialCreate -OutputDir Infrastructure/DataBase/Migrations
Update-Database
```
---
