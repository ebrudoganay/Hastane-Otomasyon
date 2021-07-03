create database hastane;
use hastane;



/*TABLO OLUŞTURMA*/
create table hastalar(TCkimlikNo varchar(11)  PRIMARY KEY, ad varchar(20),soyad varchar(20), yas INT, cinsiyet varchar(5), boy INT,KİLO INT);
create table kayıt(TCkimlikNo varchar(11),bolumKodu varchar(5),gün varchar(15),PRIMARY KEY(TCkimlikNo,bolumKodu));
create table bolumler(bolumKodu varchar(5) PRIMARY KEY,bolumAdi varchar(20),poliklinikKodu varchar(20),doktorID INT);
create table poliklinikler(PoliklinikKodu varchar(20) PRIMARY KEY,poliklinikAdi varchar(15));
create table doktorlar(doktorID INT PRIMARY KEY, ad varchar(20), soyad varchar(20));

/*KAYIT EKLE*/

INSERT INTO hastalar(TCkimlikNo,ad,soyad,yas,cinsiyet,boy,kilo) VALUES('48121577184','ASLI','BOZOK',24,'KADIN',168,60);
INSERT INTO hastalar(TCkimlikNo,ad,soyad,yas,cinsiyet,boy,kilo) VALUES('42300557122','AYŞEGÜL','OTAĞ',18,'KADIN',160,55);
INSERT INTO hastalar(TCkimlikNo,ad,soyad,yas,cinsiyet,boy,kilo) VALUES('13262472222','FATİH','ÇELİK',16,'ERKEK',170,72);
INSERT INTO hastalar(TCkimlikNo,ad,soyad,yas,cinsiyet,boy,kilo) VALUES('43661200361','SEDA','KAYA',20,'KADIN',150,65);
INSERT INTO hastalar(TCkimlikNo,ad,soyad,yas,cinsiyet,boy,kilo) VALUES('41122577090','AHMET','GUNGOR',25,'ERKEK',182,85);
INSERT INTO hastalar(TCkimlikNo,ad,soyad,yas,cinsiyet,boy,kilo) VALUES('48301572030','SELİM','ÇAKIR',50,'ERKEK',175,90);
INSERT INTO hastalar(TCkimlikNo,ad,soyad,yas,cinsiyet,boy,kilo) VALUES('42128474158','EMRE','GÜR',30,'ERKEK',185,85);
INSERT INTO hastalar(TCkimlikNo,ad,soyad,yas,cinsiyet,boy,kilo) VALUES('40041612165','HATİCE','AYGÜN',28,'KADIN',161,57);
INSERT INTO hastalar(TCkimlikNo,ad,soyad,yas,cinsiyet,boy,kilo) VALUES('40005532108','BURCU','HOŞ',25,'KADIN',167,58);
INSERT INTO hastalar(TCkimlikNo,ad,soyad,yas,cinsiyet,boy,kilo) VALUES('43668596133','SERKAN','YILDIRIM',36,'ERKEK',180,89);


INSERT INTO kayıt(TCkimlikNo,bolumKodu,gün) VALUES('48121577184','CLD25','PAZARTESİ');
INSERT INTO kayıt(TCkimlikNo,bolumKodu,gün) VALUES('43661200361','CLD25','PAZARTESİ');
INSERT INTO kayıt(TCkimlikNo,bolumKodu,gün) VALUES('42300557122','GOG15','ÇARŞAMBA');
INSERT INTO kayıt(TCkimlikNo,bolumKodu,gün) VALUES('13262472222','DHL36','PERŞEMBE');
INSERT INTO kayıt(TCkimlikNo,bolumKodu,gün) VALUES('48301572030','KRD20','CUMA');
INSERT INTO kayıt(TCkimlikNo,bolumKodu,gün) VALUES('42128474158','NFR23','CUMA');
INSERT INTO kayıt(TCkimlikNo,bolumKodu,gün) VALUES('40041612165','NFR23','SALI');
INSERT INTO kayıt(TCkimlikNo,bolumKodu,gün) VALUES('40005532108','ORT65','PAZARTESİ');
INSERT INTO kayıt(TCkimlikNo,bolumKodu,gün) VALUES('43668596133','ROM90','ÇARŞAMBA');
INSERT INTO kayıt(TCkimlikNo,bolumKodu,gün) VALUES('43661200361','GOG15','ÇARŞAMBA');
INSERT INTO kayıt(TCkimlikNo,bolumKodu,gün) VALUES('48301572030','ROM90','PERŞEMBE');
INSERT INTO kayıt(TCkimlikNo,bolumKodu,gün) VALUES('41122577090','CLD25','ÇARŞAMBA');
INSERT INTO kayıt(TCkimlikNo,bolumKodu,gün) VALUES('42128474158','KRD20','PAZARTESİ');
INSERT INTO kayıt(TCkimlikNo,bolumKodu,gün) VALUES('13262472222','CLD25','SALI');


