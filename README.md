# 🚗 Sistema de Locadora de Veículos | ASP.NET Core API

![C#](https://img.shields.io/badge/C%23-.NET-green)
![ASP.NET Core](https://img.shields.io/badge/.NET-ASP.NET%20Core-purple)
![SQL Server](https://img.shields.io/badge/SQL%20Server-Database-red)

---

## 📖 Sobre o Projeto

API REST desenvolvida em **C# com ASP.NET Core**, como parte do Trabalho Prático da disciplina, com o objetivo de simular o funcionamento de uma locadora de veículos.

O sistema permite o gerenciamento completo de:

- Clientes
- Veículos
- Fabricantes
- Categorias de veículos
- Aluguéis

Utiliza **Entity Framework Core** para persistência de dados em banco **SQL Server Express**, seguindo boas práticas de desenvolvimento backend.

---

## ⚙️ Funcionalidades

### ✔ Etapa 1 - Modelagem de Banco de Dados
- Modelagem conceitual
- Criação do modelo relacional
- Definição de chaves primárias e estrangeiras
- Configuração do Entity Framework
- Geração do banco via migrations

### ✔ Etapa 2 - Backend
- API RESTful completa
- CRUD para todas as entidades
- Integração com SQL Server
- Validação de dados
- Tratamento de erros
- Filtros com JOIN entre tabelas

---

## 🔗 Endpoints Principais

| Entidade | Operações |
|----------|----------|
| Clientes | GET, POST, PUT, DELETE |
| Veículos | GET, POST, PUT, DELETE |
| Fabricantes | GET, POST, PUT, DELETE |
| Categorias | GET, POST, PUT, DELETE |
| Aluguéis | GET, POST, PUT, DELETE |

---

## 🔍 Filtros Implementados

- Buscar veículos por fabricante
- Buscar veículos por categoria
- Buscar aluguéis por cliente
- Buscar aluguéis por veículo
- Buscar aluguéis ativos

---

## ▶️ Como Executar o Projeto

1. Clonar o repositório:
git clone https://github.com/RM-Classroom/tads-2026-1-tp1-AndreRavacini.git

2. Acessar a pasta:
cd LocadoraVeiculos

3. Restaurar dependências:
dotnet restore

4. Aplicar migrations:
dotnet ef database update

5. Executar a aplicação:
dotnet run

6. Acessar o Swagger:
https://localhost:7050/swagger


---

## 📁 Estrutura do Projeto

- **Controllers** → Endpoints da API  
- **Models** → Entidades do sistema  
- **Data** → Contexto do banco (DbContext)  
- **Migrations** → Versionamento do banco  

---

## 👨‍💻 Autor

**André Ravacini**
