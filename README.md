# Quinta Code: Boas Práticas na Construção de APIs com C#

Este repositório possui projetos de exemplo usados para a apresentação do Quinta Code de 25/03/2021: Boas Práticas na Construção de APIs com C#.

Para obter os slides que informam mais a respeito desta solução, basta contatar por e-mail o criador deste repositório.

# Instalação e outras informações

Todos os projetos da solução foram construídos com a versão 3.1 do .NET Core e 9.0 da linguagem C#, a partir do Visual Studio 2019.

O projeto de API Web se conecta com duas bases de dados: uma relacional para controle de usuários e logs em SQL Server, e outra não-relacional para armazenar o resultado de operações realizadas nos endpoints da API em MongoDB.

A base de dados relacional pode ser criada a partir das Migrations do Entity Framework Core, presentes no projeto de Data Access. 

A base de dados não-relacional chamada PokemonStatCalculator exige a criação prévia pela interface do MongoDB.

Por fim, a API Web pode ser consumida pelo projeto WebApiConsumer que é uma aplicação console.
