DROP DATABASE if exists QLCF;
GO
CREATE DATABASE QLCF;
GO
USE QLCF;
GO


-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE Quyen
(
    QuyenId      int PRIMARY KEY NOT NULL IDENTITY,
    TenQuyen     nvarchar(255)       NOT NULL UNIQUE,
    NoiDungQuyen nvarchar(max)                NULL,
);

-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE NhanVien
(
    NhanVienId      int PRIMARY KEY NOT NULL IDENTITY,
    TaiKhoan varchar(255) UNIQUE not null,
    MatKhau    varchar(255)             not null,
    QuyenId int,
    Ten             nvarchar(255),
    GioiTinh        nvarchar(10),
    SDT             varchar(20),
    Email           varchar(255),
    NgaySinh date,
    IsDelete bit default 0,
    foreign key (QuyenId) references Quyen (QuyenId)
);

-- SQLINES LICENSE FOR EVALUATION USE ONLY
create table ChucNang
(
    ChucNangId      int PRIMARY KEY NOT NULL IDENTITY,
    TenChucNang     nvarchar(255)        not null unique,
);

-- SQLINES LICENSE FOR EVALUATION USE ONLY
create table Quyen_ChucNang
(
    QuyenId    int not null,
    ChucNangId int not null,
    primary key (QuyenId, ChucNangId),
    foreign key (QuyenId) references Quyen (QuyenId),
    foreign key (ChucNangId) references ChucNang (ChucNangId)
);

-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE LoaiKhachHang
(
    LoaiKhachHangId int PRIMARY KEY NOT NULL IDENTITY,
    TenLoaiKh       nvarchar(255)       NOT NULL unique,
    GiamGia         tinyint not null
);

-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE KhachHang
(
    KhachHangId     int PRIMARY KEY NOT NULL IDENTITY,
    TaiKhoan        varchar(255) UNIQUE NOT NULL,
    MatKhau         varchar(255)        NOT NULL,
    TenKhachHang    nvarchar(255),
    DiaChi          nvarchar(255),
    SDT             VARCHAR(20),
    Email           VARCHAR(255),
    LoaiKhachHangId int,
    IsDelete bit default 0,
    ThoiGianTaoTk date default getdate(),
    NgaySinh date,
    FOREIGN KEY (LoaiKhachHangId) REFERENCES LoaiKhachHang (LoaiKhachHangId)
);

-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE NhaCungCap
(
    NhaCungCapId  int PRIMARY KEY NOT NULL IDENTITY,
    TenNhaCungCap nvarchar(255),
    DiaChi        nvarchar(255),
    SDT           varchar(20),
    Email         varchar(255),
    IsDelete bit default 0,
);

-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE NguyenLieu
(
    NguyenLieuId  int       NOT NULL PRIMARY KEY IDENTITY,
    TenNguyenLieu nvarchar(255) NOT NULL,
    ThongTin      nvarchar(max)          NULL,
    KhoiLuong     float        not null,
    GiaTien_Kg    float        not null,
    HinhAnh varchar(255) null ,
    IsDelete bit default 0
);

-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE PhieuNhap
(
    PhieuNhapId  int  NOT NULL IDENTITY PRIMARY KEY,
    NhanVienId   int NOT NULL,
    NhaCungCapId int NOT NULL,
    NgayNhap     datetime default GETDATE(),
    TongTien     float,
    FOREIGN KEY (NhanVienId) REFERENCES NhanVien (NhanVienId),
    FOREIGN KEY (NhaCungCapId) REFERENCES NhaCungCap (NhaCungCapId)
);

-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE ChiTietPhieuNhap
(
    PhieuNhapId  int NOT NULL,
    NguyenLieuId int NOT NULL,
    KhoiLuong    FLOAT,
    DonGia       float,
    FOREIGN KEY (PhieuNhapId) REFERENCES PhieuNhap (PhieuNhapId),
    FOREIGN KEY (NguyenLieuId) REFERENCES NguyenLieu (NguyenLieuId),
    PRIMARY KEY (PhieuNhapId, NguyenLieuId)
);




-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE CaPhe
(
    CaPheId   int PRIMARY KEY NOT NULL IDENTITY,
    TenCaPhe  nvarchar(255),
    Gia       float,
    MieuTa    nvarchar(max)                NULL,
    XuatXu    nvarchar(255)       NULL,
    HinhAnh   varchar(255)        NULL,
    IsDeleted bit DEFAULT 0
);


-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE CaPhe_NguyenLieu
(
    CaPheId      int NOT NULL,
    NguyenLieuId int NOT NULL,
    KhoiLuong    float  not null,
    PRIMARY KEY (CaPheId, NguyenLieuId),
    FOREIGN KEY (CaPheId) REFERENCES CaPhe (CaPheId),
    FOREIGN KEY (NguyenLieuId) REFERENCES NguyenLieu (NguyenLieuId)
);

