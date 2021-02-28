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

insert into dbo.Cars(BrandId, ColorId, ModelYear, Description, DailyPrice)values('1','1','2020','Teminat Gerekli','650')
insert into dbo.Cars(ModelYear, Description, DailyPrice)values('2020','Teminat Gerekli','600')
insert into dbo.Cars(ModelYear, Description, DailyPrice)values('2020','Teminat Gerekli','600')
insert into dbo.Cars(ModelYear, Description, DailyPrice)values('2019','Teminat Gerekmez','400')
insert into dbo.Cars(ModelYear, Description, DailyPrice)values('2019','Teminat Gerekmez','350')
insert into dbo.Cars(ModelYear, Description, DailyPrice)values('2018','Teminat Gerekmez','250')
insert into dbo.Cars(ModelYear, Description, DailyPrice)values('2018','Teminat Gerekmez','200')
insert into dbo.Cars(ModelYear, Description, DailyPrice)values('2017','Teminat Gerekmez','190')

select*from Cars

insert into dbo.Colors(ColorName)values('Siyah');
insert into dbo.Colors(ColorName)values('Beyaz');
insert into dbo.Colors(ColorName)values('Gri');
insert into dbo.Colors(ColorName)values('Kırmızı');

select*from Colors