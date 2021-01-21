CREATE DATABASE Kutuphane 
GO

use Kutuphane
GO

CREATE TABLE [Personeller] (
  [PersonelId] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [KullaniciAd] nvarchar(50) UNIQUE NOT NULL,
  [Sifre] nvarchar(50),
  [AdSoyad] nvarchar(50),
  [DogumGunu] datetime,
  [Mail] nvarchar(50),
  [Gsm] nvarchar(50),
  [Adres] nvarchar(MAX),
  [CV] nvarchar(MAX)
)
GO

CREATE TABLE [Turler] (
  [TurId] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [TurAdi] nvarchar(50) UNIQUE NOT NULL
)
GO

CREATE TABLE [Kitaplar] (
  [KitapId] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [Tur] nvarchar(50),
  [Ad] nvarchar(50) UNIQUE NOT NULL,
  [Yazar] nvarchar(50),
  [YayinTarihi] date,
  [Yayinci] nvarchar(50),
  [Dil] nvarchar(50),
  [SayfaSayisi] nvarchar(50),
)
GO

CREATE TABLE [Dergiler] (
  [DergiId] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [Tur] nvarchar(50),
  [Ad] nvarchar(50) UNIQUE NOT NULL,
  [Yayinci] nvarchar(50),
  [YayinTarihi] date,
  [YayinSayisi] nvarchar(50),
  [Dil] nvarchar(50),
  [CiltSayisi] nvarchar(50),
)
GO

CREATE TABLE [Ansiklopediler] (
  [AnsiklopediId] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [Tur] nvarchar(50),
  [Ad] nvarchar(50) UNIQUE NOT NULL,
  [Yazar] nvarchar(50),
  [YayinTarihi] date,
  [Yayinci] nvarchar(50),
  [Dil] nvarchar(50),
  [SayfaSayisi] nvarchar(50),
)
GO

CREATE TABLE [Uyeler] (
  [UyeId] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [KullaniciAd] nvarchar(50) UNIQUE NOT NULL,
  [Sifre] nvarchar(50),
  [AdSoyad] nvarchar(50),
  [OkunanKitapSayisi] int,
  [DogumGunu] datetime,
  [Mail] nvarchar(50),
  [Gsm] nvarchar(50),
  [Adres] nvarchar(MAX)
)
GO

CREATE TABLE [UyeGecmisi] (
  [UyeId] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [KullaniciAd] nvarchar(50) UNIQUE NOT NULL,
  [OkunanCins] nvarchar(50),
  [Tur] nvarchar(50),
  [Ad] nvarchar(50) UNIQUE NOT NULL,
  [AlinmaTarihi] date,
  [VerilmeDurumu] nvarchar(50),
  [VerilmeTarihi] date
)
GO

ALTER TABLE [Kitaplar] ADD FOREIGN KEY ([Tur]) REFERENCES [Turler] ([TurAdi])
GO

ALTER TABLE [Dergiler] ADD FOREIGN KEY ([Tur]) REFERENCES [Turler] ([TurAdi])
GO

ALTER TABLE [Ansiklopediler] ADD FOREIGN KEY ([Tur]) REFERENCES [Turler] ([TurAdi])
GO

ALTER TABLE [UyeGecmisi] ADD FOREIGN KEY ([Tur]) REFERENCES [Turler] ([TurAdi])
GO

INSERT INTO [dbo].[Personeller]
           ([KullaniciAd]
           ,[Sifre]
           ,[AdSoyad]
           ,[DogumGunu]
           ,[Mail]
           ,[Gsm]
           ,[Adres]
           ,[CV])
     VALUES 
          ('kitapkurdu',
           '123',
           'Menekse SAMAN',
           '1985-08-04',
           'meneksesaman@gmail.com',
           '05524178494',
           'xxx',
           'yyy')
GO
  
INSERT INTO [dbo].[Turler]  ([TurAdi])  VALUES  ('Ani')
GO

INSERT INTO [dbo].[Turler]  ([TurAdi])  VALUES  ('Astroloji')
GO

INSERT INTO [dbo].[Turler]  ([TurAdi])  VALUES  ('Astronomi')
GO
   
INSERT INTO [dbo].[Turler]  ([TurAdi])  VALUES  ('Arastirma-Inceleme')
GO

INSERT INTO [dbo].[Turler]  ([TurAdi])  VALUES  ('Bilim')
GO

INSERT INTO [dbo].[Turler]  ([TurAdi])  VALUES  ('Biyografi')
GO

INSERT INTO [dbo].[Turler]  ([TurAdi])  VALUES  ('Dil')
GO

INSERT INTO [dbo].[Turler]  ([TurAdi])  VALUES  ('Din')
GO

INSERT INTO [dbo].[Turler]  ([TurAdi])  VALUES  ('Edebiyat')
GO

INSERT INTO [dbo].[Turler]  ([TurAdi])  VALUES  ('Egitim')
GO

INSERT INTO [dbo].[Turler]  ([TurAdi])  VALUES  ('Bilim Kurgu - Fantastik')
GO

INSERT INTO [dbo].[Turler]  ([TurAdi])  VALUES  ('Felsefe')
GO

INSERT INTO [dbo].[Turler]  ([TurAdi])  VALUES  ('Guncel - Gundelik')
GO

INSERT INTO [dbo].[Turler]  ([TurAdi])  VALUES  ('Hikaye')
GO
	      
INSERT INTO [dbo].[Turler]  ([TurAdi])  VALUES  ('Hukuk')
GO

INSERT INTO [dbo].[Turler]  ([TurAdi])  VALUES  ('Kisisel Gelisim')
GO

INSERT INTO [dbo].[Turler]  ([TurAdi])  VALUES  ('Masal')
GO

INSERT INTO [dbo].[Turler]  ([TurAdi])  VALUES  ('Mizah')
GO

INSERT INTO [dbo].[Turler]  ([TurAdi])  VALUES  ('Oyku')
GO

INSERT INTO [dbo].[Turler]  ([TurAdi])  VALUES  ('Polisiye')
GO

INSERT INTO [dbo].[Turler]  ([TurAdi])  VALUES  ('Psikoloji')
GO

INSERT INTO [dbo].[Turler]  ([TurAdi])  VALUES  ('Roman')
GO

INSERT INTO [dbo].[Turler]  ([TurAdi])  VALUES  ('Saglik')
GO

INSERT INTO [dbo].[Turler]  ([TurAdi])  VALUES  ('Siir')
GO

INSERT INTO [dbo].[Turler]  ([TurAdi])  VALUES  ('Tarih')
GO

INSERT INTO [dbo].[Turler]  ([TurAdi])  VALUES  ('Yemek')
GO