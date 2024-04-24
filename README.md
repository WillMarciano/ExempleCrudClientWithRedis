# ExempleCrudClientWithRedis

## Descrição

Este projeto é uma aplicação CRUD simples que utiliza o Redis como banco de dados. 
É uma aplicação simples de gerenciamento de clientes. O usuário pode criar, ler, atualizar e excluir clientes.
Nesse exemplo estou demostrando como gerar o Redis através do docker, caso já tenha instalado o Redis 

## Tecnologias utilizadas

- Dotnet Core 8.0
- Redis

## Programas necessários

- Dotnet Core 8.0
- Redis
- Docker for Desktop

## Como rodar o projeto

1. tenha o Docker for Desktop instalado			
2. Abra o terminal e execute o comando `docker run --name local-redis -p 6379:6379 -d redis`
4. para confirmar que o contariner está rodando execute o comando `docker ps`			
5. Vamos testar a conexão com o Redis, execute o comando `docker exec -it local-redis sh` e depois execute o comando `redis-cli`
6. Você verá o sinal # indicando que entrou no contêiner, digite o comando `ping`
7. Caso a resposta seja `PONG` o Redis está funcionando corretamente

![image](https://github.com/WillMarciano/ExempleCrudClientWithRedis/assets/34887614/a047120f-023c-42ac-860b-e5aa96b8bbfa)	
   
8. Clone o repositório `git clone https://github.com/WillMarciano/ExempleCrudClientWithRedis.git`
9. Caso tenha istalado o Redis em outra porta configure a ConnectionString do AppSettings conforme sua configuração
    ![image](https://github.com/WillMarciano/ExempleCrudClientWithRedis/assets/34887614/68e81e6d-b694-4534-9f47-0d29eaa59984)
 
10. Abra o projeto no Visual Studio Code ou Visual Studio
11. Execute o projeto

![image](https://github.com/WillMarciano/ExempleCrudClientWithRedis/assets/34887614/99887094-c5a3-45ad-a616-81b572e07c54)

12. Testando adicionando Cliente, estou fazendo pelo proprio swagger, pode testar no Postman ou Insomia caso deseje
    

    ![image](https://github.com/WillMarciano/ExempleCrudClientWithRedis/assets/34887614/32ded615-5f36-4fe5-aabc-5a113a56b879)

    ![image](https://github.com/WillMarciano/ExempleCrudClientWithRedis/assets/34887614/00ee8754-28f3-481e-83d9-e9f8956d3e76)


14. Uma vez adicionado Para Visualizar no Redis o que foi salvo abra o cmd e rode o passo 5 novamente
15. Digite o comando `get 0` , esse comando pega a chave que foi cadastrada do id, no meu caso 0

    ![image](https://github.com/WillMarciano/ExempleCrudClientWithRedis/assets/34887614/3f26cfc3-8109-4271-a709-5e03c874d7ab)




