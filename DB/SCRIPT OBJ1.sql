/* Script para aplicación
   SPCSystem

*/
CREATE TABLE ParameterDefinitions(
	ParameterID int primary key identity,
	ParameterName nvarchar(40),
	MaxLength smallint,
	DefaultValue nvarchar(30),
	UseInFunction smallint,
	AlwaysClear bit,
	ForceList bit,
	HasList bit,
	Activo bit default 1,
	CreaUserID smallint not null,
	CreaDate datetime default getdate(),
	ModifiUserID smallint,
	ModifiDate datetime	
)
GO

CREATE TABLE ParameterListQry(
	ParameterID int,
	Qry nvarchar(MAX),
	Activo bit default 1,
	CreaUserID smallint not null,
	CreaDate datetime default getdate(),
	ModifiUserID smallint,
	ModifiDate datetime
)
GO

CREATE TABLE ParameterListValues(
	ListEntryId int primary key identity,
	ParameterID int,
	TextValue nvarchar(40),
	Activo bit default 1,
	CreaUserID smallint not null,
	CreaDate datetime default getdate(),
	ModifiUserID smallint,
	ModifiDate datetime
)
GO

CREATE TABLE ParametersUsed(
	PartID int,
	ParameterID int,
	PresentOrder smallint
)
GO

CREATE TABLE DataGroups(
	DataGroupID int primary key identity,
	DataGroupDescription nvarchar(50),
	Activo bit default 1,
	CreaUserID smallint not null,
	CreaDate datetime default getdate(),
	ModifiUserID smallint,
	ModifiDate datetime	
)
GO

CREATE TABLE PartList(
	PartID int primary key identity,
	PartName nvarchar(50),
	DataGroupID int,
	Activo bit default 1,
	CreaUserID smallint not null,
	CreaDate datetime default getdate(),
	ModifiUserID smallint,
	ModifiDate datetime	
)
GO

CREATE TABLE CharList(
	CharID int primary key identity,
	PartID int,
	Characteristic nvarchar(50),
	Operation nvarchar(50),
	UserTitle nvarchar(50),
	UserField nvarchar(50),
	Comment nvarchar(255), 
	MeasureInst nvarchar(255),
	SubSize smallint,
	LSL nvarchar(12),
	USL nvarchar(12),
	TARGET nvarchar(12),
	Units nvarchar(16),
	CharType smallint,
	Activo bit default 1,
	CreaUserID smallint not null,
	CreaDate datetime default getdate(),
	ModifiUserID smallint,
	ModifiDate datetime
)
GO

CREATE TABLE Subgroups(
	SubgroupID int primary key identity,
	DateTime datetime,
	CharID int,
	PtLoc float,
	PtVar float,
	StatusFlags int,
	SpecialFLags int,
	TestID int,
	Activo bit default 1,
	CreaUserID smallint not null,
	CreaDate datetime default getdate(),
	ModifiUserID smallint,
	ModifiDate datetime
)
GO

CREATE TABLE DataValues(
	DataID int primary key identity,
	SubgroupID int,
	SampleNumber int,
	Value real	
)
GO

CREATE TABLE ParameterEntries(
	ParamEntryID int primary key identity,
	TestID int,
	ParameterID int,
	TextValue nvarchar(40)
)
GO