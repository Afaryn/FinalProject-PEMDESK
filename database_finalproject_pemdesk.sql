/*==============================================================*/
/* DBMS name:      ORACLE Version 11g                           */
/* Created on:     29/12/2022 22:54:42                          */
/*==============================================================*/


alter table AKTIVITAS_AKUN
   drop constraint FK_AKTIVITA_MELAKUKAN_STAFF;

alter table DETAIL_PAKET
   drop constraint FK_DETAIL_P_MEMPUNYAI_PAKET_LA;

alter table DETAIL_PAKET
   drop constraint FK_DETAIL_P_TERKANDUN_BAHAN_CU;

alter table DETAIL_TRANSAKSI
   drop constraint FK_DETAIL_T_MEMILIKI_TRANSAKS;

alter table DETAIL_TRANSAKSI
   drop constraint FK_DETAIL_T_TERDAPAT_PAKET_LA;

alter table TRANSAKSI
   drop constraint FK_TRANSAKS_MENERIMA_STAFF;

drop index AKTIVITAS_AKUN_PK;

drop table AKTIVITAS_AKUN cascade constraints;

drop table BAHAN_CUCI cascade constraints;

drop index MEMPUNYAI_FK;

drop index TERKANDUNG_FK;

drop table DETAIL_PAKET cascade constraints;

drop index TERDAPAT_FK;

drop index MEMILIKI_FK;

drop table DETAIL_TRANSAKSI cascade constraints;

drop table PAKET_LAUNDRY cascade constraints;

drop table STAFF cascade constraints;

drop index MENERIMA_FK;

drop table TRANSAKSI cascade constraints;

/*==============================================================*/
/* Table: AKTIVITAS_AKUN                                        */
/*==============================================================*/
create table AKTIVITAS_AKUN 
(
   LOGIN                TIMESTAMP            not null,
   ID_STAFF             VARCHAR2(10),
   LOGOUT               TIMESTAMP,
   constraint PK_AKTIVITAS_AKUN primary key (LOGIN)
);

/*==============================================================*/
/* Index: AKTIVITAS_AKUN_PK                                     */
/*==============================================================*/
create unique index AKTIVITAS_AKUN_PK on AKTIVITAS_AKUN (
   LOGIN ASC
);

/*==============================================================*/
/* Table: BAHAN_CUCI                                            */
/*==============================================================*/
create table BAHAN_CUCI 
(
   ID_BAHAN             VARCHAR2(10)         not null,
   NAMA_BAHAN           VARCHAR2(30),
   STOK_BAHAN           INTEGER,
   constraint PK_BAHAN_CUCI primary key (ID_BAHAN)
);

/*==============================================================*/
/* Table: DETAIL_PAKET                                          */
/*==============================================================*/
create table DETAIL_PAKET 
(
   ID_BAHAN             VARCHAR2(10)         not null,
   ID_PAKET             VARCHAR2(10)         not null,
   TAKARAN              INTEGER,
   constraint PK_DETAIL_PAKET primary key (ID_BAHAN, ID_PAKET)
);

/*==============================================================*/
/* Index: TERKANDUNG_FK                                         */
/*==============================================================*/
create index TERKANDUNG_FK on DETAIL_PAKET (
   ID_BAHAN ASC
);

/*==============================================================*/
/* Index: MEMPUNYAI_FK                                          */
/*==============================================================*/
create index MEMPUNYAI_FK on DETAIL_PAKET (
   ID_PAKET ASC
);

/*==============================================================*/
/* Table: DETAIL_TRANSAKSI                                      */
/*==============================================================*/
create table DETAIL_TRANSAKSI 
(
   ID_TRANSAKSI         VARCHAR2(10)         not null,
   ID_PAKET             VARCHAR2(10)         not null,
   JUMLAH               INTEGER,
   TOTAL                INTEGER,
   constraint PK_DETAIL_TRANSAKSI primary key (ID_TRANSAKSI, ID_PAKET)
);

/*==============================================================*/
/* Index: MEMILIKI_FK                                           */
/*==============================================================*/
create index MEMILIKI_FK on DETAIL_TRANSAKSI (
   ID_TRANSAKSI ASC
);

/*==============================================================*/
/* Index: TERDAPAT_FK                                           */
/*==============================================================*/
create index TERDAPAT_FK on DETAIL_TRANSAKSI (
   ID_PAKET ASC
);

/*==============================================================*/
/* Table: PAKET_LAUNDRY                                         */
/*==============================================================*/
create table PAKET_LAUNDRY 
(
   ID_PAKET             VARCHAR2(10)         not null,
   NAMA_PAKET           VARCHAR2(30),
   HARGA_PAKET          INTEGER,
   constraint PK_PAKET_LAUNDRY primary key (ID_PAKET)
);

/*==============================================================*/
/* Table: STAFF                                                 */
/*==============================================================*/
create table STAFF 
(
   ID_STAFF             VARCHAR2(10)         not null,
   NAMA_STAFF           VARCHAR2(30),
   POSISI_STAFF         VARCHAR2(15),
   HP_STAFF             VARCHAR2(20),
   USERNAME_AKUN_STAFF  VARCHAR2(10),
   PASSWORD_AKUN_STAFF  VARCHAR2(30),
   constraint PK_STAFF primary key (ID_STAFF)
);

/*==============================================================*/
/* Table: TRANSAKSI                                             */
/*==============================================================*/
create table TRANSAKSI 
(
   ID_TRANSAKSI         VARCHAR2(10)         not null,
   ID_STAFF             VARCHAR2(10)         not null,
   TGL_TRANSAKSI        DATE,
   TGL_SELESAI          DATE,
   STATUS_TRANSAKSI     VARCHAR2(10),
   PEMBAYARAN_TRANSAKSI VARCHAR2(10),
   NAMA_CUST            VARCHAR2(30),
   HP_CUST              VARCHAR2(20),
   ALAMAT_CUST          VARCHAR2(50),
   constraint PK_TRANSAKSI primary key (ID_TRANSAKSI)
);

/*==============================================================*/
/* Index: MENERIMA_FK                                           */
/*==============================================================*/
create index MENERIMA_FK on TRANSAKSI (
   ID_STAFF ASC
);

alter table AKTIVITAS_AKUN
   add constraint FK_AKTIVITA_MELAKUKAN_STAFF foreign key (ID_STAFF)
      references STAFF (ID_STAFF);

alter table DETAIL_PAKET
   add constraint FK_DETAIL_P_MEMPUNYAI_PAKET_LA foreign key (ID_PAKET)
      references PAKET_LAUNDRY (ID_PAKET);

alter table DETAIL_PAKET
   add constraint FK_DETAIL_P_TERKANDUN_BAHAN_CU foreign key (ID_BAHAN)
      references BAHAN_CUCI (ID_BAHAN);

alter table DETAIL_TRANSAKSI
   add constraint FK_DETAIL_T_MEMILIKI_TRANSAKS foreign key (ID_TRANSAKSI)
      references TRANSAKSI (ID_TRANSAKSI);

alter table DETAIL_TRANSAKSI
   add constraint FK_DETAIL_T_TERDAPAT_PAKET_LA foreign key (ID_PAKET)
      references PAKET_LAUNDRY (ID_PAKET);

alter table TRANSAKSI
   add constraint FK_TRANSAKS_MENERIMA_STAFF foreign key (ID_STAFF)
      references STAFF (ID_STAFF);

