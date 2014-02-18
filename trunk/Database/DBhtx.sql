CREATE DATABASE hoptacxa
USE hoptacxa
GO
================Account===========
CREATE TABLE AcountDB (
	a_ID int identity(1,1) primary key not null, 
	a_Email varchar(200) not null,
	a_Password varchar(255) not null
)

=================== Ho so xe ==========
CREATE TABLE HosoxeDB (
	hs_ID int identity(1,1) primary key not null, 
	hs_Bienso varchar(10)not null,
	hs_Soghe int not null,
	hs_Nhanhieu varchar(100) not null,
	hs_Namsanxuat int not null,
	hs_Sokhung varchar(100) not null,
	hs_Somay varchar(100) not null,
	hs_Mauson varchar(100) not null,
	hs_Noisanxuat varchar(100) not null,
	hs_Datehtx datetime not null,
	hs_Datedangkiem datetime not null,
	hs_Datebaohiem datetime not null,
	hs_Datephuhieu datetime not null,
	hs_Sohuu varchar(200) not null
)
=================== Loai tuyen xe ==========
DROP TABLE LoaituyenxeBD
CREATE TABLE LoaituyenxeBD (
	l_ID int identity(1,1),
	l_Loaituyen varchar(500) not null	
)

=================== Tuyen xe ==========
DROP TABLE TuyenxeBD
CREATE TABLE TuyenxeBD (
	t_ID int identity(1,1) primary key not null,
	t_Tuyen varchar(500) not null,
	t_Loaituyen varchar(500) not null,
	t_Diemdi varchar(200) not null,
	t_Diemden varchar(200) not null,
	t_Lotrinh varchar(MAX) not null,
	t_Thoigian varchar(100) not null,
	t_Diemdung varchar(MAX) not null,
	t_Tansuat varchar(100)not null	
)


==================Xa vien==============
DROP TABLE XavienDB
CREATE TABLE XavienDB (
	x_ID int identity(1,1) primary key not null,
	x_Ten varchar(200)not null,
	x_CMTND varchar(50)not null,
	x_Ngaycap datetime not null,
	x_Noicap varchar(200) not null,
	x_Ngaysinh datetime not null,
	x_Diachi varchar(MAX) not null,
	x_Sodienthoai int not null,
	x_Giayphep varchar(200) not null,
	x_HangGPLX varchar(10),
	x_HanGPLX datetime not null,
	x_Chuxe bit,
	x_Phuxe bit,
	x_Laixe bit 
)

==================Nhan vien==============
DROP TABLE NhanvienDB
CREATE TABLE NhanvienDB (
	n_ID int identity(1,1) primary key not null,
	n_Ten varchar(200)not null,
	n_CMTND varchar(50)not null,
	n_Ngaycap datetime not null,
	n_Noicap varchar(200) not null,
	n_Ngaysinh datetime not null,
	n_Diachi varchar(MAX) not null,
	n_Sodienthoai int not null,
	n_Taikhoan varchar(100)
	 
)


============== Tai lieu==================
DROP TABLE TailieuDB
CREATE TABLE TailieuDB (
	tl_ID int identity(1,1) primary key not null,
	tl_TenTL varchar(200)not null,
	tl_URL varchar(50)not null,
	tl_NgayUpload datetime not null
	 
)