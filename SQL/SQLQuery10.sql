create database QLNVs
go

use QLNVs
go

--Tạo Bảng
CREATE TABLE NhanVien(
NhanVienID INT IDENTITY (100,1) PRIMARY KEY ,
HoNV VARCHAR (20),
TenNV VARCHAR(20),
NgaySinh DATE,
GioiTinh VARCHAR(4),
Luong INT,
NguoiPhuTrachID INT,
ChiNhanhID INT
);

CREATE TABLE ChiNhanh(
ChiNhanhID INT IDENTITY (1,1) PRIMARY KEY ,
TenChiNhanh VARCHAR(20) ,
QuanLyID INT,
NgayBatDau DATE
);

CREATE TABLE KhachHang
(
KhachHangID INT IDENTITY (400,1) PRIMARY KEY,
TenKhachHang VARCHAR(20),
ChiNhanhID INT
);


CREATE TABLE ChiTietSale
(
NhanVienID INT,
KhachHangID INT,
TongTien INT
PRIMARY KEY(NhanVienID, KhachHangID)

);

CREATE TABLE NhaCungCap
(
ChiNhanhID INT,
TenNhaCungCap VARCHAR(20),
LoaiSanPham VARCHAR(20)
PRIMARY KEY(ChiNhanhID, TenNhaCungCap)
);

--Tao Khóa Ngoại cho các Bảng
ALTER TABLE NhanVien ADD CONSTRAINT fk_CNID FOREIGN KEY (ChiNhanhID) REFERENCES ChiNhanh(ChiNhanhID) ON DELETE SET null;
ALTER TABLE ChiNhanh ADD CONSTRAINT fk_QuanLy FOREIGN KEY (QuanLyID) REFERENCES NhanVien(NhanVienID) ON DELETE SET null;
ALTER TABLE KhachHang ADD CONSTRAINT fk_ChiNhanh FOREIGN KEY (ChiNhanhID) REFERENCES ChiNhanh(ChiNhanhID) ON DELETE SET null;
ALTER TABLE NhanVien ADD CONSTRAINT fk_NguoiPT FOREIGN KEY (NguoiPhuTrachID) REFERENCES NhanVien(NhanVienID);
ALTER TABLE ChiTietSale ADD CONSTRAINT fk_NhanVien FOREIGN KEY (NhanVienID) REFERENCES NhanVien(NhanVienID);
ALTER TABLE ChiTietSale ADD CONSTRAINT fk_KhachHang FOREIGN KEY (KhachHangID) REFERENCES KhachHang(KhachHangID);
ALTER TABLE NhaCungCap ADD CONSTRAINT fk_ChiNhanhID FOREIGN KEY (ChiNhanhID) REFERENCES ChiNhanh(ChiNhanhID);

--Nhập dữ liệu vào Bảng NhanVien
INSERT INTO NhanVien(HoNV, TenNV, NgaySinh, GioiTinh, Luong, NguoiPhuTrachID, ChiNhanhID)
VALUES ('Phan Đình', 'Tùng', '1995/5/23', 'Nam', 30000000, NULL,NULL);
INSERT INTO NhanVien(HoNV, TenNV, NgaySinh, GioiTinh, Luong, NguoiPhuTrachID, ChiNhanhID)
VALUES ('Lê Văn', 'Lang', '1990/2/12', N'Nữ', 12000000, NULL, NULL);
INSERT INTO NhanVien(HoNV, TenNV, NgaySinh, GioiTinh, Luong, NguoiPhuTrachID, ChiNhanhID)
VALUES ('Đinh Văn', 'Hoàng', '1985/1/24', 'Nam', 10000000, NULL, NULL);
INSERT INTO NhanVien(HoNV, TenNV, NgaySinh, GioiTinh, Luong, NguoiPhuTrachID, ChiNhanhID)
VALUES ('Hoàng Thị', 'Bưởi', '1991/8/21', N'Nữ', 11000000, NULL, NULL);
INSERT INTO NhanVien(HoNV, TenNV, NgaySinh, GioiTinh, Luong, NguoiPhuTrachID, ChiNhanhID)
VALUES ('Đào Đình', 'Phong', '1992/8/12', 'Nam', 8000000, NULL, NULL);
INSERT INTO NhanVien(HoNV, TenNV, NgaySinh, GioiTinh, Luong, NguoiPhuTrachID, ChiNhanhID)
VALUES ('Mai Văn', 'Ăn', '1986/1/1', 'Nam', 6500000, NULL, NULL);
INSERT INTO NhanVien(HoNV, TenNV, NgaySinh, GioiTinh, Luong, NguoiPhuTrachID, ChiNhanhID)
VALUES ('Nguyễn Văn', 'Sung', '1999/2/2', N'Nữ', 5000000, NULL, NULL);
INSERT INTO NhanVien(HoNV, TenNV, NgaySinh, GioiTinh, Luong, NguoiPhuTrachID, ChiNhanhID)
VALUES ('Cao Bá', 'Thông', '1993/3/3', 'Nam', 3000000, NULL, NULL);
INSERT INTO NhanVien(HoNV, TenNV, NgaySinh, GioiTinh, Luong, NguoiPhuTrachID, ChiNhanhID)
VALUES ('Nguyễn Văn', 'Balo', '1986/1/1', 'Nam', 8500000, NULL, NULL);

