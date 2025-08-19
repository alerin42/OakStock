CREATE TABLE Produto (
    Id INT IDENTITY(1,1) PRIMARY KEY,  -- Usando IDENTITY no SQL Server em vez de AUTO_INCREMENT
    Nome VARCHAR(255) NOT NULL,
    Categoria VARCHAR(50) NOT NULL,
    Descricao TEXT,
    PrecoVenda DECIMAL(10,2) NOT NULL,
    QuantidadeEstoque INT NOT NULL,
    Fornecedor VARCHAR(255)
);
