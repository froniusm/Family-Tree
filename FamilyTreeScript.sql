drop table person;
drop table relationship;
drop table relationship_type;

create Table relationship_category
(
	typeId int identity(1,1),
	relationshipType varchar(100) not null,

	CONSTRAINT pk_relationship_category_typeId     PRIMARY KEY (typeId)
);

create Table person
(
	personId int identity(1,1),
	firstName varchar(100) not null,
	middleInitial varchar(1),
	lastName varchar(100) not null,
	birthDate date not null,
	deathDate date, 
	isAlive bit not null,
	gender char not null, 

	CONSTRAINT chk_gender		CHECK (Gender IN ('M', 'F')),
	CONSTRAINT pk_personId		PRIMARY KEY (personId)
);

create Table relationship
(
	fromId int not null,
	toId int not null,
	typeId int not null,

	CONSTRAINT pk_relationship_fromId_toId	PRIMARY KEY (fromId, toId),
	CONSTRAINT fk_relationship_typeId          FOREIGN KEY (typeId)           REFERENCES relationship_category(typeId),
	CONSTRAINT fk_relationship_fromId			FOREIGN KEY (fromId)			REFERENCES person(personId),
	CONSTRAINT fk_relationship_toId			FOREIGN KEY (toId)				REFERENCES  person(personId)
);


