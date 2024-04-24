# ExempleCrudClientWithRedis

## Descrição

Este projeto é uma aplicação CRUD simples que utiliza o Redis como banco de dados. 
É uma aplicação simples de gerenciamento de clientes. O usuário pode criar, ler, atualizar e excluir clientes.

## Tecnologias utilizadas

	- Dotnet Core 8.0
	- Redis

## Programas necessários

	- Dotnet Core 8.0
	- Redis
	- Docker for Desktop

## Como rodar o projeto

1. tenha o Docker for Desktop instalado			
2. Abra o terminal e execute o comando `docker run --name redis -p 6379:6379 -d redis`															
3. para confirmar que o contariner está rodando execute o comando `docker ps`			
4. Vamos testar a conexão com o Redis, execute o comando `docker exec -it redis redis-cli` e depois execute o comando `ping`
5. Caso a resposta seja `PONG` o Redis está funcionando corretamente
6. Clone o repositório `git clone https://github.com/WillMarciano/ExempleCrudClientWithRedis.git`		
7. Abra o projeto no Visual Studio Code ou Visual Studio
8. Execute o projeto

