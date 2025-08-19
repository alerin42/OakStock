CREATE TABLE Produto (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(255) NOT NULL,
    Categoria VARCHAR(50) NOT NULL,
    Descricao TEXT,
    PrecoVenda DECIMAL(10,2) NOT NULL,
    QuantidadeEstoque INT NOT NULL,
    Fornecedor VARCHAR(255)
);
