﻿INSERT INTO CATEGORIA(ID, DESCRICAO)
VALUES
	(NEWID(), 'FAMÍLIA'),
	(NEWID(), 'TRABALHO'),
	(NEWID(), 'ESTUDO'),
	(NEWID(), 'LAZER'),
	(NEWID(), 'OUTROS');
GO

SELECT ID, DESCRICAO
FROM CATEGORIA
ORDER BY DESCRICAO;
GO