--Update dữ liệu cho bảng NhanVien
UPDATE NhanVien SET NguoiPhuTrachID = 100 WHERE NhanVienID = 101;
UPDATE NhanVien SET ChiNhanhID = 1 WHERE NhanVienID = 100;
UPDATE NhanVien SET ChiNhanhID = 1 WHERE NhanVienID = 101;
UPDATE NhanVien SET NguoiPhuTrachID = 100, ChiNhanhID = 2 WHERE NhanVienID = 102;
UPDATE NhanVien SET NguoiPhuTrachID = 102, ChiNhanhID = 2 WHERE NhanVienID = 103;
UPDATE NhanVien SET NguoiPhuTrachID = 102, ChiNhanhID = 2 WHERE NhanVienID = 104;
UPDATE NhanVien SET NguoiPhuTrachID = 102, ChiNhanhID = 2 WHERE NhanVienID = 105;
UPDATE NhanVien SET NguoiPhuTrachID = 100, ChiNhanhID = 3 WHERE NhanVienID = 106;
UPDATE NhanVien SET NguoiPhuTrachID = 106, ChiNhanhID = 3 WHERE NhanVienID = 107;
UPDATE NhanVien SET NguoiPhuTrachID = 106, ChiNhanhID = 3 WHERE NhanVienID = 108;

--TRUNCATE TABLE NhanVien;

--Nhập dữ liệu vào Bảng ChiNhanh
INSERT INTO ChiNhanh( TenChiNhanh, QuanLyID, NgayBatDau) VALUES ('Hue', 100, '2010/5/2');
INSERT INTO ChiNhanh( TenChiNhanh, QuanLyID, NgayBatDau) VALUES ('Quang Binh', 102, '2012/5/2');
INSERT INTO ChiNhanh( TenChiNhanh, QuanLyID, NgayBatDau) VALUES ('Quang Tri', 106, '2011/5/2');

--Nhập dữ liệu vào Bảng KhachHang
INSERT INTO KhachHang( TenKhachHang, ChiNhanhID) VALUES ('Công Ty Sữa Ong Chúa', 2);
INSERT INTO KhachHang( TenKhachHang, ChiNhanhID) VALUES ('Công Ty Giấy BCC', 2);
INSERT INTO KhachHang( TenKhachHang, ChiNhanhID) VALUES ('Công Ty Gốm LCD', 3);
INSERT INTO KhachHang( TenKhachHang, ChiNhanhID) VALUES ('Công Ty Nhựa Silili', 3);
INSERT INTO KhachHang( TenKhachHang, ChiNhanhID) VALUES ('Công Ty Bánh Kẹo Hai Lúa', 2);
INSERT INTO KhachHang( TenKhachHang, ChiNhanhID) VALUES ('Công Ty BDS Háu Ăn', 3);
INSERT INTO KhachHang( TenKhachHang, ChiNhanhID) VALUES ('Công Ty Hải Sản 3X', 2);

