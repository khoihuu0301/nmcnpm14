create database HACKERRANKREP

use HACKERRANKREP

set dateformat mdy

create table NGUOIDUNG
(
	username char(25) not null primary key,
	pass	char(25) not null,
	vaitro	smallint, --1 = student 2 = employee 3 = CEO
	ID_HS	int,
	ID_NV int,
	ID_QTV int,
)


create table HOCSINH
(	
	ID_HS int not null primary key,
	Ten_HS nvarchar(25),
	Phai_HS nvarchar(5),
	NgaySinh_HS date,
	TotalPoint int,
	Wallet float,
)

create table NHANVIEN
(
	ID_NV int not null primary key,
	Ten_NV nvarchar(25),
	Phai_NV nvarchar(5),
	CMND char(15) unique,
	NgaySinh_NV date,
	KPI_NV int,
	Luong float,
)

create table BAITAP
(
	ID_BT int not null primary key,
	DeBai nvarchar(max),
	A nvarchar(max),
	B nvarchar(max),
	C nvarchar(max),
	D nvarchar(max),
	Correct char(1),
	Score smallint,
)


create table QTV
(
	ID_QTV int not null primary key,
	Ten_QTV nvarchar(25),
	Phai_QTV nvarchar(5),
	CMND char(15) unique,
	NgaySinh_QTV date,
	KPI_QTV int,
)

create table HS_BT
(
	ID_HS int not null,
	ID_BT int not null,
	score int,
)

create table CLASS
(
	ID_CLASS int not null primary key,
	Ten_CLASS nvarchar(100),
	GiaTien float,
)

create table CLS_CONTENT
(
	ID_CLASS int not null,
	Dir int,
	Ten_Dir nvarchar(max),
	Noidung nvarchar(max),
	Vid nvarchar(25),
)
create table HS_CERT
(
	ID_HS int,
	ID_CLASS int,
	Passed bit, -- 1 = Finished, 2 = Unfinished
)


--Key

alter table NGUOIDUNG
add constraint FK_NHANVIEN_NGUOIDUNG foreign key (ID_NV) references NHANVIEN(ID_NV)

alter table NGUOIDUNG
add constraint FK_HOCSINH_NGUOIDUNG foreign key (ID_HS) references HOCSINH(ID_HS)

alter table NGUOIDUNG
add constraint FK_QTV_NGUOIDUNG foreign key (ID_QTV) references QTV(ID_QTV)

alter table HS_BT
add constraint FK_HS_BT_HOCSINH foreign key (ID_HS) references HOCSINH(ID_HS)

alter table CLS_CONTENT
add constraint FK_CLS_CONTENT_CLASS foreign key (ID_CLASS) references CLASS(ID_CLASS)

alter table HS_CERT
add constraint FK_HS_CERT_HOCSINH foreign key (ID_HS) references HOCSINH(ID_HS)

alter table HS_BT
add constraint FK_HS_BT_BAITAP foreign key (ID_BT) references BAITAP(ID_BT)

alter table HS_CERT
add constraint FK_HS_CERT_CLASS foreign key (ID_CLASS) references CLASS(ID_CLASS)

insert into hocsinh values (1,N'NVA', 'Nam', '03/20/2001',0,0)
insert into NGUOIDUNG values ('test','test',1,1,null,null)
insert into nhanvien values (1,'test',N'Nữ', '123456789', '03/20/2001',0,0)
insert into NGUOIDUNG values ('nhanvien','test',2,null,1,null)
insert into qtv values (1, 'test','Nam', '123456789', '03/20/2001', 0)
insert into NGUOIDUNG values ('qtv','test',3,null,null,1)

