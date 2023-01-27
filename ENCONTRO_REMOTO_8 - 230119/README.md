# README
## _Sobre o Programa Cadastro de Pessoa Fisica e Juridica_

A aplicação "Cadastro de Pessoa Física e Jurídica" foi desenvolvido como atividade do Curso de Programador Full Stack realizado no SENAI/SP na unidade curricular UC-12 - Codificação para Back-End. 
Está é um aplicação desenvolvida usando exclusivamente a linguagem C#, dentro dos conceitos de Programação orientada a objetos (P.O.O).

## Features

- Realizar o cadastro de pessoas Físicas e Jurídicas.
- Validar entrada de dados realizadas pelo usuário.
- Salvar os dados em arquivos tipo ".csv" e ".txt".
- Realizar a leitura destes dados nos arquivos e mostrá-los via PROMPT.

## Tech (Tecnologias utilizadas)

Todos os softwares e extenções utilizados no desenvolvimento são gratuitos, e a lista com os nomes e os respectivos links para download, estão disponíveis abaixo:

- [Visual Studio Code](https://code.visualstudio.com/download) 
- [.NET Coding Pack](https://aka.ms/dotnet-coding-pack-win)
- [.NET Software Development Kit](https://dotnet.microsoft.com/pt-br/download)

E repositório esta disponivel em [GitHub](https://github.com/Adriano-Mariot/UC12-ENCONTROS_REMOTO/tree/main/ENCONTRO_REMOTO_8%20-%20230119)

## Organização do projeto
O projeto possui três elementos da sua estrutura principal 
A pasta Interfaces onde estão localizados o escopo dos principais métodos de cada classe.
A pasta Classes onde as Objetos e métodos são implementados.
E o Arquivo Program.CS que é o arquivo onde o a aplicação foi implementada com a ajuda das classe e métodos criados nas pastas Classes. 


+ ENCONTRO REMOTO 8
    + Classes " Onde as classes forma Criadas "
        + Endereço.cs
        + Pessoa.cs
        + PessoaFisica.cs
        + PessuoJuridica.cs
        + Utils.cs
    + Interfaces
        + IPessoa.cs
        + IPessoaFisica.cs
        + IPessoaJuridica.cs
    + Program.CS
 
## Pré-requisitos de instalação

Não é necessário realizar instalação, somente garantir que os pacotes do .NET estejam instalados corretamente.

## Execução da aplicação
Para executar a aplicação, no terminal acesse a pasta da aplicação usando o seguinte código:
```sh
cd ENCONTRO_REMOTO_8-230119
```
Uma vez dentro do diretório correto execute o comando:
```sh
dotnet run
```

## Erros comuns
- A falta da instalação das extensões do .NET no Visual Studio Code impede o funcionamento da aplicação.
- A utilização de Pacotes do .NET desatualizados podem gerar erros, usar versão do NET 6.0 ou superior.
- Executar a aplicação em uma diretório diferente de onde está localizado o projeto, gera erros e a aplicação não funcionará, tenha certeza de estar usando o diretório correto.