--Nhập dữ liệu vào Bảng ChiTietSale
INSERT INTO ChiTietSale( NhanVienID, KhachHangID, TongTien) VALUES (105, 400, 85000);
INSERT INTO ChiTietSale( NhanVienID, KhachHangID, TongTien) VALUES (102, 401, 320000);
INSERT INTO ChiTietSale( NhanVienID, KhachHangID, TongTien) VALUES (108, 402, 25500);
INSERT INTO ChiTietSale( NhanVienID, KhachHangID, TongTien) VALUES (107, 403, 4000);
INSERT INTO ChiTietSale( NhanVienID, KhachHangID, TongTien) VALUES (108, 403, 11000);
INSERT INTO ChiTietSale( NhanVienID, KhachHangID, TongTien) VALUES (105, 404, 32000);
INSERT INTO ChiTietSale( NhanVienID, KhachHangID, TongTien) VALUES (107, 405, 26000);
INSERT INTO ChiTietSale( NhanVienID, KhachHangID, TongTien) VALUES (102, 406, 12000);
INSERT INTO ChiTietSale( NhanVienID, KhachHangID, TongTien) VALUES (105, 406, 250000);

--Nhập dữ liệu vào Bảng NhaCungCap
INSERT INTO NhaCungCap ( ChiNhanhID, TenNhaCungCap, LoaiSanPham) VALUES (2, 'Hồng Vân', 'Sữa');
INSERT INTO NhaCungCap ( ChiNhanhID, TenNhaCungCap, LoaiSanPham) VALUES (2, 'Chiến Thắng', 'Giấy');
INSERT INTO NhaCungCap ( ChiNhanhID, TenNhaCungCap, LoaiSanPham) VALUES (3, 'Huda Huế', 'Gốm');
INSERT INTO NhaCungCap ( ChiNhanhID, TenNhaCungCap, LoaiSanPham) VALUES (2, 'CodeGym', 'Bánh Kẹo');
INSERT INTO NhaCungCap ( ChiNhanhID, TenNhaCungCap, LoaiSanPham) VALUES (3, 'CodeGym', 'Bánh Kẹo');
INSERT INTO NhaCungCap ( ChiNhanhID, TenNhaCungCap, LoaiSanPham) VALUES (3, 'Chiến Thắng', 'Giấy');
INSERT INTO NhaCungCap ( ChiNhanhID, TenNhaCungCap, LoaiSanPham) VALUES (3, '3S', 'Hải Sản');


-- 1.Lấy tất cả thông tin của NhanVien
SELECT * FROM NhanVien;

-- 2.Lấy tất cả thông tin của ChiNhanh
SELECT * FROM ChiNhanh;

-- 3.SẮP XẾP TĂNG DẦN THEO LƯƠNG NHÂN VIÊN
SELECT * FROM NhanVien
ORDER BY Luong;

-- 4.SẮP XẾP GIẢM DẦN THEO LƯƠNG NHÂN VIÊN
SELECT * FROM NhanVien
ORDER BY Luong DESC;

-- 5. SẮP XẾP THEO GIỚI TÍNH, TÊNNV
SELECT * FROM NhanVien
ORDER BY GioiTinh, TenNV;

-- 6.LẤY 5 NHÂN VIÊN ĐẦU TIÊN TRONG BẢNG
SELECT TOP(5) * FROM NhanVien;

-- 7.XUẤT RA MÀN HÌNH HONV, TENNV
SELECT NHANVIEN.HoNV, NHANVIEN.TenNV FROM NhanVien AS NHANVIEN;

-- 8.Xuất những giới tính của nhân viên
SELECT COUNT(*) AS SL, 
CASE GIOITINH
WHEN 'F' THEN 'NU'
WHEN 'M' THEN 'NAM'
END AS GT
FROM NhanVien
WHERE GIOITINH = 'M'
GROUP BY GioiTinh;

SELECT COUNT(*) FROM NhanVien
GROUP BY GioiTinh;

