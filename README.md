# Grupo 14 - 6SOAT: Tech Challenge - FIAP

O principal objetivo deste projeto foi desenvolver uma solucao para gerenciar o cadastro, pedidos, produtos e fila de entrega, sendo um sistema de controle de pedidos.

# Preview
![Fluxo Principal](https://github.com/luiizmurdoki/6SOAT-TechChallenge-FIAP/blob/main/images/Apis.JPG)

## Pré requisitos:

-Possui o docker instalado na sua maquina https://docs.docker.com/desktop/

-Portas 5001,8080 e 80 não pode estar em utilização

## Iniciar o Projeto no docker
1 -Utilize o git clone na pasta a sua escolha para clonar o projeto:
```shell
git clone https://github.com/luiizmurdoki/6SOAT-TechChallenge-FIAP.git
```
obs: utilizar a branch main (default)

2- Acesse o path onde o docker compose esta localizado, na raiz do projeto:
```shell
cd ../6SOAT-TechChallenge-FIAP/
```

3- Execute o comando para subir os containers a partir do docker compose:
```shell
docker compose up
```

4- Após a inicialização dos containers acessar via browser o endereço https://localhost:5001/swagger/index.html para vizualizar o Swagger das APIs.


## [/Infra](https://github.com/luiizmurdoki/6SOAT-TechChallenge-FIAP/tree/main/Infra)
1- O arquivo [TechChallenge-Template.yaml](https://github.com/luiizmurdoki/6SOAT-TechChallenge-FIAP/blob/main/Infra/TechChallenge-Template.yaml) realiza o provisionamento dos recursos na AWS atraves do cloudformation

2- O arquivo [desafio.yml](https://github.com/luiizmurdoki/6SOAT-TechChallenge-FIAP/blob/main/Infra/desafio.yml) contem o codigo para deploy do kubernetes no EKS

![Diagrama da infraestrutura](https://github.com/luiizmurdoki/6SOAT-TechChallenge-FIAP/blob/main/images/InfraTechchallenge.jpg)

## Enums
Enum Status:

    PagamentoPendente = 0
    Recebido = 1
    EmPreparacao = 2
    Pronto = 3
    Finalizado = 4
    Cancelado = 5

Enum Categoria:

    Lanche = 1
    Acompanhamento = 2
    Bebida = 3
    Sobremesa = 4

## Schemas
Os exemplos de payload das APIs estão disponibilizados na aba de Schemas do Swagger para realizar as chamadas.
![Schemas](https://github.com/luiizmurdoki/6SOAT-TechChallenge-FIAP/blob/main/images/SchemasApi.png)


## Tecnologias

Aqui estao as tecnologias usadas nos projeto.

* .Net 8
* C#
* Docker
* Postgres
* DDD
* Arquitetura Hexagonal
 

## Servicos usados
 
* Github
* MIro
* Trello
 
## Versao
1.0.0


Obrigado pela visita e bom codigo!
