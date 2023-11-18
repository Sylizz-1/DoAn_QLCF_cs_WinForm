DROP DATABASE if exists QLCF;
CREATE DATABASE QLCF;
USE QLCF;


-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE Quyen
(
    QuyenId      int PRIMARY KEY NOT NULL IDENTITY,
    TenQuyen     nvarchar(255)       NOT NULL UNIQUE,
    NoiDungQuyen varchar(max)                NULL,
);

-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE NhanVien
(
    NhanVienId      int PRIMARY KEY NOT NULL IDENTITY,
    TaiKhoan varchar(255) UNIQUE not null,
    MatKhau    varchar(255)             not null,
    QuyenId int NOT NULL ,
    Ten             nvarchar(255)       NOT NULL,
    GioiTinh        nvarchar(10),
    SDT             nvarchar(20),
    Email           varchar(255),
    NamSinh date,
    IsDelete bit default 0,
    foreign key (QuyenId) references Quyen (QuyenId)
);

-- SQLINES LICENSE FOR EVALUATION USE ONLY
create table ChucNang
(
    ChucNangId      int PRIMARY KEY NOT NULL IDENTITY,
    TenChucNang     varchar(255)        not null unique,
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
    LoaiKhachHangId int             NOT NULL,
    IsDelete bit default 0,
    ThoiGianTaoTk date default getdate(),
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
    ThongTin      varchar(max)          NULL,
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
    MieuTa    varchar(max)                NULL,
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
    IsDelete bit default 0
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
