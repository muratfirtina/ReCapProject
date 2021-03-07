insert into dbo.Brands(BrandName)values('Mercedes');
insert into dbo.Brands(BrandName)values('Audi');
insert into dbo.Brands(BrandName)values('BMW');
insert into dbo.Brands(BrandName)values('Wolksvagen');
insert into dbo.Brands(BrandName)values('Ford');
insert into dbo.Brands(BrandName)values('Opel');
insert into dbo.Brands(BrandName)values('Renault');
insert into dbo.Brands(BrandName)values('Hyundai');

select*from Brands
delete from Brands
DBCC CHECKIDENT ('Brands',RESEED,0) --id sıfırlama


select*from Cars

insert into dbo.Colors(ColorName)values('Siyah');
insert into dbo.Colors(ColorName)values('Beyaz');
insert into dbo.Colors(ColorName)values('Gri');
insert into dbo.Colors(ColorName)values('Kırmızı');

select*from Colors