create table PhieuGiamGia (
    PggId int not null primary key ,
    TgBatDau datetime null ,
    TgKetThuc datetime null ,
    GiaHoaDon float null ,
    PhanTramGiamGia tinyint not null,
    IsDelete bit default  0
);

-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE HoaDon
(
    HoaDonId        int PRIMARY KEY NOT NULL IDENTITY,
    NhanVienId      int             NOT NULL,
    KhachHangId     int             NOT NULL,
    PggId int null,
    NgayNhap        DATE default getdate(),
    PhiTruocGiamGia float,
    GiamGia         tinyint,
    PhiSauGiamGia   float,
    IsAccepted bit default 0
    FOREIGN KEY (KhachHangId) REFERENCES KhachHang (KhachHangId),
    FOREIGN KEY (NhanVienId) REFERENCES NhanVien (NhanVienId),
    foreign key (PggId) references PhieuGiamGia(PggId)
);

-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE ChiTietHoaDon
(
    HoaDonId int NOT NULL,
    CaPheId  int NOT NULL,
    SoLuong  INT,
    DonGia   float,
    FOREIGN KEY (HoaDonId) REFERENCES HoaDon (HoaDonId),
    FOREIGN KEY (CaPheId) REFERENCES CaPhe (CaPheId),
    PRIMARY KEY (HoaDonId, CaPheId)
);

-----------------------------------INSERT DATA--------------------------------------------------------

-- INSERT data into Quyen table
INSERT INTO Quyen (TenQuyen, NoiDungQuyen) VALUES
(N'Admin', N'Quyền toàn quyền'),
(N'NhanVienThuNgan', N'Quyền nhân viên thu ngân'),
(N'NhanVienKeToan', N'Quyền nhân viên kế toán');

-- INSERT data into NhanVien table
INSERT INTO NhanVien (TaiKhoan, MatKhau, QuyenId, Ten, GioiTinh, SDT, Email, NgaySinh, IsDelete) VALUES
(N'admin', N'123', 1, 'Admin User', 'Nam', '0123456789', 'admin@gmail.com', '1990-01-01', 0),
(N'thungan1', N'123', 2, N'Thu Ngân 1', N'Nữ', '0987654321', 'nhanvien1@gmail.com', '1995-05-15', 0),
(N'ketoan1', N'123', 3, N'Kế Toán 1', N'Nữ', '0987654321', 'nhanvien2@gmail.com', '1990-05-15', 0);

-- INSERT data into ChucNang table
INSERT INTO ChucNang (TenChucNang) VALUES
(N'Quản lý nhân viên'),
(N'Quản lý khách hàng'),
(N'Quản lý cà phê'),
(N'Quản lý nguyên liệu'),
(N'Quản lý nhập hàng'),
(N'Quản lý hóa đơn'),
(N'Quản lý nhập xuất file'),
(N'Quản lý thống kê'),
(N'Quản lý nhà cung cấp'),
(N'Quản lý phân quyền'),
(N'Quản lý phiếu giảm giá'),
(N'Quản lý loại khách hàng');

-- INSERT data into Quyen_ChucNang table
INSERT INTO Quyen_ChucNang (QuyenId, ChucNangId) VALUES
(1, 1),
(1, 2),
(1, 3),
(1, 4),
(1, 5),
(1, 6),
(1, 7),
(1, 8),
(1, 9),
(1, 10),
(1, 11),
(1, 12),
(2, 2),
(2, 4),
(2, 5),
(2, 6),
(3, 7),
(3, 8),
(3, 10),
(3, 11);

-- INSERT data into LoaiKhachHang table
INSERT INTO LoaiKhachHang (TenLoaiKh, GiamGia) VALUES
('Vip', 5),
(N'Thường', 0);

-- INSERT data into KhachHang table
INSERT INTO KhachHang (TaiKhoan, MatKhau, TenKhachHang, DiaChi, SDT, Email, LoaiKhachHangId, IsDelete, ThoiGianTaoTk, NgaySinh) VALUES
('khachvip', '123', N'Nguyễn Văn Z', '123 VIP DHSG', '0123456789', 'vip@gmail.com', 1, 0, '2023-01-01','2003-01-01'),
('khach1', '123', N'Trần Thị B', '456 Normal DHSG', '0987654321', 'customer1@gmail.com', 2, 0, '2023-01-02', '2004-01-01');

-- INSERT data into NhaCungCap table
INSERT INTO NhaCungCap (TenNhaCungCap, DiaChi, SDT, Email, IsDelete) VALUES
('NCC1', '123 Supplier Street', '0123456789', 'ncc1@gmail.com', 0),
('NCC2', '456 Supplier Street', '0987654321', 'ncc2@gmail.com', 0);

