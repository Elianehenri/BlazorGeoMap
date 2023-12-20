# BlazorGeoMap


Este projeto foi desenvolvido como parte do desafio BlazorGeoMap. Ele inclui funcionalidades básicas de CRUD para localidades (cidades e estados do Brasil) com pesquisa e autenticação.

## Requisitos do Projeto

O projeto atende aos seguintes requisitos:
- Autenticação usando Identity.
- CRUD de Localidade (Código, Estado, Cidade -- Id, City, State).
- Pesquisa por cidade, estado e código (IBGE).
- Desenvolvido usando .NET 8.

## Estrutura do Projeto

O projeto está organizado da seguinte forma:

- `BlazorGeoMap`: Projeto Blazor Server contendo as páginas e componentes.

- `Data`: Pasta contendo o DbContext e modelos de dados.

- `Files`: Pasta contendo arquivos de esquema (schema.sql) e dados (data.sql).

- `Services`: Pasta contendo serviços adicionais, como o populador de dados.


## Configuração e Execução

1. Clone o repositório:
   ```bash
   git clone https://github.com/Elianehenri/BlazorGeoMap.git
   ```
2. Configuração do Banco de Dados

No arquivo `appsettings.json`, configure a string de conexão do banco de dados:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=seu-servidor;Database=sua-base-de-dados;User Id=seu-usuario;Password=sua-senha;"
  }
}
```
3. Execute o seguinte comando para criar o banco de dados:
  ```bash
dotnet ef database update
```

# Vídeo do projeto em execução
[Assista ao vídeo](https://drive.google.com/file/d/1fLCOiPQXOYTU5GBH1BNdtQCIIMMWeE45/view?pli=1)

 ### The Noobs - Grupo 05 
* [Eliane Henriqueta](https://github.com/Elianehenri)
* [Pedro Dummond](https://github.com/PeDrumond)
* [Henrique Luis Fogulari](https://github.com/Henriquehlf)
