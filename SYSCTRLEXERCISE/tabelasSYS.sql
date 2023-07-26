﻿CREATE TABLE[dbo].[TB_APARELHO]
(
	[I_COD_APARELHO] INT IDENTITY(1,1) NOT NULL,
	[S_NM_APARELHO] VARCHAR (35) NOT NULL,
	[I_GP_APARELHO] INT NOT NULL,
	PRIMARY KEY CLUSTERED ([I_COD_APARELHO] ASC)
);

CREATE TABLE[dbo].[TB_PLANOMENSAL]
(
	[I_COD_PLANOMENSAL] INT IDENTITY(1,1) NOT NULL,
	[S_NM_PLANOMENSAL] VARCHAR (35) NOT NULL,
	[S_DESC_PLANOMENSAL] TEXT NOT NULL,
	[D_VLR_PLANOMENSAL] FLOAT NOT NULL,
	PRIMARY KEY CLUSTERED ([I_COD_PLANOMENSAL] ASC)
);

CREATE TABLE[dbo].[TB_CONVENIO]
(
	[I_COD_CONVENIO] INT IDENTITY(1,1) NOT NULL,
	[S_NM_CONVENIO] VARCHAR (35) NOT NULL,
	[S_NRO_CONVENIO] VARCHAR (15) NOT NULL,
	[I_TP_CONVENIO] INT  NOT NULL,
	[S_CAT_CONVENIO] VARCHAR (25) NOT NULL,
	PRIMARY KEY CLUSTERED ([I_COD_CONVENIO] ASC)
);

CREATE TABLE[dbo].[TB_PESSOA]
(
	[I_COD_PESSOA] INT IDENTITY(1,1) NOT NULL,
	[S_NM_PESSOA] VARCHAR (35) NOT NULL,
	[I_GEN_PESSOA] INT NOT NULL,
	[S_CPF_PESSOA] VARCHAR (14) NOT NULL,
	[S_CEL_PESSOA] VARCHAR (15) NOT NULL,
	[S_MAIL_PESSOA] VARCHAR (35) NOT NULL,
	[S_END_PESSOA] VARCHAR (40) NOT NULL,
	[S_BAI_PESSOA] VARCHAR (35) NOT NULL,
	[S_CID_PESSOA] VARCHAR (35) NOT NULL,
	[S_UF_PESSOA] VARCHAR (2) NOT NULL,
	[S_CEP_PESSOA] VARCHAR (8) NOT NULL
	PRIMARY KEY CLUSTERED ([I_COD_PESSOA] ASC)
);

CREATE TABLE[dbo].[TB_CLIENTE]
(
	[I_COD_CLIENTE] INT IDENTITY(1,1) NOT NULL,
	[I_COD_PESSOA] INT NOT NULL,
	[I_COD_PLANOMENSAL] INT NOT NULL,
	[I_COD_CONVENIO] INT NOT NULL,
	[S_MAT_CLIENTE] VARCHAR (10) NOT NULL,
	PRIMARY KEY CLUSTERED ([I_COD_CLIENTE] ASC),
	FOREIGN KEY ([I_COD_PESSOA]) REFERENCES [dbo].[TB_PESSOA] ([I_COD_PESSOA]),
	FOREIGN KEY ([I_COD_PLANOMENSAL]) REFERENCES [dbo].[TB_PLANOMENSAL] ([I_COD_PLANOMENSAL]),
	FOREIGN KEY ([I_COD_CONVENIO]) REFERENCES [dbo].[TB_CONVENIO] ([I_COD_CONVENIO])
);

CREATE TABLE[dbo].[TB_INSTRUTOR]
(
	[I_COD_INSTRUTOR] INT IDENTITY(1,1) NOT NULL,
	[I_COD_PESSOA] INT  NOT NULL,
	[I_PER_INSTRUTOR] INT  NOT NULL,
	PRIMARY KEY CLUSTERED ([I_COD_INSTRUTOR] ASC),
	FOREIGN KEY ([I_COD_PESSOA]) REFERENCES [dbo].[TB_PESSOA] ([I_COD_PESSOA])
);

