# AdaTech.POO.ProjetoExtra
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)

Este é um projeto extra do módulo 2 (POO 1) do curso Back-end C# da AdaTech em parceria com a empresa Mercado Eletrônico. **Esse projeto foi feito completamente em C# focando em se limitar aos conceitos abordados no módulo**.

**STATUS: INTERAÇÃO COM O USUÁRIO AINDA EM DESENVOLVIMENTO**

## Table of Contents

- [Uso](#uso)
- [Documentação](#documentação)
- [Sobre a aplicação](#sobre-a-aplicação)
- [Lógica e estrutura do projeto explicada](#lógica-e-estrutura-do-projeto-explicada)


## Uso

1. Dê git clone do repositório na sua máquina
2. dê o comando dotnet run

## Documentação
Diagrama de casos de uso, diagrama de sequência, diagrama de classes e de estados estão disponíveis aqui: https://drive.google.com/drive/folders/1wAfqn73Cddi1PJXwnI_sWYN2TwPqFJY-?usp=sharing


## Conceitos do módulo que foram aplicados

1. 

## Sobre a aplicação



## Lógica e estrutura do projeto explicada

A estrutura do projeto foi dividida em 6 partes pastas:
```
root/
|-- Data/ -> contém uma classe de acesso direto ao banco de dados e todos os arquivos de dados
|
|-- Exceptions/ -> contém exceções personalizadas
|
|-- Model/ -> contém classes de modelagem de entidades, incluindo enums
|
|-- Services/ -> contém classes que centralizam ações sobre determinado modelo (entidade) e que tem contato direito com os repositories (da pasta Data)
|
|-- UserInterface -> contém classes que controlam a lógica da interface do console
|
|-- Utilities -> contém uma única classe estática que contém métodos úteis
|
|-- Program.cs -> inicialização do projeto
```
Program inicia o programa, alimenta a base de dados e chama a LandingPage (da pasta UserInterface). A LandingPage redireciona para a interface devida de acordo com as escolhas do usuário. As classes de UserInterface apenas fazem solicitações às classes de Services, de forma a centralizar as ações.

