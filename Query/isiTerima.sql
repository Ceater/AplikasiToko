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