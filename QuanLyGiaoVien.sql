create database QuanLyGiaoVien
use QuanLyGiaoVien

go

create table CoSo (
	MaCoSo char(10) not null,
	TenCoSo nvarchar(30),

	primary key(MaCoSo),

)

go

insert into CoSo values ('CoSo1' , N'Cơ Sỡ 1')
insert into CoSo values ('CoSo2' , N'Cơ Sỡ 2')
insert into CoSo values ('CoSo3' , N'Cơ Sỡ 3')


create table DonVi (

MaDonVi char(10) not null,
TenDonVi nvarchar(30),
MaCoSo char(10),


primary key(MaDonVi),
)

ALTER TABLE DonVi
 ADD CONSTRAINT FKDV_MaCoSo
  FOREIGN KEY (MaCoSo)
  REFERENCES CoSo (MaCoSo);
go

insert into DonVi values ('DonVi1',N'Đơn Vị Một', 'CoSo1')
insert into DonVi values ('DonVi2',N'Đơn Vị Hai', 'CoSo1')
insert into DonVi values ('DonVi3',N'Đơn Vị Ba', 'CoSo1')
insert into DonVi values ('DonVi4',N'Đơn Vị Bốn', 'CoSo2')
insert into DonVi values ('DonVi5',N'Đơn Vị Năm', 'CoSo2')
insert into DonVi values ('DonVi6',N'Đơn Vị Sáu', 'CoSo2')
insert into DonVi values ('DonVi7',N'Đơn Vị Bảy',  'CoSo3')
insert into DonVi values ('DonVi8',N'Đơn Vị Tám', 'CoSo3')
insert into DonVi values ('DonVi9',N'Đơn Vị Chín',  'CoSo3')


go

create table GiaoVien(

	MaGV char(10) not null,
	HoTen nvarchar(30),
	SoDT char(10),
	GhiChu nvarchar(50),
	MaDonVi char(10),

	primary key(MaGV)

)

go

ALTER TABLE GiaoVien
 ADD CONSTRAINT FKGV_MaDonVi
  FOREIGN KEY (MaDonVi)
  REFERENCES DonVi (MaDonVi);
go

insert into GiaoVien values ('GV1' , N'Lê Thị Thiên Thơ', '0355445785', N'Giáo viên dạy giỏi', 'DonVi2')
insert into GiaoVien values ('GV2' , N'Đào Nguyên Tuấn', '0355445795', N'Giáo viên dạy giỏi', 'DonVi2')
insert into GiaoVien values ('GV3' , N'Lê Thị Thơm', '0355445175', N'Giáo viên dạy giỏi', 'DonVi2')
insert into GiaoVien values ('GV4' , N'Nguễn Quốc Việt', '0355445771', N'Giáo viên dạy giỏi', 'DonVi3')
insert into GiaoVien values ('GV5' , N'Nguyễn Chơi', '0355445772', N'Giáo viên dạy giỏi', 'DonVi3')
insert into GiaoVien values ('GV6' , N'Ngọc Ca', '0355445773', N'Giáo viên dạy giỏi', 'DonVi3')
insert into GiaoVien values ('GV7' , N'Thanh Tài', '0355445774', N'Giáo viên dạy giỏi', 'DonVi4')
insert into GiaoVien values ('GV8' , N'Tú Nguyễn', '0355445775', N'Giáo viên dạy giỏi', 'DonVi4')
insert into GiaoVien values ('GV9' , N'Lê Thảo', '0355445776', N'Giáo viên dạy giỏi', 'DonVi4')
insert into GiaoVien values ('GV10' , N'Nguyễn Hảo', '0355445777', N'Giáo viên dạy giỏi', 'DonVi5')
insert into GiaoVien values ('GV11' , N'Nguyễn Tỵ', '0355445778', N'Giáo viên dạy giỏi', 'DonVi5')
insert into GiaoVien values ('GV12' , N'Thanh Tâm', '0355445779', N'Giáo viên dạy giỏi', 'DonVi5')
insert into GiaoVien values ('GV13' , N'Bút Chương', '0355445721', N'Giáo viên dạy giỏi', 'DonVi7')
insert into GiaoVien values ('GV14' , N'Tấn Lộc', '0355415775', N'Giáo viên dạy giỏi', 'DonVi7')
insert into GiaoVien values ('GV15' , N'Nguyễn Trãi', '0325445775', N'Giáo viên dạy giỏi', 'DonVi7')
insert into GiaoVien values ('GV16' , N'Tiến Đạt', '0355435775', N'Giáo viên dạy giỏi', 'DV8')
insert into GiaoVien values ('GV17' , N'Thành Nhân', '0354445775', N'Giáo viên dạy giỏi', 'DonVi8')
insert into GiaoVien values ('GV18' , N'Lâm An', '0355445775', N'Giáo viên dạy giỏi', 'DonVi8')
insert into GiaoVien values ('GV19' , N'Thiên An', '0355445775', N'Giáo viên dạy giỏi', 'DonVi9')
insert into GiaoVien values ('GV20' , N'Lạc Lạc', '0355445775', N'Giáo viên dạy giỏi', 'DonVi9')
insert into GiaoVien values ('GV21' , N'Lạc Ân', '0352445775', N'Giáo viên dạy giỏi', 'DonVi9')
insert into GiaoVien values ('GV22' , N'Thiên Thức', '0355445775', N'Giáo viên dạy giỏi', 'DonVi1')
insert into GiaoVien values ('GV23' , N'Tào Tháo', '0355445775', N'Giáo viên dạy giỏi', 'DonVi1')
insert into GiaoVien values ('GV24' , N'Hứa Chử', '0352445775', N'Giáo viên dạy giỏi', 'DonVi1')
insert into GiaoVien values ('GV25' , N'Lữ Bố', '0355445775', N'Giáo viên dạy giỏi', 'DonVi6')
insert into GiaoVien values ('GV26' , N'Trọng Đạt', '0355445775', N'Giáo viên dạy giỏi', 'DonVi6')
insert into GiaoVien values ('GV27' , N'Tào Khiêm', '0352445775', N'Giáo viên dạy giỏi', 'DonVi6')
insert into GiaoVien values ('GV28' , N'Thúy Vân', '0355445775', N'Giáo viên dạy giỏi', 'DonVi1')
insert into GiaoVien values ('GV29' , N'Thúy Kiều', '0355445775', N'Giáo viên dạy giỏi', 'DonVi1')
insert into GiaoVien values ('GV30' , N'Điêu Thuyền', '0352445775', N'Giáo viên dạy giỏi', 'DonVi1')