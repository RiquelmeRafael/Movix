# 🎬 Movix

> **Plataforma Moderna de Catálogo e Gestão de Filmes**

![Status](https://img.shields.io/badge/Status-Concluído-success)
![.NET](https://img.shields.io/badge/.NET-9.0-purple)
![Docker](https://img.shields.io/badge/Docker-Ready-blue)
![Build](https://img.shields.io/github/actions/workflow/status/RiquelmeRafael/Movix/ci.yml)

O **Movix** é uma aplicação web completa desenvolvida com as melhores práticas de engenharia de software, utilizando **Clean Architecture** e **.NET 9**. O projeto oferece uma experiência fluida para usuários explorarem filmes e um painel administrativo robusto para gestão de conteúdo.

---

## 📸 Demonstração

### 🎥 Vídeo do Projeto
*(Espaço reservado para o vídeo de demonstração do sistema em funcionamento)*
<!-- Insira o link do vídeo ou gif aqui -->
> [!NOTE]
> Clique na imagem acima para ver o vídeo completo.

### 🖼️ Galeria

| Catálogo | Detalhes |
|:---:|:---:|
| <!-- Coloque a imagem do catálogo aqui --> ![Catalogo](https://via.placeholder.com/600x300?text=Catalogo+Movix) | <!-- Coloque a imagem de detalhes aqui --> ![Detalhes](https://via.placeholder.com/600x300?text=Detalhes+Filme) |

| Dashboard Admin | Gestão de Filmes |
|:---:|:---:|
| <!-- Coloque a imagem do dashboard aqui --> ![Dashboard](https://via.placeholder.com/600x300?text=Admin+Dashboard) | <!-- Coloque a imagem do CRUD aqui --> ![CRUD](https://via.placeholder.com/600x300?text=Gestao+Filmes) |

---

## 🚀 Tecnologias Utilizadas

O projeto foi construído sobre uma base sólida, visando escalabilidade, manutenibilidade e performance.

### **Backend & Core**
*   **[.NET 9](https://dotnet.microsoft.com/)**: Plataforma de desenvolvimento de alta performance.
*   **[ASP.NET Core MVC](https://asp.net/)**: Framework web robusto para renderização no servidor.
*   **[Entity Framework Core](https://docs.microsoft.com/ef/)**: ORM moderno para acesso a dados.
*   **[SQL Server](https://www.microsoft.com/sql-server)**: Banco de dados relacional.
*   **[xUnit](https://xunit.net/)**: Framework de testes unitários.

### **Arquitetura & Padrões**
*   **Clean Architecture**: Separação clara de responsabilidades (Domain, Application, Infrastructure, Web/Api).
*   **Repository Pattern**: Abstração da camada de dados.
*   **Dependency Injection**: Inversão de controle nativa do .NET.
*   **DTOs & ViewModels**: Transferência de dados segura e otimizada.

### **DevOps & Infraestrutura**
*   **[Docker](https://www.docker.com/)**: Containerização completa da aplicação e banco de dados.
*   **[Docker Compose](https://docs.docker.com/compose/)**: Orquestração multi-container.
*   **[GitHub Actions](https://github.com/features/actions)**: CI/CD para build e testes automatizados.

---

## 🛠️ Como Executar

Você pode rodar o projeto de duas formas: usando **Docker** (recomendado) ou manualmente com o **.NET CLI**.

### Opção 1: Docker (Recomendado 🐳)

Certifique-se de ter o Docker e Docker Compose instalados.

```bash
# 1. Clone o repositório
git clone https://github.com/RiquelmeRafael/Movix.git
cd Movix

# 2. Suba o ambiente completo (Banco + API + Site)
docker-compose up --build
```

Acesse em seu navegador:
*   **Site:** `http://localhost:5001`
*   **API:** `http://localhost:5000/swagger`

### Opção 2: Manualmente (.NET CLI)

Pré-requisitos: .NET SDK 9.0 e SQL Server rodando localmente.

1.  **Configure a ConnectionString** no `appsettings.json` da `Movix.Web` e `Movix.Api`.
2.  **Rode as migrações** para criar o banco:
    ```bash
    dotnet ef database update --project Movix.Infrastructure --startup-project Movix.Web
    ```
3.  **Inicie a aplicação**:
    ```bash
    dotnet run --project Movix.Web
    ```

---

## 🏗️ Estrutura do Projeto

A solução segue a **Clean Architecture**:

*   **`Movix.Domain`**: O coração do sistema. Contém as Entidades (`Filme`, `Genero`) e regras de negócio puras. Zero dependências.
*   **`Movix.Application`**: Casos de uso, Interfaces de Repositórios e DTOs. Orquestra a lógica.
*   **`Movix.Infrastructure`**: Implementação concreta. Banco de dados (EF Core), Migrations, Repositórios.
*   **`Movix.Web`**: Interface do usuário (MVC), Controllers, Views Razor.
*   **`Movix.Api`**: API RESTful para integração externa ou consumo por outros frontends.
*   **`Movix.Tests`**: Testes automatizados para garantir a qualidade.

---

## 🤝 Contribuindo

Contribuições são bem-vindas! Sinta-se à vontade para abrir Issues ou enviar Pull Requests.

1.  Faça um Fork do projeto
2.  Crie uma Branch para sua Feature (`git checkout -b feature/MinhaFeature`)
3.  Faça o Commit (`git commit -m 'Adicionando nova feature'`)
4.  Faça o Push (`git push origin feature/MinhaFeature`)
5.  Abra um Pull Request

---

## 📄 Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---

<div align="center">
  <sub>Desenvolvido com 💙 por <a href="https://github.com/RiquelmeRafael">Rafael Riquelme</a></sub>
</div>
