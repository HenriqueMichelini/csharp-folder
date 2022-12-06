create database trabalho;
use trabalho;
CREATE table usuario(
    idUser int PRIMARY KEY AUTO_INCREMENT,
     cpf varchar(30) not null UNIQUE,
    senha varchar(30) not null,
    primeiro_nome varchar(30),
    ultimo_nome varchar(30)
);

create table cargo(
	idCargo int primary key auto_increment,
    nome varchar(30) not null,
    salario decimal(10,2)
);

CREATE table funcionario(
    idFunc int PRIMARY KEY AUTO_INCREMENT,
     cpfFunc varchar(30) not null UNIQUE,
    senhaFunc varchar(30) not null,
    primeiro_nomeFunc varchar(30) not null,
    ultimo_nomeFunc varchar(30) not null,
    enderecoFunc varchar(60)  not null,
    Cargo int not null,
    foreign key (Cargo) references cargo(idCargo)
);

CREATE table hotel(
  IdHotel int PRIMARY KEY AUTO_INCREMENT,
    nome varchar(30) not null,
    qtd_quartos int not null,
    preco_quarto decimal(10, 2),
    gerente int not null,
    foreign key gerente(gerente) references funcionario(idFunc)
);

create table reserva(
    id int PRIMARY KEY AUTO_INCREMENT,
    usuario int not null,
    hotel int not null,
    funcionario int not null,
    FOREIGN KEY (usuario) REFERENCES usuario(idUser),
    FOREIGN KEY (hotel) REFERENCES hotel(IdHotel),
    FOREIGN KEY (funcionario) REFERENCES funcionario(idFunc)
);


create table bonus(
    id int PRIMARY key AUTO_INCREMENT,
    valBonus decimal(10,2) not null,
    idFuncionario int not null,
    FOREIGN KEY (idFuncionario) REFERENCES funcionario(idFunc)
);

create table verLogin(
	idLogin int primary key auto_increment,
    funcionario int not null,
    horario datetime default CURRENT_TIMESTAMP,
    foreign key (funcionario) references funcionario(idFunc)
);

create table audit(
	id int primary key auto_increment,
	oldPass varchar(30) not null,
    newPass varchar(30) not null,
    funcionario int not null,
    FOREIGN KEY (funcionario) REFERENCES funcionario(idFunc)
);

create table funcMsg(
	id int primary key auto_increment,
    msg varchar(100) not null,
    funcionario int not null,
    FOREIGN KEY (funcionario) REFERENCES funcionario(idFunc)
);



create table wasCliente(
	id int primary key auto_increment,
    cpf varchar(30) not null
);


create or replace view listFun as select * from funcionario as f inner join cargo as c;
create or replace view listHotel as SELECT * from hotel as h inner join funcionario as f on h.gerente = f.idFunc;
create or replace view listBonus as select * from bonus as b inner join funcionario as f on b.idFuncionario = f.idFunc;
create or replace view listReserva as select * from reserva as r inner join usuario as u on u.idUser = usuario inner join hotel as h on h.IdHotel = r.hotel inner join funcionario as f on f.idFunc = r.funcionario;
create or replace view listLogins as select * from verLogin as vl inner join funcionario as f on vl.funcionario = f.idFunc;




DELIMITER $$

CREATE PROCEDURE isRealUser(
	in userna varchar(30),
	in passwordin varchar(30),
	out canLog boolean
)

BEGIN
DECLARE usern varchar(70) DEFAULT "";

SELECT primeiro_nomeFunc into usern from funcionario where cpfFunc = userna and senhaFunc = passwordin;

if usern <> "" THEN
	set canLog = 1;
else
	set canLog = 0;
end if;
end $$
DELIMITER ;




DELIMITER $$

CREATE PROCEDURE CheckPass(
	in idUser int,
	in passwordin varchar(30),
	out changedItem boolean
)


BEGIN
	declare oldPass varchar(30);
    
	SELECT senhaFunc into oldPass FROM funcionario where idFunc = idUser;
	
    if oldPass = passwordin then
    	set changedItem = 0;
    else
    	update funcionario set senhaFunc = passwordin where idFunc = idUser;
        set changedItem = 1;
    end if;

end $$
DELIMITER ;





DELIMITER $$

CREATE procedure gerarAumento(
	in cargoId int,
	in aumento int
)


BEGIN
	declare oldPass varchar(30);
    update cargo set salario = (select salario * (aumento/100) from cargo where idCargo = cargoId) where idCargo = cargoId;

end $$
DELIMITER ;

DELIMITER $$
CREATE TRIGGER before_change_pass   
    BEFORE UPDATE ON funcionario
    FOR EACH ROW 
    BEGIN
		if new.senhaFunc <> old.senhaFunc then
			insert into audit(oldPass, newPass, funcionario) values (old.senhaFunc, new.senhaFunc, old.idFunc);
        end if;
    END $$
DELIMITER ; 



DELIMITER $$
CREATE TRIGGER after_insert_func   
    after insert ON funcionario
    FOR EACH ROW 
    BEGIN
		if cargo is null then
			insert into funcMsg(msg, funcionario) values ("Inserir Cargo do funcionario");
        end if;
    END $$
DELIMITER ; 


DELIMITER $$
CREATE TRIGGER after_delete_cliente  
    after delete ON usuario
    FOR EACH ROW 
    BEGIN
		insert into wasCliente(cpf) values (cpf);
    END $$
DELIMITER ;