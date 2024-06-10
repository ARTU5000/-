USE fallout;

CREATE TABLE vault_DWeller (
	id BIGINT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(180) NOT NULL,
    gender VARCHAR(180) NOT NULL,
    life VARCHAR(180) NOT NULL,
    level VARCHAR(180) NOT NULL,
    strength VARCHAR(90) NOT NULL,
    perception VARCHAR(90) NOT NULL,
    endurance VARCHAR(90) NOT NULL,
    charisma VARCHAR(90) NOT NULL,
    inteligence VARCHAR(90) NOT NULL,
    agility VARCHAR(90) NOT NULL,
    luck VARCHAR(90) NOT NULL
);

//------------------tabla de personajes


CREATE Table datos(
    id BIGINT PRIMARY KEY AUTO_INCREMENT,
    energia   iNTEGER NOT NULL,
    agua iNTEGER NOT NULL,
    comida iNTEGER NOT NULL   
);