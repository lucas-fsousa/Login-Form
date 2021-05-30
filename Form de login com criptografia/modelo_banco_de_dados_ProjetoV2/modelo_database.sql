 
create table cadastro( -- Comando para criar a tabela
id int identity not null primary key (id), -- Define a coluna ID sendo esta do tipo inteiro definida como chave primaria not null
login varchar (20) NOT NULL unique, -- Define a coluna de login como varchar de 20 caracteres com valor exclusivo, não aceita valor nulo
senha varchar(60) NOT NULL, -- define a coluna de senha como varchar de 60 caracteres não aceita valor nulo
data_creat_senha datetime NOT NULL, -- define a coluna de data da criação de senha no formato de data, não aceita valor nulo
email varchar(60) NOT NULL, -- Define a coluna de e-mail do como varchar de 60 caracteres, não aceita valor nulo
auto_pass varchar(5) NOT NULL -- Definje a coluna auto_pass como varchar de 5 caracteres, não aceita valor nulo
);
