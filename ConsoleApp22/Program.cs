
create database task;
use task;

create table Actor(
Actor_id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
first_name varchar(50) NOT NULL,
last_name varchar(50) NOT NULL,
nationality varchar(50) NOT NULL,
birth DATE NOT NULL
);
create table Director(
Director_id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
first_name varchar(50) NOT NULL,
last_name varchar(50) NOT NULL,
nationality varchar(50) NOT NULL,
birth DATE NOT NULL
);
create table Genres(
Genre_id INT NOT NULL PRIMARY KEY,
Genre_name varchar(50)
);
create table Movies(
Movie_id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
Director_id INT,
Actor_id INT,
Genre_id INT,
Title VARCHAR(50) NOT NULL,
ReleaseYear DATE NOT NULL,
Rating INT NOT NULL,
Plot VARCHAR(50) NOT NULL,
MovieLength INT NOT NULL,
foreign key (Director_id) references Director(Director_id)
);
create table MovieActor(
Movie_id INT,
Actor_id INT,
foreign key (Actor_id ) references Actor(Actor_id ),
foreign key(Movie_id ) references Movies(Movie_id )
);
create table MovieGenres(
Movie_id INT,
Genre_id INT,
foreign key (Movie_id ) references Movies(Movie_id ),
foreign key(Genre_id) references Genres(Genre_id)
);