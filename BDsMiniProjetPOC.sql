create database labobd;
use labobd;

create table Laboratoire(acronyme VARCHAR(10) PRIMARY KEY,nom VARCHAR(30),anneeAgrement int,username VARCHAR(10));
create table Equipe(id_equipe int AUTO_INCREMENT PRIMARY KEY,nom VARCHAR(30) NOT NULL,username VARCHAR(10),acronyme VARCHAR(10) ,FOREIGN KEY(acronyme) REFERENCES Laboratoire(acronyme));

create database chercheurbd;
use chercheurbd;
create table Administrateur(nom VARCHAR(30),prenom VARCHAR(30),date_niass DATE,lieu_naiss VARCHAR(15),adress VARCHAR(40),username VARCHAR(10) PRIMARY KEY,password VARCHAR(32),email VARCHAR(30),sexe VARCHAR(6));

create table Chercheur(nom VARCHAR(30),prenom VARCHAR(30),date_niass DATE,lieu_naiss VARCHAR(15),adress VARCHAR(40),username VARCHAR(10) PRIMARY KEY,password VARCHAR(32),email VARCHAR(30),sexe VARCHAR(6),interet VARCHAR(255),domaine VARCHAR(30),photo blob);
create table Directure(nom VARCHAR(30),prenom VARCHAR(30),date_niass DATE,lieu_naiss VARCHAR(15),adress VARCHAR(40),username VARCHAR(10) PRIMARY KEY,password VARCHAR(32),email VARCHAR(30),sexe VARCHAR(6),interet VARCHAR(255),domaine VARCHAR(30),photo blob);
create table Chef_equipe(nom VARCHAR(30),prenom VARCHAR(30),date_niass DATE,lieu_naiss VARCHAR(15),adress VARCHAR(40),username VARCHAR(10) PRIMARY KEY,password VARCHAR(32),email VARCHAR(30),sexe VARCHAR(6),interet VARCHAR(255),domaine VARCHAR(30),photo blob);

create table affectationChercheur(username VARCHAR(10) PRIMARY KEY,id_equipe int,FOREIGN KEY(username) REFERENCES Chercheur(username));


create database productionbd;
USE productionbd;

create table Conference(id_production int PRIMARY KEY,nom VARCHAR(30),date DATE,description VARCHAR(30),mot_cle VARCHAR(255),username VARCHAR(10),lieu VARCHAR(30),places int,salle VARCHAR(30),dure VARCHAR(30));
create table Article(id_production int PRIMARY KEY AUTO_INCREMENT,nom VARCHAR(30),date DATE,description VARCHAR(30),mot_cle VARCHAR(255),username VARCHAR(10),pages int,fichier LONGBLOB,langue VARCHAR(30));
create table Livre(id_production int PRIMARY KEY AUTO_INCREMENT,nom VARCHAR(30),date DATE,description VARCHAR(30),mot_cle VARCHAR(255),username VARCHAR(10),fichierpdf LONGBLOB,pages int,version int,langue VARCHAR(30));

create table NotificationConference(id int PRIMARY KEY AUTO_INCREMENT,vue TINYINT(1),username VARCHAR(10),id_production int, FOREIGN KEY(id_production) REFERENCES Conference(id_production));

create table NotificationArticlee(id int PRIMARY KEY AUTO_INCREMENT,vue TINYINT(1),username VARCHAR(10), id_production int, FOREIGN KEY(id_production) REFERENCES Article(id_production));

create table NotificationLivre(id int PRIMARY KEY AUTO_INCREMENT,vue TINYINT(1),username VARCHAR(10),id_production int, FOREIGN KEY(id_production) REFERENCES Livre(id_production));



create table Form(id int PRIMARY KEY AUTO_INCREMENT,nom VARCHAR(30),date Date,photo blob,description VARCHAR(255),video blob,username VARCHAR(10));
create table Commentaire(id int PRIMARY KEY AUTO_INCREMENT,root int,commentaire VARCHAR(255),photo blob,video blob,date Date,username VARCHAR(10));
create table React(id int PRIMARY KEY AUTO_INCREMENT,root int,type TINYINT(1),username VARCHAR(10));

create table FromCommentaire(id_from int, FOREIGN KEY(id_from) REFERENCES Form(id),id_comm int, FOREIGN KEY(id_comm) REFERENCES Commentaire(id),PRIMARY KEY(id_from,id_comm));
create table FromReact(id_from int ,FOREIGN KEY(id_from) REFERENCES Form(id),id_react int, FOREIGN KEY(id_react) REFERENCES React(id),PRIMARY KEY(id_from,id_react));
create table CommentaireReact(id_react int, FOREIGN KEY(id_react) REFERENCES React(id),id_comm int, FOREIGN KEY(id_comm) REFERENCES Commentaire(id),PRIMARY KEY(id_react,id_comm));


create table ConferenceFichiers(id_production int,fichier LONGBLOB,numfichier int, PRIMARY KEY(id_production,numfichier),FOREIGN KEY(id_production) REFERENCES Conference(id_production));



create database projetbd;
USE projetbd;
create table Projet(id int AUTO_INCREMENT,nom VARCHAR(30),username VARCHAR(10),PRIMARY KEY(id));
create table PRFU(id int AUTO_INCREMENT,nom VARCHAR(30),username VARCHAR(10),verifeirCondition TINYINT(1),PRIMARY KEY(id));

create table FichierProjet(id_fichier int AUTO_INCREMENT PRIMARY KEY,fichier blob,
id int, FOREIGN KEY(id) REFERENCES Projet(id));

create table FichierPRFU(id_fichier int AUTO_INCREMENT PRIMARY KEY,fichier blob,
id int, FOREIGN KEY(id) REFERENCES PRFU(id));

create table projetChercheur(username VARCHAR(10) PRIMARY KEY,id_projet int, FOREIGN KEY(id_projet) REFERENCES Projet(id));
create table projetPRFUchercheur(username VARCHAR(10) PRIMARY KEY,id_projet int, FOREIGN KEY(id_projet) REFERENCES PRFU(id));


