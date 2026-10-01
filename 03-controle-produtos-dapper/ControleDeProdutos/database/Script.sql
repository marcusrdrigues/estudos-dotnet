-- Script para criar a tabela de produtos
CREATE TABLE PRODUTOS (
                          ID                  INT IDENTITY(1,1)   PRIMARY KEY,
                          NOME                VARCHAR(150)        NOT NULL,
                          PRECO               DECIMAL(10,2)       NOT NULL,
                          QUANTIDADE          INT                 NOT NULL,
                          CATEGORIA           VARCHAR(15)         NOT NULL,
                          DATAHORACADASTRO    DATETIME            DEFAULT GETDATE(),

                          CONSTRAINT CHK_CATEGORIA
                              CHECK(CATEGORIA IN(
                                                 'Informatica',
                                                 'Eletronicos',
                                                 'Vestuario',
                                                 'Livraria',
                                                 'Outros')),

                          CONSTRAINT CHK_PRECO
                              CHECK(PRECO > 0),

                          CONSTRAINT CHK_QUANTIDADE
                              CHECK(QUANTIDADE >= 0)
);

SELECT * FROM PRODUTOS;