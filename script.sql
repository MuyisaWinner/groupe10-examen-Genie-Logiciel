CREATE DATABASE groupe10

USE groupe10

CREATE TABLE personnesTable(
id VARCHAR(255) PRIMARY KEY,
nom VARCHAR(255) NOT NULL,
post VARCHAR(255) NOT NULL,
prenon VARCHAR(255) NOT NULL,
sexe VARCHAR(255) NOT NULL
)
ALTER TABLE personnesTable ALTER COLUMN sexe VARCHAR(255);


EXEC sp_rename 'personnesTable.prenon', 'prenom', 'COLUMN';


CREATE TABLE adresseTable(
id VARCHAR(255) PRIMARY KEY,
numero VARCHAR(20) NOT NULL,
avenue VARCHAR(255) NOT NULL,
quartier VARCHAR(255) NOT NULL,
commune VARCHAR(255) NOT NULL,
ville VARCHAR(255) NOT NULL,
person VARCHAR(255) NOT NULL,
)

ALTER TABLE adresseTable
ADD person VARCHAR(255) NOT NULL

ALTER TABLE adresseTable
ADD CONSTRAINT fk_person
FOREIGN KEY (person)
REFERENCES personnesTable(id);





CREATE TABLE telephoneTable(
id VARCHAR(255) PRIMARY KEY NOT NULL,
code VARCHAR(255) NOT NULL,
numero VARCHAR(255) NOT NULL,
person VARCHAR(255) NOT NULL
)

ALTER TABLE telephoneTable
ADD CONSTRAINT fk_person_phone
FOREIGN KEY (person)
REFERENCES personnesTable(id);


SELECT p.nom as nom, p.post as post, p.prenom as prenom, a.numero as numero, a.quartier as quartier, a.commune as commune, a.ville as ville, t.code as code, t.numero as numero
 FROM personnesTable p
LEFT JOIN adresseTable a on a.person = p.id
LEFT JOIN telephoneTable t on t.person = p.id


