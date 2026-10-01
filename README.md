<div align="center">
  <img src="https://capsule-render.vercel.app/api?type=waving&color=0:000000,100:241773&height=120&section=header&text=Estudos%20C%23%20%26%20.NET&fontColor=FFFFFF&fontSize=34&fontAlignY=38" width="100%" />
</div>

<p align="center">
  <img src="https://img.shields.io/badge/C%23-0A0A0A?style=for-the-badge&logo=dotnet&logoColor=A78BFA" />
  <img src="https://img.shields.io/badge/.NET_10-0A0A0A?style=for-the-badge&logo=dotnet&logoColor=A78BFA" />
  <img src="https://img.shields.io/badge/SQL_Server-0A0A0A?style=for-the-badge&logo=microsoftsqlserver&logoColor=A78BFA" />
  <img src="https://img.shields.io/badge/EF_Core-0A0A0A?style=for-the-badge&logo=dotnet&logoColor=A78BFA" />
  <img src="https://img.shields.io/badge/Dapper-0A0A0A?style=for-the-badge&logo=nuget&logoColor=A78BFA" />
</p>

<p align="center">
  Minha trilha em <b>C# e .NET 10</b>, da POO no console até APIs em camadas com Entity Framework, JWT e validação.<br/>
  Projetos desenvolvidos na formação <b>Web Developer C# .NET – Full Stack</b> da <a href="https://www.cotiinformatica.com.br">Coti Informática</a> (jan/2026 – jun/2026).
</p>

---

## 🗺️ A trilha

```text
POO no console ──► API em camadas + EF Core + JWT ──► Dapper + SQL Server ──► Web API com Dapper e Docker
     01                        02                          03 · 04                       05
```

| # | Projeto | Quando | O que estudei |
|:-:|---|:-:|---|
| 01 | [`poo-controle-funcionarios`](./01-poo-controle-funcionarios) | jan/2026 | POO em C#: entidades, enums (tipo de contratação), *use cases* e controllers em aplicação de console |
| 02 | [`usuarios-api`](./02-usuarios-api) | fev/2026 | API em **camadas** (API · Domain · Infra.Data): **EF Core + SQL Server** com migrations, **AutoMapper**, **FluentValidation**, hash de senha e autenticação **JWT**, documentada com Scalar/OpenAPI |
| 03 | [`controle-produtos-dapper`](./03-controle-produtos-dapper) | fev/2026 | Acesso a dados com **Dapper** e SQL Server, padrão *Repository* e script de banco |
| 04 | [`sistema-produtos`](./04-sistema-produtos) | fev/2026 | Consolidação do Dapper com regras de categoria e status do produto |
| 05 | [`clientes-api`](./05-clientes-api) | mar/2026 | ASP.NET Core Web API com Dapper, SQL Server em **Docker** e documentação OpenAPI + Scalar |

---

## 💡 O que essa trilha me ensinou

- **Separar responsabilidades.** Na `usuarios-api`, regra de negócio no *Domain*, banco no *Infra.Data* e a API só orquestra. Trocar o banco não exige mexer na regra.
- **ORM completo × micro-ORM.** O EF Core (02) traz produtividade e migrations; o Dapper (03–05) dá controle total do SQL. Saber quando usar cada um importa.
- **Validação na entrada.** O FluentValidation deixa as regras explícitas e testáveis, em vez de `if`s espalhados pelos controllers.

---

## ▶️ Como rodar

```bash
cd 05-clientes-api/ClientesApp.API
docker compose up -d     # sobe o SQL Server
dotnet run
```

Os projetos de console (01, 03, 04) rodam com `dotnet run` dentro da pasta do `.csproj`.

> ℹ️ Senhas de banco e a chave JWT da `usuarios-api` estão fixas por serem **didáticas**. Em produção, ficariam em *User Secrets* ou variáveis de ambiente.

---

<p align="center">
  Repositório organizado a partir dos repositórios originais de cada projeto, com o <b>histórico de commits preservado</b>.<br/>
  <a href="https://github.com/marcusrdrigues">← Voltar ao perfil</a>
</p>

<div align="center">
  <img src="https://capsule-render.vercel.app/api?type=waving&color=0:241773,100:000000&height=90&section=footer" width="100%" />
</div>
