INSERT INTO dbo.Empresa
(
    Nome
)
VALUES
('Empresa 1'),('Empresa 2'),('Empresa 3'),('Empresa 4'),('Empresa 5')

INSERT INTO dbo.Cliente
(
    Id,
    Email,
    EmpresaId,
    Nome,
    Telefone,
    VendedorCodigo
)
VALUES
(   
	1,   -- Id - int
    N'cliente1@email.com', -- Email - nvarchar(450)
    1,   -- EmpresaId - int
    N'Cliente 1', -- Nome - nvarchar(max)
    N'85858585', -- Telefone - nvarchar(max)
    N'123'  -- VendedorCodigo - nvarchar(max)
),
(   
	2,   -- Id - int
    N'cliente2@email.com', -- Email - nvarchar(450)
    2,   -- EmpresaId - int
    N'Cliente 2', -- Nome - nvarchar(max)
    N'85858585', -- Telefone - nvarchar(max)
    N'123'  -- VendedorCodigo - nvarchar(max)
),
(   
	3,   -- Id - int
    N'cliente3@email.com', -- Email - nvarchar(450)
    3,   -- EmpresaId - int
    N'Cliente 3', -- Nome - nvarchar(max)
    N'85858585', -- Telefone - nvarchar(max)
    N'123'  -- VendedorCodigo - nvarchar(max)
),
(   
	4,   -- Id - int
    N'cliente4@email.com', -- Email - nvarchar(450)
    4,   -- EmpresaId - int
    N'Cliente 4', -- Nome - nvarchar(max)
    N'85858585', -- Telefone - nvarchar(max)
    N'123'  -- VendedorCodigo - nvarchar(max)
)


INSERT INTO dbo.Usuarios
(
    Login,
    Senha
)
VALUES
(   N'irineu1', 
    N'123'  
    ),
	(   N'irineu2', 
    N'123'  
    ),
	(   N'irineu3', 
    N'123'  
    )

INSERT INTO	dbo.Responsavel
(
    Nome,
    UsuarioId
)
VALUES
(   
	N'reposavel irineu 1', 
    1
),
(   
	N'reposavel irineu 2', 
    2
),(   
	N'reposavel irineu 3', 
    3
)


INSERT INTO dbo.Cliente
(
    Id,
    Email,
    EmpresaId,
    Nome,
    Telefone,
    VendedorCodigo
)
VALUES
(   
	1,
	N'email@email.com', 
    1,   
    N'Clente 1',
    N'8585858585',
	'123'
),(  
	2,
	N'email@email.com', 
    2,   
    N'Clente 2',
    N'8585858585',
	'123'
),(   
	3,
	N'email@email.com', 
    3,   
    N'Clente 3',
    N'8585858585',
	'123'
),(   
	4,
	N'email@email.com', 
    4,   
    N'Clente 4',
    N'8585858585',
	'123'
),(   
	5,
	N'email@email.com', 
    5,   
    N'Clente 5',
    N'8585858585',
	'123'
)

INSERT INTO dbo.Solucao
(
    Descricao,
    Nome
)
VALUES
(   N'se vc nao sabe nem eu ', -- Descricao - nvarchar(max)
    N'Irineu'  -- Nome - nvarchar(max)
    ),
	(   N'se vc nao sabe nem eu2 ', -- Descricao - nvarchar(max)
    N'Irineu2'  -- Nome - nvarchar(max)
    )

INSERT INTO dbo.Atendimento
(
    ClienteEmail,
    ClienteId,
    ClienteId1,
    DataCriacao,
    DataFinalizacao,
    Descricao,
    EmpresaId,
    HoraCriacao,
    HoraFinalizacao,
    ResponsavelId,
    Resultado,
    SolucaoId,
    StatusAtendimento
)
VALUES
(   N'email@email.com',           -- ClienteEmail - nvarchar(450)
    1,             -- ClienteId - int
    1,             -- ClienteId1 - int
    GETDATE(), -- DataCriacao - datetime2(7)
    GETDATE(), -- DataFinalizacao - datetime2(7)
    N'descrcao descrcao ',           -- Descricao - nvarchar(max)
    1,             -- EmpresaId - int
    '00:31:41',    -- HoraCriacao - time(7)
    '00:31:41',    -- HoraFinalizacao - time(7)
    1,             -- ResponsavelId - int
    1,             -- Resultado - int
    1,             -- SolucaoId - int
    1              -- StatusAtendimento - int
    ),
	(   N'email@email.com',           -- ClienteEmail - nvarchar(450)
    2,             -- ClienteId - int
    2,             -- ClienteId1 - int
    GETDATE(), -- DataCriacao - datetime2(7)
    GETDATE(), -- DataFinalizacao - datetime2(7)
    N'descrcao descrcao ',           -- Descricao - nvarchar(max)
    2,             -- EmpresaId - int
    '00:31:41',    -- HoraCriacao - time(7)
    '00:31:41',    -- HoraFinalizacao - time(7)
    2,             -- ResponsavelId - int
    2,             -- Resultado - int
    2,             -- SolucaoId - int
    2              -- StatusAtendimento - int
    )
