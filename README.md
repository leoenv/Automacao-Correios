## Tecnologias utilizadas no projeto

- C#
- .NET 5.0
- IDE de Desenvolvimento - Visual Studio
- NUnit
- Selenium 

## Abrindo o projeto (Baseado no uso do Visual Studio)

1. Baixar o projeto
2. Abrir Visual Studio 
3. Clicar em "File"
4. Clicar em "Open"
5. Selecinar a pasta raiz do projeto
6. Selecionar o arquivo com a extensão .sln
7. Clicar em "OK"
8. O projeto será carregado e as dependências serão baixadas automaticamente. Aguardar até o fim.

## Arquitetura

A arquitetura padrão composta por:

- `Core`: Pacote que contém as classes pai, que definem comportamentos ou contém implementações que serão extendidas pelas classes filhas. As já existentes são:
  - **Begin:** Classe que contém tanto os métodos iniciais quanto finais na execução de cada teste
  - **DSL:** Classe que contém os métodos de interação dos testes UI
  - **GlobalVariables:** Classe que contém as variáveis globais
- `Driver`: Pacote que contém o arquivo chromedriver referente ao navegador utilizado nos testes (Verificar se a versão do arquivo é compatível ao do navegador utilizado no teste)
- `Page`: Pacote que contém as classes dos respectivos testes, aonde terão os métodos que serão utilizados nos testes para inserir valores para interação 
- `ScreenshotReport`: Pacote que irá armazenar os screenshots contendo as evidências do resultado dos testes
- `Test`: Pacote que contém as classes dos testes
