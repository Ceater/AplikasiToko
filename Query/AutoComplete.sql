delete DBeli
delete DJual
delete HBeli
delete HJual
delete DReturBeli
delete DReturJual
delete HReturBeli
delete HReturJual
delete TbBarang
delete TbKontakSupplier
delete TbSatuan
delete DSatuan
delete TbStaff
delete TbSupplier
delete TbPelanggan
DBCC CHECKIDENT ('DJual', RESEED, 0);
DBCC CHECKIDENT ('DSatuan', RESEED, 0);
DBCC CHECKIDENT ('DTerima', RESEED, 0);
DBCC CHECKIDENT ('TbKontakSupplier', RESEED, 0);
DBCC CHECKIDENT ('TbPelanggan', RESEED, 0);
DBCC CHECKIDENT ('TbPembayaran', RESEED, 0);
DBCC CHECKIDENT ('TbSupplier', RESEED, 0);
insert into TbBarang values('PE001','Pepsodent Kecil',0,2,2500,5)
insert into TbBarang values('PE002','Pepsodent Sedang',0,2,5000,5)
insert into TbBarang values('PE003','Pepsodent Besar',0,2,7500,5)
insert into TbBarang values('SA001','Sabun Lifeboy',0,6,3500,5)
insert into TbBarang values('SA002','Sabun Lux',0,6,3500,5)
insert into TbBarang values('GE001','Gery Chocolatos',0,7,500,0)
insert into TbBarang values('GE002','Gery Chocolatos',0,14,10000,5)
insert into TbBarang values('AQ001','Aqua Gelas',0,2,500,10)
insert into TbBarang values('AQ002','Aqua Sedang',0,11,3000,10)
insert into TbBarang values('AQ003','Aqua 1.5L',0,11,5000,10)
insert into TbBarang values('TE001','Teh Pucuk Harum',0,11,5000,10)
insert into TbBarang values('YO001','You C 1000',0,11,8000,10)
insert into TbBarang values('RO001','Rokok Inter',0,7,13000,5)
insert into TbBarang values('RO002','Rokok Surya',0,7,13000,5)
insert into TbBarang values('RO003','Rokok UMild',0,7,15000,5)
insert into TbSatuan values('1','Unit')
insert into TbSatuan values('2','Buah')
insert into TbSatuan values('3','Pasang')
insert into TbSatuan values('4','Lembar')
insert into TbSatuan values('5','Keping')
insert into TbSatuan values('6','Batang')
insert into TbSatuan values('7','Bungkus')
insert into TbSatuan values('8','Potong')
insert into TbSatuan values('9','Tablet')
insert into TbSatuan values('10','Rim')
insert into TbSatuan values('11','Botol')
insert into TbSatuan values('12','Butir')
insert into TbSatuan values('13','Roll')
insert into TbSatuan values('14','Dus')
insert into TbSatuan values('15','Karung')
insert into TbSatuan values('16','Koli')
insert into TbSatuan values('17','Sak')
insert into TbSatuan values('18','Bal')
insert into TbSatuan values('19','Kaleng')
insert into TbSatuan values('20','Set')
insert into TbSatuan values('21','Slop')
insert into TbSatuan values('22','Gulung')
insert into TbSatuan values('23','Ton')
insert into TbSatuan values('24','Kilogram')
insert into TbSatuan values('25','Gram')
insert into TbSatuan values('26','Miligram')
insert into TbSatuan values('27','Meter')
insert into TbSatuan values('28','Liter')
insert into DSatuan values('PE001','2',0)
insert into DSatuan values('PE002','2',0)
insert into DSatuan values('PE003','6',0)
insert into DSatuan values('SA001','6',0)
insert into DSatuan values('SA002','2',0)
insert into DSatuan values('GE001','7',0)
insert into DSatuan values('GE002','14',0)
insert into DSatuan values('AQ001','2',0)
insert into DSatuan values('AQ002','11',0)
insert into DSatuan values('AQ003','11',0)
insert into DSatuan values('TE001','11',0)
insert into DSatuan values('YO001','11',0)
insert into DSatuan values('RO001','7',0)
insert into DSatuan values('RO002','7',0)
insert into DSatuan values('RO003','7',0)
insert into TbKontakSupplier values('1','Andri Mulyanto','5614844')
insert into TbKontakSupplier values('1','Feby Adrian','6419275')
insert into TbKontakSupplier values('2','Maikelele','5714829')
insert into TbKontakSupplier values('3','Pujiyanto','5418391')
insert into TbKontakSupplier values('4','Mlaikel','7193846')
insert into TbKontakSupplier values('5','Mihael','51048751')
insert into TbPelanggan values('Johan Jusianto','Kupang Panjaan','031-5614844')
insert into TbPelanggan values('Willy Budiman','Pandegiling','031-5674380')
insert into TbPelanggan values('Kent Tanuwijaya','Dinoyo','08175135582')
insert into TbPelanggan values('Marissa Clara','Dukuh Pakis','082232130065')
insert into TbPelanggan values('Oktaviani Sherly Diaz','Pakuwon City Regency','083849492993')
insert into TbStaff values('admin','admin','Johan Jusianto','Kupang Panjaan','08175135582','1')
insert into TbStaff values('kasir','kasir','Chintya Marcheline','Diponegoro','081081081081','1')
insert into TbSupplier values('Unilever','Kupang Panjaan')
insert into TbSupplier values('Wings','Diponegoro')
insert into TbSupplier values('Alexa','GWalk')
insert into TbSupplier values('Msi','Putat Jaya')
insert into TbSupplier values('Asus','Ngagel Selatan')
delete HTerima
delete DTerima
insert into HTerima values('1','6/14/2017','admin')
insert into DTerima Values('1', 'PE001', 'Pepsodent Kecil', 'Buah', 100)
insert into DTerima Values('1', 'PE002', 'Pepsodent Sedang', 'Buah', 100)
insert into DTerima Values('1', 'PE003', 'Pepsodent Besar', 'Buah', 100)
update TbBarang set stok=stok+100 where KodeBarang='PE001'
update TbBarang set stok=stok+100 where KodeBarang='PE002'
update TbBarang set stok=stok+100 where KodeBarang='PE003'
insert into HTerima values('2','6/17/2017','admin')
insert into DTerima Values('2', 'SA001', 'Sabun Lifeboy', 'Batang', 100)
insert into DTerima Values('2', 'SA002', 'Sabun Lux', 'Batang', 100)
update TbBarang set stok=stok+100 where KodeBarang='SA001'
update TbBarang set stok=stok+100 where KodeBarang='SA002'
insert into HTerima values('3','6/17/2017','admin')
insert into DTerima Values('3', 'GE001', 'Gery Chocolatos', 'Bungkus', 100)
insert into DTerima Values('3', 'GE002', 'Gery Chocolatos', 'Dus', 100)
update TbBarang set stok=stok+100 where KodeBarang='GE001'
update TbBarang set stok=stok+100 where KodeBarang='GE002'
insert into HTerima values('4','6/17/2017','admin')
insert into DTerima Values('4', 'AQ001', 'Aqua Gelas', 'Buah', 100)
insert into DTerima Values('4', 'AQ002', 'Aqua Sedang', 'Botol', 100)
insert into DTerima Values('4', 'AQ003', 'Aqua 1.5L', 'Botol', 100)
update TbBarang set stok=stok+100 where KodeBarang='AQ001'
update TbBarang set stok=stok+100 where KodeBarang='AQ002'
update TbBarang set stok=stok+100 where KodeBarang='AQ003'
insert into HTerima values('5','6/18/2017','admin')
insert into DTerima Values('5', 'TE001', 'Teh Pucuk Harum', 'Botol', 100)
insert into DTerima Values('5', 'YO001', 'You C 1000', 'Botol', 100)
update TbBarang set stok=stok+100 where KodeBarang='TE001'
update TbBarang set stok=stok+100 where KodeBarang='YO001'
insert into HTerima values('6','6/18/2017','admin')
insert into DTerima Values('6', 'RO001', 'Rokok Inter', 'Bungkus', 100)
insert into DTerima Values('6', 'RO002', 'Rokok Surya', 'Bungkus', 100)
insert into DTerima Values('6', 'RO003', 'Rokok UMild', 'Bungkus', 100)
update TbBarang set stok=stok+100 where KodeBarang='RO001'
update TbBarang set stok=stok+100 where KodeBarang='RO002'
update TbBarang set stok=stok+100 where KodeBarang='RO003'
delete HJual
delete DJual
delete TbPembayaran
insert into HJual Values('1', '6/9/2017', 10000, 'Toko Maju Jaya','admin')
insert into DJUal Values('1', 'PE001', 'Pepsodent Kecil', 'Buah', 2500, 2, 0, 5000)
insert into DJUal Values('1', 'PE002', 'Pepsodent Sedang', 'Buah', 5000, 1, 0, 5000)
insert into TbPembayaran Values('1', '6/9/2017', 10000)
insert into HJual Values('2', '6/10/2017', 15000, 'Toko Maju Mundur', 'admin')
insert into DJUal Values('2', 'PE001', 'Pepsodent Kecil', 'Buah', 2500, 2, 0, 5000)
insert into DJUal Values('2', 'GE002', 'Gery Chocolatos', 'Dus', 10000, 1, 0, 10000)
insert into TbPembayaran Values('2', '6/11/2017', 10000)
insert into HJual Values('3', '6/11/2017', 20000, 'Toko Kiri Kanan', 'admin')
insert into DJUal Values('3', 'PE001', 'Pepsodent Kecil', 'Buah', 2500, 2, 0, 5000)
insert into DJUal Values('3', 'GE002', 'Gery Chocolatos', 'Dus', 10000, 1, 0, 10000)
insert into DJUal Values('3', 'AQ003', 'Aqua 1.5L', 'Botol', 5000, 1, 0, 5000)
insert into TbPembayaran Values('3', '6/13/2017', 15000)
insert into HJual Values('4', '6/12/2017', 25000, 'Toko Sayonara', 'admin')
insert into DJUal Values('4', 'RO003', 'Rokok UMild', 'Bungkus', 15000, 1, 0, 15000)
insert into DJUal Values('4', 'GE002', 'Gery Chocolatos', 'Dus', 10000, 1, 0, 10000)
insert into TbPembayaran Values('4', '6/14/2017', 25000)
insert into HJual Values('5', '6/13/2017', 39000, 'Toko Permata', 'admin')
insert into DJUal Values('5', 'RO001', 'Rokok Inter', 'Bungkus', 13000, 2, 0, 26000)
insert into DJUal Values('5', 'RO002', 'Rokok Surya', 'Dus', 13000, 1, 0, 13000)
insert into TbPembayaran Values('5', '6/14/2017', 25000)