-- 9.Lấy những nhân viên có giới tính Nam
SELECT * FROM NhanVien WHERE GioiTinh ='Nam';

-- 10.Lấy những nhân viên có NamSinh > 1990
SELECT * FROM NhanVien WHERE NgaySinh > '1990/1/1';

-- 11.Lấy những thông tin của nhân viên thuộc chi nhánh Quảng Bình
SELECT * FROM NhanVien AS NV
INNER JOIN ChiNhanh AS CN
ON NV.ChiNhanhID = CN.ChiNhanhID WHERE CN.TenChiNhanh = 'Quảng Bình';

-- 12.Lấy những nhân viên có giới tính nữ hoặc lương > 8 triệu
SELECT * FROM NhanVien WHERE GioiTinh = 'Nữ' OR Luong > 8000000;

-- 13.Đếm số lượng nhân viên của các chi nhánh
SELECT TenChiNhanh,COUNT(NV.NhanVienID) 
FROM ChiNhanh AS CN
LEFT JOIN NhanVien AS NV
ON NV.ChiNhanhID = CN.ChiNhanhID 
GROUP BY TenChiNhanh;

-- 14. LẤY THÔNG TIN NHÀ CUNG CẤP VÀ TÊN NHÂN VIÊN CHỊU TRÁCH NHIỆM VỚI NHÀ CUNG CẤP ĐÓ
SELECT TenNhaCungCap, LoaiSanPham, TenChiNhanh, HoNV, TenNV 
FROM NhaCungCap AS NCC
LEFT JOIN ChiNhanh AS CN
ON NCC.ChiNhanhID = CN.ChiNhanhID
LEFT JOIN NhanVien AS NV
ON NV.NhanVienID = CN.QuanLyID;

-- 15.LẤY LƯƠNG TRUNG BÌNH CỦA CÔNG TY
SELECT AVG(Luong) AS TBLNV
FROM NhanVien;

-- 16.LẤY NGƯỜI NHÂN VIÊN CÓ LƯƠNG CAO NHẤT CỦA CÔNG TY
SELECT TOP(1) NhanVien.NhanVienID, NhanVien.HoNV, NhanVien.TenNV, MAX(LUONG) FROM NhanVien
GROUP BY NhanVienID, HoNV, TenNV
ORDER BY MAX(LUONG) DESC;

-- 17.LẤY TOP 3 NHÂN VIÊN CÓ LƯƠNG CAO NHẤT CỦA CÔNG TY
SELECT TOP(3) NhanVien.NhanVienID, NhanVien.HoNV, NhanVien.TenNV, MAX(LUONG) FROM NhanVien
GROUP BY NhanVienID, HoNV, TenNV
ORDER BY MAX(LUONG) DESC;

-- 18.VÌ NGÀY QUỐC TẾ PHỤ NỮ SẮP TỚI LẤY NHỮNG NHÂN VIÊN CÓ GIỚI TÍNH NỮ VÀ ĐỘ TUỔI DƯỚI 35
SELECT NhanVien.NhanVienID, NhanVien.TenNV ,YEAR(GETDATE()) - YEAR(NGAYSINH) AS TUOI
FROM NhanVien
WHERE GioiTinh ='Nữ' AND YEAR(GETDATE()) - YEAR(NGAYSINH) < 35;

-- 19.TỔNG TIỀN SALE ĐỐI VỚI TỪNG KHÁCH HÀNG(TT KHÁCH HÀNG VỚI TỔNG TIỀN SALE)
SELECT KhachHang.KhachHangID, KhachHang.TenKhachHang,
SUM(TongTien) AS SUMSALARY 
FROM KhachHang
INNER JOIN ChiTietSale
ON ChiTietSale.KhachHangID = KhachHang.KhachHangID
GROUP BY KhachHang.KhachHangID, TenKhachHang;


-- 20.LẤY THÔNG TIN NHÂN VIÊN VÀ TỔNG TIỀN SALE CỦA NHÂN VIÊN ĐÓ
SELECT NhanVien.NhanVienID, NhanVien. TenNV, SUM (TONGTIEN) AS TONGTIEN
FROM NhanVien
INNER JOIN ChiTietSale
ON ChiTietSale.NhanVienID = NhanVien.NhanVienID
GROUP BY NhanVien.NhanVienID, NhanVien. TenNV

