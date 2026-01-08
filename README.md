# Product API – ASP.NET Core

API REST desenvolvida em **ASP.NET Core** para gerenciamento de produtos, utilizando **Entity Framework Core**, **SQL Server**, **DTOs**, **Camada de Service** e **AutoMapper**.

Este projeto foi criado com foco em **boas práticas**, **arquitetura limpa** e **organização de código**, servindo como **projeto de portfólio backend .NET**.

---

## 🚀 Tecnologias Utilizadas

- ASP.NET Core
- Entity Framework Core
- SQL Server
- AutoMapper
- Swagger (OpenAPI)
- DTOs
- Camada Service
- User Secrets
- Postman / Swagger para testes

---

## 🏗️ Arquitetura do Projeto

```
Product.Api
 ├── Controllers
 ├── Data
 │    └── AppDbContext
 ├── Models
 ├── DTOs
 ├── Services
 │    ├── Interfaces
 │    └── Implementations
 ├── Profiles (AutoMapper)
 └── Program.cs
```

---

## 📦 Funcionalidades

- ✅ Cadastro de produtos
- ✅ Listagem de produtos
- ✅ Consulta de produto por ID
- ✅ Atualização de produto
- ✅ Exclusão de produto
- ✅ Uso de DTOs para entrada e saída de dados
- ✅ Camada de Service para regras de negócio
- ✅ AutoMapper para mapeamento de objetos

---

## 📄 Modelo de Produto

- Nome
- Preço
- Estoque
- Data de Criação

---

## ▶️ Como Executar o Projeto

### Pré-requisitos

- .NET SDK 8+
- SQL Server Express
- SQL Server Management Studio (SSMS)

---

## 🔐 Configuração de Secrets (User Secrets)

Este projeto utiliza **.NET User Secrets** para armazenar informações sensíveis, como a **string de conexão com o banco de dados**, evitando que esses dados fiquem versionados no repositório.

### ▶️ Passo a passo

```bash
git clone https://github.com/Leandrosp9/product-api-dotnet.git
cd product-api-dotnet
dotnet user-secrets init
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=localhost\\SQLEXPRESS;Database=ProductDb;Trusted_Connection=True;TrustServerCertificate=True;"
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet run
```
## 🧪 Testes da API

A API pode ser testada utilizando:

- 🔹 **Swagger** (disponível automaticamente ao rodar o projeto)
- 🔹 **Postman**

> Não é necessário frontend, pois trata-se de uma API REST.

---

## 📌 Próximas Evoluções

- Paginação e filtros
- Autenticação JWT
- Repository Pattern
- Testes unitários

---

## 👨‍💻 Autor

**Leandro Souza**  
Desenvolvedor Backend .NET
-GitHub: https://github.com/Leandrosp9