INSERT INTO bolumler (bolumKodu,bolumAdi,poliklinikKodu,doktorID) VALUES('CLD25','CİLDİYE','PLKNK1',1);
INSERT INTO bolumler (bolumKodu,bolumAdi,poliklinikKodu,doktorID) VALUES('GOG15','GÖGÜS HASTALIKLARI','PLKNK2',5);
INSERT INTO bolumler (bolumKodu,bolumAdi,poliklinikKodu,doktorID) VALUES('DHL36','DAHİLİYE','PLKNK3',3);
INSERT INTO bolumler (bolumKodu,bolumAdi,poliklinikKodu,doktorID) VALUES('KRD20','KARDİYOLOJİ','PLKNK4',2);
INSERT INTO bolumler (bolumKodu,bolumAdi,poliklinikKodu,doktorID) VALUES('NFR23','NEFROLOJİ','PLKNK5',4);
INSERT INTO bolumler (bolumKodu,bolumAdi,poliklinikKodu,doktorID) VALUES('NRL10','NÖROLOJİ','PLKNK6',6);
INSERT INTO bolumler (bolumKodu,bolumAdi,poliklinikKodu,doktorID) VALUES('ORT65','ORTOPEDİ','PLKNK7',8);
INSERT INTO bolumler (bolumKodu,bolumAdi,poliklinikKodu,doktorID) VALUES('PSK30','PSİKİYATRİ','PLKNK8',7);
INSERT INTO bolumler (bolumKodu,bolumAdi,poliklinikKodu,doktorID) VALUES('HEM40','HEMATOLOJİ','PLKNK9',9);
INSERT INTO bolumler (bolumKodu,bolumAdi,poliklinikKodu,doktorID) VALUES('ROM90','ROMATOLOJİ','PLKNK10',10);

INSERT INTO poliklinikler(poliklinikKodu,poliklinikAdi) VALUES('PLKNK1','POLİKLİNİK_1');
INSERT INTO poliklinikler(poliklinikKodu,poliklinikAdi) VALUES('PLKNK2','POLİKLİNİK_2');
INSERT INTO poliklinikler(poliklinikKodu,poliklinikAdi) VALUES('PLKNK3','POLİKLİNİK_3');
INSERT INTO poliklinikler(poliklinikKodu,poliklinikAdi) VALUES('PLKNK4','POLİKLİNİK_4');
INSERT INTO poliklinikler(poliklinikKodu,poliklinikAdi) VALUES('PLKNK5','POLİKLİNİK_5');
INSERT INTO poliklinikler(poliklinikKodu,poliklinikAdi) VALUES('PLKNK6','POLİKLİNİK_6');
INSERT INTO poliklinikler(poliklinikKodu,poliklinikAdi) VALUES('PLKNK7','POLİKLİNİK_7');
INSERT INTO poliklinikler(poliklinikKodu,poliklinikAdi) VALUES('PLKNK8','POLİKLİNİK_8');
INSERT INTO poliklinikler(poliklinikKodu,poliklinikAdi) VALUES('PLKNK9','POLİKLİNİK_9');
INSERT INTO poliklinikler(poliklinikKodu,poliklinikAdi) VALUES('PLKNK10','POLİKLİNİK_10');

INSERT INTO doktorlar(doktorID,ad,soyad) VALUES(1,'ERHAN','ERSOY');
INSERT INTO doktorlar(doktorID,ad,soyad) VALUES(2,'GURAY','ALTIN');
INSERT INTO doktorlar(doktorID,ad,soyad) VALUES(3,'MURAT','KILIC');
INSERT INTO doktorlar(doktorID,ad,soyad) VALUES(4,'SEYMA','BASLILAR');
INSERT INTO doktorlar(doktorID,ad,soyad) VALUES(5,'SEDA','ÖZTÜRKMEN');
INSERT INTO doktorlar(doktorID,ad,soyad) VALUES(6,'NESLİHAN','UZUN');
INSERT INTO doktorlar(doktorID,ad,soyad) VALUES(7,'ELİF','DİNÇER');
INSERT INTO doktorlar(doktorID,ad,soyad) VALUES(8,'ESEN','GÜNAL');
INSERT INTO doktorlar(doktorID,ad,soyad) VALUES(9,'ERSAN','AKSU');
INSERT INTO doktorlar(doktorID,ad,soyad) VALUES(10,'MELTEM','GÜLÇİN');



SELECT ad,soyad from hastalar where TCkimlikNo IN(
SELECT TCkimlikNo  from kayıt where gün='PAZARTESİ');

SELECT * from hastalar where TCkimlikNo IN(
SELECT TCkimlikNo from kayıt where bolumKodu IN(
SELECT bolumKodu  from bolumler where bolumAdi='CİLDİYE'));


SELECT * from hastalar where TCkimlikNo IN(
SELECT TCkimlikNo from kayıt where  gün='PAZARTESİ' OR bolumKodu IN(
SELECT bolumKodu  from bolumler where bolumAdi='NEFROLOJİ'));

SELECT * FROM  doktorlar where doktorID IN(
SELECT  doktorID from bolumler where bolumAdi='CİLDİYE');

SELECT * FROM doktorlar where doktorID IN(
SELECT doktorID from bolumler where poliklinikKodu IN(
SELECT poliklinikKodu from poliklinikler where poliklinikAdi='POLİKLİNİK_1'));

SELECT * FROM doktorlar where doktorID IN(
SELECT doktorID from bolumler where bolumAdi='NEFROLOJİ' OR  poliklinikKodu IN(
SELECT poliklinikKodu from poliklinikler where poliklinikAdi='POLİKLİNİK_1'));

