-- INSERT data into NguyenLieu table
INSERT INTO NguyenLieu (TenNguyenLieu, ThongTin, KhoiLuong, GiaTien_Kg, HinhAnh, IsDelete) VALUES
(N'Cà phê bột', N'Thông tin về Cà phê bột', 5.0, 150000.0, 'caPheBot.jpg', 0),
(N'Hạt cafe rang khô', N'Thông tin về Hạt cafe rang khô', 8.0, 100000.0, 'hatCaPhe.jpg', 0),
(N'Đường', N'Thông tin về Đường', 8.0, 80000.0, 'duong.jpg', 0),
(N'Sữa đặc', N'Thông tin về Sữa đặc', 8.0, 120000.0, 'suaDac.jpg', 0),
(N'Sữa tươi không đường', N'Thông tin về Sữa tươi không đường', 8.0, 300000.0, 'suaTuoi.jpg', 0),
(N'Bột cacao', N'Thông tin về Bột cacao', 8.0, 150000.0, 'botCaCao.jpg', 0),
(N'Bột socola', N'Thông tin về Bột socola', 8.0, 150000.0, 'botSocola.jpg', 0),
(N'Trà nhài', N'Thông tin về Trà nhài', 8.0, 140000.0, 'traNhai.jpg', 0),
(N'Trà sen', N'Thông tin về Trà sen', 8.0, 150000.0, 'traSen.jpg', 0),
(N'Đá viên', N'Thông tin về Đá viên', 10.0, 150000.0, 'daVien.jpg', 0),
(N'Đá xay', N'Thông tin về Đá xay', 10.0, 150000.0, 'daXay.jpg', 0);

-- INSERT data into PhieuNhap table
INSERT INTO PhieuNhap (NhanVienId, NhaCungCapId, NgayNhap, TongTien) VALUES
(1, 1, '2023-01-03', 1000000.0),
(2, 2, '2023-01-04', 1500000.0);

-- INSERT data into ChiTietPhieuNhap table
INSERT INTO ChiTietPhieuNhap (PhieuNhapId, NguyenLieuId, KhoiLuong, DonGia) VALUES
(1, 1, 2.0, 200000.0),
(1, 2, 3.0, 250000.0),
(2, 1, 4.0, 220000.0),
(2, 2, 5.0, 280000.0);

-- INSERT data into CaPhe table
INSERT INTO CaPhe (TenCaPhe, Gia, MieuTa, XuatXu, HinhAnh, IsDeleted) VALUES
(N'Cà phê truyền thống', 25000.0, N'Mô tả về cà phê 1', 'Viet Nam', 'caPheTruyenThong.jpg', 0),
(N'Cà phê Capuchino', 25000.0, N'Mô tả về cà phê 1', 'Viet Nam', 'CaPheCapuchino.jpg', 0),
('Cafe Latte', 25000.0, N'Mô tả về cà phê 1', 'Viet Nam', 'CaPheLatte.jpg', 0),
('Americano', 25000.0, N'Mô tả về cà phê 1', 'Viet Nam', 'CaPheAmericano.jpg', 0),
('Cafe Mocha', 25000.0, N'Mô tả về cà phê 1', 'Viet Nam', 'CaPheMocha.jpg', 0),
('Cappuccino Viennese', 25000.0, N'Mô tả về cà phê 1', 'Viet Nam', 'CaPheCappuccinoViennese.jpg', 0),
(N'Cà phê Espresso', 30000.0, N'Mô tả về cà phê 2', 'Brazil', 'CaPheEspresso.jpg', 0);

-- INSERT data into CaPhe_NguyenLieu table
INSERT INTO CaPhe_NguyenLieu (CaPheId, NguyenLieuId, KhoiLuong) VALUES
(1, 1, 1.5),
(1, 2, 2.0),
(2, 1, 1.0),
(2, 2, 1.5);

-- INSERT data into PhieuGiamGia table
INSERT INTO PhieuGiamGia (PggId, TgBatDau, TgKetThuc, GiaHoaDon, PhanTramGiamGia, IsDelete) VALUES
(1, '2023-01-05', '2023-02-05', 100000.0, 10, 0),
(2, '2023-01-10', '2023-02-10', 150000.0, 15, 0);

-- INSERT data into HoaDon table
INSERT INTO HoaDon (NhanVienId, KhachHangId, PggId, NgayNhap, PhiTruocGiamGia, GiamGia, PhiSauGiamGia, IsDelete) VALUES
(1, 1, 1, '2023-02-01', 80000.0, 10, 72000.0, 0),
(2, 2, 2, '2023-02-02', 120000.0, 15, 102000.0, 0);

-- INSERT data into ChiTietHoaDon table
INSERT INTO ChiTietHoaDon (HoaDonId, CaPheId, SoLuong, DonGia) VALUES
(1, 1, 2, 250000.0),
(1, 2, 3, 300000.0),
(2, 1, 1, 250000.0),
(2, 2, 2, 300000.0);

