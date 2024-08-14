/****** Object:  Table [dbo].[SGESTRUCTURASM_DETALLE]    Script Date: 14/08/2024 10:14:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SGESTRUCTURASM_DETALLE](
	[EstructuraMenuDetalleID] [smallint] IDENTITY(1,1) NOT NULL,
	[EstructuraMenuID] [smallint] NOT NULL,
	[ModuloID] [smallint] NOT NULL,
	[ModuloPadreID] [smallint] NULL,
PRIMARY KEY CLUSTERED 
(
	[EstructuraMenuDetalleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SGFUNCIONES]    Script Date: 14/08/2024 10:14:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SGFUNCIONES](
	[SGFuncionID] [smallint] IDENTITY(1,1) NOT NULL,
	[SGFuncionNombre] [varchar](40) NOT NULL,
	[SGFuncionDescripcion] [varchar](255) NOT NULL,
	[SGFuncionConsultar] [bit] NOT NULL,
	[SGFuncionNuevo] [bit] NOT NULL,
	[SGFuncionEliminar] [bit] NOT NULL,
	[SGFuncionRecuperar] [bit] NOT NULL,
	[SGFuncionModificar] [bit] NOT NULL,
	[SGFuncionListar] [bit] NOT NULL,
	[SGFuncionExportar] [bit] NOT NULL,
	[SGFuncionGraficar] [bit] NOT NULL,
	[SGFuncionActivo] [bit] NOT NULL,
	[SGFuncionOLEDLL] [varchar](100) NOT NULL,
	[SGFuncionWeb] [varchar](1000) NOT NULL,
	[SGFuncionPrimaria] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SGFuncionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SGFUNCIONESMODULO]    Script Date: 14/08/2024 10:14:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SGFUNCIONESMODULO](
	[SGFuncionModuloID] [smallint] IDENTITY(1,1) NOT NULL,
	[EstructuraMenuID] [smallint] NOT NULL,
	[ModuloID] [smallint] NOT NULL,
	[SGFuncionID] [smallint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SGFuncionModuloID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SGMODULOS]    Script Date: 14/08/2024 10:14:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SGMODULOS](
	[ModuloID] [smallint] IDENTITY(1,1) NOT NULL,
	[ModuloNombre] [varchar](40) NOT NULL,
	[ModuloActivo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ModuloID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SGPERFILES]    Script Date: 14/08/2024 10:14:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SGPERFILES](
	[PerfilID] [smallint] IDENTITY(1,1) NOT NULL,
	[PerfilNombre] [varchar](40) NOT NULL,
	[EstructuraMenuID] [smallint] NOT NULL,
	[PlataformaID] [smallint] NOT NULL,
	[CreaUserID] [smallint] NOT NULL,
	[CreaDate] [datetime] NOT NULL,
	[ModifiUserID] [smallint] NULL,
	[ModifiDate] [datetime] NULL,
	[Activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[PerfilID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SGPERFILESDETALLE]    Script Date: 14/08/2024 10:14:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SGPERFILESDETALLE](
	[PerfilDetalleID] [smallint] IDENTITY(1,1) NOT NULL,
	[PerfilID] [smallint] NOT NULL,
	[ModuloID] [smallint] NOT NULL,
	[SGFuncionID] [smallint] NOT NULL,
	[PerfilConsultar] [bit] NOT NULL,
	[PerfilNuevo] [bit] NOT NULL,
	[PerfilEliminar] [bit] NOT NULL,
	[PerfilRecuperar] [bit] NOT NULL,
	[PerfilModificar] [bit] NOT NULL,
	[PerfilListar] [bit] NOT NULL,
	[PerfilExportar] [bit] NOT NULL,
	[PerfilGraficar] [bit] NOT NULL,
	[CreaUserID] [smallint] NOT NULL,
	[CreaDate] [datetime] NOT NULL,
	[ModifiUserID] [smallint] NULL,
	[ModifiDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[PerfilDetalleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_MENU]    Script Date: 14/08/2024 10:14:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_MENU]
AS
SELECT DISTINCT P.PerfilID, 'M' Nodo, EstructuraMenuDetalleID Cvo, ModuloPadreID AS PadreID, PD.ModuloID IDMenu, ModuloNombre Nombre, ModuloNombre Descripcion, '' Web
FROM        SGPERFILESDETALLE PD LEFT JOIN
                  SGPERFILES P ON P.PerfilID = PD.PerfilID LEFT JOIN
                  SGMODULOS M ON M.ModuloID = PD.ModuloID LEFT JOIN
                  SGFUNCIONES F ON F.SGFuncionID = PD.SGFuncionID LEFT JOIN
                  SGESTRUCTURASM_DETALLE ED ON ED.EstructuraMenuID = P.EstructuraMenuID AND ED.ModuloID = PD.ModuloID
GROUP BY P.PerfilID, EstructuraMenuDetalleID, ModuloPadreID, PD.ModuloID, ModuloNombre
UNION
SELECT     P.PerfilID, 'F' Nodo, SGFuncionModuloID Cvo, PD.ModuloID AS PadreID, F.SGFuncionID IDMenu, SGFuncionNombre Nombre, SGFuncionDescripcion Descripcion, SGFuncionWeb Web
FROM        SGPERFILESDETALLE PD LEFT JOIN
                  SGPERFILES P ON P.PerfilID = PD.PerfilID LEFT JOIN
                  SGMODULOS M ON M.ModuloID = PD.ModuloID LEFT JOIN
                  SGFUNCIONES F ON F.SGFuncionID = PD.SGFuncionID LEFT JOIN
                  SGFUNCIONESMODULO FM ON FM.EstructuraMenuID = P.EstructuraMenuID AND FM.ModuloID = PD.ModuloID AND FM.SGFuncionID = PD.SGFuncionID
GO
/****** Object:  View [dbo].[VW_MENU_ITEMS]    Script Date: 14/08/2024 10:14:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_MENU_ITEMS]
AS
SELECT  ROW_NUMBER() OVER (ORDER BY PadreID, Cvo ASC) AS ItemID, * FROM VW_MENU
GO
/****** Object:  Table [dbo].[SGESTRUCTURAMENU]    Script Date: 14/08/2024 10:14:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SGESTRUCTURAMENU](
	[EstructuraMenuID] [smallint] IDENTITY(1,1) NOT NULL,
	[EstructuraMenuDescripcion] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EstructuraMenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SGFUNCIONEVENTOS]    Script Date: 14/08/2024 10:14:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SGFUNCIONEVENTOS](
	[SGFuncionEventoID] [smallint] NOT NULL,
	[SGFuncionEventoTag] [varchar](20) NULL,
	[SGFuncionEvento] [varchar](255) NULL,
	[SGFuncionID] [smallint] NULL,
 CONSTRAINT [PK_SGFUNCIONEVENTOS] PRIMARY KEY CLUSTERED 
(
	[SGFuncionEventoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SGPLATAFORMA]    Script Date: 14/08/2024 10:14:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SGPLATAFORMA](
	[PlataformaID] [smallint] IDENTITY(1,1) NOT NULL,
	[PlataformaNombre] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PlataformaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SGSETTINGS]    Script Date: 14/08/2024 10:14:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SGSETTINGS](
	[SGSettingID] [smallint] IDENTITY(1,1) NOT NULL,
	[SGSettingNombre] [varchar](50) NOT NULL,
	[SGSettingsID] [smallint] NOT NULL,
	[SGSettingValorTexto] [varchar](50) NOT NULL,
	[SGSettingValorFecha] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SGSettingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SGSETTINGSC]    Script Date: 14/08/2024 10:14:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SGSETTINGSC](
	[SGSettingcID] [smallint] IDENTITY(1,1) NOT NULL,
	[SGSettingcNombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SGSettingcID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SGSETTINGSS]    Script Date: 14/08/2024 10:14:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SGSETTINGSS](
	[SGSettingsID] [smallint] IDENTITY(1,1) NOT NULL,
	[SGSettingsNombre] [varchar](50) NOT NULL,
	[SGSettingcID] [smallint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SGSettingsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SGUSRPERFIL]    Script Date: 14/08/2024 10:14:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SGUSRPERFIL](
	[SgUsrPerfilID] [smallint] IDENTITY(1,1) NOT NULL,
	[SgUserID] [smallint] NOT NULL,
	[PerfilID] [smallint] NOT NULL,
	[CreaUserID] [smallint] NOT NULL,
	[CreaDate] [datetime] NOT NULL,
	[ModifiUserID] [smallint] NULL,
	[ModifiDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[SgUsrPerfilID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SGUSUARIOS]    Script Date: 14/08/2024 10:14:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SGUSUARIOS](
	[SgUserID] [smallint] IDENTITY(1,1) NOT NULL,
	[SgUserName] [varchar](100) NOT NULL,
	[SgUserEmail] [varchar](256) NOT NULL,
	[SgUserPasswd] [varchar](50) NOT NULL,
	[SgNombre] [varchar](40) NOT NULL,
	[SgApellidos] [varchar](60) NOT NULL,
	[SgUserAlta] [datetime] NOT NULL,
	[CreaUserID] [smallint] NOT NULL,
	[CreaDate] [datetime] NOT NULL,
	[ModifiUserID] [smallint] NULL,
	[ModifiDate] [datetime] NULL,
	[SgActivo] [bit] NULL,
	[ErpHost] [nvarchar](30) NULL,
	[ErpUser] [nvarchar](30) NULL,
	[ErpPasswd] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[SgUserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[SGPERFILES] ADD  CONSTRAINT [DF_SGPERFILES_CreaDate]  DEFAULT (getdate()) FOR [CreaDate]
GO
ALTER TABLE [dbo].[SGPERFILES] ADD  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[SGPERFILESDETALLE] ADD  DEFAULT (getdate()) FOR [CreaDate]
GO
ALTER TABLE [dbo].[SGUSRPERFIL] ADD  DEFAULT (getdate()) FOR [CreaDate]
GO
ALTER TABLE [dbo].[SGUSUARIOS] ADD  DEFAULT (getdate()) FOR [CreaDate]
GO
ALTER TABLE [dbo].[SGUSUARIOS] ADD  CONSTRAINT [DF_SGUSUARIOS_SgActivo]  DEFAULT ((1)) FOR [SgActivo]
GO
ALTER TABLE [dbo].[SGESTRUCTURASM_DETALLE]  WITH CHECK ADD  CONSTRAINT [ISGESTRUCTURASM_DETALLE1] FOREIGN KEY([ModuloID])
REFERENCES [dbo].[SGMODULOS] ([ModuloID])
GO
ALTER TABLE [dbo].[SGESTRUCTURASM_DETALLE] CHECK CONSTRAINT [ISGESTRUCTURASM_DETALLE1]
GO
ALTER TABLE [dbo].[SGESTRUCTURASM_DETALLE]  WITH CHECK ADD  CONSTRAINT [ISGESTRUCTURASM_DETALLE2] FOREIGN KEY([EstructuraMenuID])
REFERENCES [dbo].[SGESTRUCTURAMENU] ([EstructuraMenuID])
GO
ALTER TABLE [dbo].[SGESTRUCTURASM_DETALLE] CHECK CONSTRAINT [ISGESTRUCTURASM_DETALLE2]
GO
ALTER TABLE [dbo].[SGESTRUCTURASM_DETALLE]  WITH CHECK ADD  CONSTRAINT [ISGESTRUCTURASM_DETALLE3] FOREIGN KEY([ModuloPadreID])
REFERENCES [dbo].[SGMODULOS] ([ModuloID])
GO
ALTER TABLE [dbo].[SGESTRUCTURASM_DETALLE] CHECK CONSTRAINT [ISGESTRUCTURASM_DETALLE3]
GO
ALTER TABLE [dbo].[SGFUNCIONESMODULO]  WITH CHECK ADD  CONSTRAINT [ISGFUNCIONESMODULO1] FOREIGN KEY([SGFuncionID])
REFERENCES [dbo].[SGFUNCIONES] ([SGFuncionID])
GO
ALTER TABLE [dbo].[SGFUNCIONESMODULO] CHECK CONSTRAINT [ISGFUNCIONESMODULO1]
GO
ALTER TABLE [dbo].[SGFUNCIONESMODULO]  WITH CHECK ADD  CONSTRAINT [ISGFUNCIONESMODULO2] FOREIGN KEY([ModuloID])
REFERENCES [dbo].[SGMODULOS] ([ModuloID])
GO
ALTER TABLE [dbo].[SGFUNCIONESMODULO] CHECK CONSTRAINT [ISGFUNCIONESMODULO2]
GO
ALTER TABLE [dbo].[SGFUNCIONESMODULO]  WITH CHECK ADD  CONSTRAINT [ISGFUNCIONESMODULO3] FOREIGN KEY([EstructuraMenuID])
REFERENCES [dbo].[SGESTRUCTURAMENU] ([EstructuraMenuID])
GO
ALTER TABLE [dbo].[SGFUNCIONESMODULO] CHECK CONSTRAINT [ISGFUNCIONESMODULO3]
GO
ALTER TABLE [dbo].[SGFUNCIONEVENTOS]  WITH CHECK ADD  CONSTRAINT [FK_SGFUNCIONEVENTOS_SGFUNCIONES] FOREIGN KEY([SGFuncionID])
REFERENCES [dbo].[SGFUNCIONES] ([SGFuncionID])
GO
ALTER TABLE [dbo].[SGFUNCIONEVENTOS] CHECK CONSTRAINT [FK_SGFUNCIONEVENTOS_SGFUNCIONES]
GO
ALTER TABLE [dbo].[SGPERFILES]  WITH CHECK ADD  CONSTRAINT [ISGPERFILES1] FOREIGN KEY([EstructuraMenuID])
REFERENCES [dbo].[SGESTRUCTURAMENU] ([EstructuraMenuID])
GO
ALTER TABLE [dbo].[SGPERFILES] CHECK CONSTRAINT [ISGPERFILES1]
GO
ALTER TABLE [dbo].[SGPERFILES]  WITH CHECK ADD  CONSTRAINT [ISGPERFILES2] FOREIGN KEY([PlataformaID])
REFERENCES [dbo].[SGPLATAFORMA] ([PlataformaID])
GO
ALTER TABLE [dbo].[SGPERFILES] CHECK CONSTRAINT [ISGPERFILES2]
GO
ALTER TABLE [dbo].[SGPERFILESDETALLE]  WITH CHECK ADD  CONSTRAINT [ISGPERFILESDETALLE1] FOREIGN KEY([SGFuncionID])
REFERENCES [dbo].[SGFUNCIONES] ([SGFuncionID])
GO
ALTER TABLE [dbo].[SGPERFILESDETALLE] CHECK CONSTRAINT [ISGPERFILESDETALLE1]
GO
ALTER TABLE [dbo].[SGPERFILESDETALLE]  WITH CHECK ADD  CONSTRAINT [ISGPERFILESDETALLE2] FOREIGN KEY([ModuloID])
REFERENCES [dbo].[SGMODULOS] ([ModuloID])
GO
ALTER TABLE [dbo].[SGPERFILESDETALLE] CHECK CONSTRAINT [ISGPERFILESDETALLE2]
GO
ALTER TABLE [dbo].[SGPERFILESDETALLE]  WITH CHECK ADD  CONSTRAINT [ISGPERFILESDETALLE3] FOREIGN KEY([PerfilID])
REFERENCES [dbo].[SGPERFILES] ([PerfilID])
GO
ALTER TABLE [dbo].[SGPERFILESDETALLE] CHECK CONSTRAINT [ISGPERFILESDETALLE3]
GO
ALTER TABLE [dbo].[SGSETTINGS]  WITH CHECK ADD  CONSTRAINT [FK_SGSETTINGS_SGSETTINGSS] FOREIGN KEY([SGSettingsID])
REFERENCES [dbo].[SGSETTINGSS] ([SGSettingsID])
GO
ALTER TABLE [dbo].[SGSETTINGS] CHECK CONSTRAINT [FK_SGSETTINGS_SGSETTINGSS]
GO
ALTER TABLE [dbo].[SGSETTINGSS]  WITH CHECK ADD  CONSTRAINT [FK_SGSETTINGSS_SGSETTINGSC] FOREIGN KEY([SGSettingcID])
REFERENCES [dbo].[SGSETTINGSC] ([SGSettingcID])
GO
ALTER TABLE [dbo].[SGSETTINGSS] CHECK CONSTRAINT [FK_SGSETTINGSS_SGSETTINGSC]
GO
ALTER TABLE [dbo].[SGUSRPERFIL]  WITH CHECK ADD  CONSTRAINT [ISGUSRPERFIL1] FOREIGN KEY([PerfilID])
REFERENCES [dbo].[SGPERFILES] ([PerfilID])
GO
ALTER TABLE [dbo].[SGUSRPERFIL] CHECK CONSTRAINT [ISGUSRPERFIL1]
GO
ALTER TABLE [dbo].[SGUSRPERFIL]  WITH CHECK ADD  CONSTRAINT [ISGUSRPERFIL2] FOREIGN KEY([SgUserID])
REFERENCES [dbo].[SGUSUARIOS] ([SgUserID])
GO
ALTER TABLE [dbo].[SGUSRPERFIL] CHECK CONSTRAINT [ISGUSRPERFIL2]
GO
/****** Object:  StoredProcedure [dbo].[Ins_Estructura]    Script Date: 14/08/2024 10:14:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ernesto Alvarez Flores
-- Create date: 15/09/2022
-- Description:	Inserta nueva Estructura de Menu
-- =============================================
CREATE PROCEDURE [dbo].[Ins_Estructura]
	-- Add the parameters for the stored procedure here
	@EstructuraMenuDescripcion varchar(255), @EstructuraMenuID smallint output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @sMsgErr varchar(MAX)

	BEGIN TRANSACTION;	
	BEGIN TRY
		
		SET @EstructuraMenuID = 0
	    
		INSERT INTO SGESTRUCTURAMENU(EstructuraMenuDescripcion)
		 VALUES(@EstructuraMenuDescripcion)

		SET @EstructuraMenuID = SCOPE_IDENTITY()

	END TRY

	BEGIN CATCH
		SELECT @sMsgErr = CAST(ERROR_NUMBER() AS varchar(10)) + ' - ' + ERROR_MESSAGE() 
		RAISERROR (@sMsgErr, 16, 1) 
		IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION; 
	END CATCH

	IF @@TRANCOUNT > 0 COMMIT TRANSACTION;
	
	
END
GO
/****** Object:  StoredProcedure [dbo].[Ins_EstructuraDetalle]    Script Date: 14/08/2024 10:14:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ernesto Alvarez Flores
-- Create date: 12/10/2022
-- Description:	Inserta Modulos en una estructura de menu
-- =============================================
CREATE PROCEDURE [dbo].[Ins_EstructuraDetalle]
	-- Add the parameters for the stored procedure here
	@EstructuraMenuID smallint, @ModuloID smallint, @ModuloPadreID smallint, @EstructuraMenuDetalleID smallint output

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO SGESTRUCTURASM_DETALLE(EstructuraMenuID, ModuloID, ModuloPadreID)
     VALUES(@EstructuraMenuID, @ModuloID, @ModuloPadreID)

	 SET @EstructuraMenuDetalleID = SCOPE_IDENTITY()

	
END
GO
/****** Object:  StoredProcedure [dbo].[Ins_FuncionModulo]    Script Date: 14/08/2024 10:14:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ernesto Alvarez Flores
-- Create date: 13/10/2022
-- Description:	Inserta funciones modulo
-- =============================================
CREATE PROCEDURE [dbo].[Ins_FuncionModulo]
	-- Add the parameters for the stored procedure here
	@EstructuraMenuID smallint, @ModuloID smallint, @SGFuncionID smallint, @SGFuncionModuloID smallint output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO SGFUNCIONESMODULO(EstructuraMenuID, ModuloID, SGFuncionID)
		VALUES(@EstructuraMenuID, @ModuloID, @SGFuncionID)

		SET @SGFuncionModuloID = SCOPE_IDENTITY()
	
END
GO
/****** Object:  StoredProcedure [dbo].[Ins_Modulo]    Script Date: 14/08/2024 10:14:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ernesto Alvarez Flores
-- Create date: 08/09/2022
-- Description:	Inserta un nuevo modulo
-- =============================================
CREATE PROCEDURE [dbo].[Ins_Modulo]
	-- Add the parameters for the stored procedure here
	@ModuloNombre varchar(40), @ModuloActivo bit, @ModuloID smallint output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @sMsgErr varchar(MAX)

	BEGIN TRANSACTION;	
	BEGIN TRY
		
		SET @ModuloID = 0
	    
		INSERT INTO SGMODULOS(ModuloNombre, ModuloActivo)
		 VALUES(@ModuloNombre, @ModuloActivo)

		SET @ModuloID = SCOPE_IDENTITY()

	END TRY

	BEGIN CATCH
		SELECT @sMsgErr = CAST(ERROR_NUMBER() AS varchar(10)) + ' - ' + ERROR_MESSAGE() 
		RAISERROR (@sMsgErr, 16, 1) 
		IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION; 
	END CATCH

	IF @@TRANCOUNT > 0 COMMIT TRANSACTION;
	
	
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_MENU'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_MENU'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_MENU_ITEMS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_MENU_ITEMS'
GO