-- 21.LẤY THÔNG TIN NHỮNG NHÀ CUNG CẤP CÓ TÊN BẮT ĐẦU BẰNG CHỮ 'HU'
SELECT * FROM NhaCungCap
WHERE TenNhaCungCap LIKE 'Hu%';

-- 22.LẤY NHỮNG NHÂN VIÊN CÓ THÁNG SINH NHẬT VÀO THÁNG 10
SELECT * FROM NhanVien
WHERE MONTH(NgaySinh) = 10;

-- 23.LẤY TẤT CẢ THÔNG TIN CỦA NHÂN VIÊN MÀ CÓ TỔNG TIÊN SALE LỚN HƠN 5 TRIỆU
SELECT NV.NhanVienID, NV.TenNV ,SUM(TONGTIEN) AS TONGTIEN
FROM NhanVien AS NV
INNER JOIN ChiTietSale AS CTS
ON CTS.NhanVienID = NV.NhanVienID
GROUP BY NV.NhanVienID, NV.TenNV
HAVING SUM(TONGTIEN) > 50000;

-- 24.LẤY THÔNG TIN KHÁCH HÀNG MÀ NGƯỜI QUẢN LÝ CÓ ID = 102;
SELECT * FROM KhachHang AS KH



-- 25.LẤY THÔNG TIN KHÁCH HÀNG NHƯNG NGƯỜI QUẢN LÝ CÓ TÊN LÀ 'SUNG'
SELECT KHACHHANG.*
FROM NHANVIEN 
LEFT JOIN KHACHHANG
ON NhanVien.ChiNhanhID = KhachHang.ChiNhanhID
WHERE TenNV = 'Sung'

-- 26.LẤY THÔNG TIN NHỮNG NHÂN VIÊN ĐÃ CÓ SALE THUỘC CHI NHÁNH QUẢNG TRỊ
SELECT DISTINCT NV.NhanVienID, NV.TenNV FROM NhanVien NV JOIN ChiTietSale SL
ON NV.NhanVienID = SL.NhanVienID
WHERE ChiNhanhID = 3;

-- 27. TÌM KIÊM TẤT CẢ NHỮNG KHÁCH HÀNG CÓ TIỀN SALE > 10 TRIỆU
SELECT SL.TongTien ,KH.KhachHangID, KH.TenKhachHang 
FROM KhachHang KH
INNER JOIN ChiTietSale SL
ON KH.KhachHangID = SL.KhachHangID
GROUP BY KH.KhachHangID, KH.TenKhachHang, SL.TongTien
HAVING SL.TongTien > 100000;

GO
CREATE PROCEDURE sp_ChiTietSale_KhachHang
@KHACHHANGID INT,
@TENKHACHHANG VARCHAR(20),
@TONGTIEN INT
AS
BEGIN
SELECT SL.TongTien ,KH.KhachHangID, KH.TenKhachHang 
FROM KhachHang KH
INNER JOIN ChiTietSale SL
ON KH.KhachHangID = SL.KhachHangID
GROUP BY KH.KhachHangID, KH.TenKhachHang, SL.TongTien
HAVING SL.TongTien > 100000;
END


GO
CREATE PROCEDURE SP_DANHSACHKKHACHHANG_TENNHANVIEN
	@NHANVIENID INT,
	@TENNHANVIEN NVARCHAR(20),
	@KHACHHANGID INT,
	@TENKHACHHANG NVARCHAR(20)
AS
BEGIN
INSERT INTO KhachHang(KhachHangID, TenKhachHang)
VALUES (@KHACHHANGID, @TENKHACHHANG)
INSERT INTO NhanVien(NhanVienID, TenNV)
VALUES (@NHANVIENID, @TENNHANVIEN)
INSERT INTO ChiTietSale(TongTien)
SELECT
TongTien
FROM ChiTietSale
END

SELECT * FROM ChiTietSale