CREATE TABLE[dbo].[TB_ACOMPANHAMENTO]
(
	[I_COD_ACOMPANHAMENTO] INT IDENTITY(1,1) NOT NULL,
	[I_COD_CLIENTE] INT  NOT NULL,
	[D_PESO_ACOMPANHAMENTO] FLOAT NOT NULL,
	[D_ALT_ACOMPANHAMENTO] FLOAT NOT NULL,
	[DT_AFER_ACOMPANHAMENTO] DATETIME NOT NULL,
	PRIMARY KEY CLUSTERED ([I_COD_ACOMPANHAMENTO] ASC),
	FOREIGN KEY ([I_COD_CLIENTE]) REFERENCES [dbo].[TB_CLIENTE] ([I_COD_CLIENTE])
);

CREATE TABLE[dbo].[TB_ITEMACOMPANHAMENTO]
(
	[I_COD_ITEMACOMPANHAMENTO] INT IDENTITY(1,1) NOT NULL,
	[I_COD_ACOMPANHAMENTO] INT  NOT NULL,
	[D_COXD_ITEMACOMPANHAMENTO] FLOAT NOT NULL,
	[D_COXE_ITEMACOMPANHAMENTO] FLOAT NOT NULL,
	[D_PANTUD_ITEMACOMPANHAMENTO] FLOAT NOT NULL,
	[D_PANTUE_ITEMACOMPANHAMENTO] FLOAT NOT NULL,
	[D_BICPD_ITEMACOMPANHAMENTO] FLOAT NOT NULL,
	[D_BICPE_ITEMACOMPANHAMENTO] FLOAT NOT NULL,
	[D_PEITO_ITEMACOMPANHAMENTO] FLOAT NOT NULL,
	PRIMARY KEY CLUSTERED ([I_COD_ITEMACOMPANHAMENTO] ASC),
	FOREIGN KEY ([I_COD_ACOMPANHAMENTO]) REFERENCES [dbo].[TB_ACOMPANHAMENTO] 	([I_COD_ACOMPANHAMENTO])
);

CREATE TABLE[dbo].[TB_PROGRAMA]
(
	[I_COD_PROGRAMA] INT IDENTITY(1,1) NOT NULL,
	[I_COD_CLIENTE] INT  NOT NULL,
	[I_COD_INSTRUTOR] INT NOT NULL,
	[S_NM_PROGRAMA] VARCHAR (35) NOT NULL,
	[DT_INI_PROGRAMA] DATETIME NOT NULL,
	[I_REP_PROGRAMA] INT NOT NULL,
	PRIMARY KEY CLUSTERED (I_COD_PROGRAMA ASC),
	FOREIGN KEY ([I_COD_CLIENTE]) REFERENCES [dbo].[TB_CLIENTE] ([I_COD_CLIENTE]),
	FOREIGN KEY ([I_COD_INSTRUTOR]) REFERENCES [dbo].[TB_INSTRUTOR] ([I_COD_INSTRUTOR])
);

CREATE TABLE[dbo].[TB_ITEMPROGRAMA]
(
	[I_COD_ITEMPROGRAMA] INT IDENTITY(1,1) NOT NULL,
	[I_COD_APARELHO] INT  NOT NULL,
	[S_NM_ITEMPROGRAMA] VARCHAR (35) NOT NULL,
	[S_REP_ITEMPROGRAMA] VARCHAR (35) NOT NULL,
	PRIMARY KEY CLUSTERED (I_COD_ITEMPROGRAMA ASC),
	FOREIGN KEY ([I_COD_APARELHO]) REFERENCES [dbo].[TB_APARELHO] ([I_COD_APARELHO])
);