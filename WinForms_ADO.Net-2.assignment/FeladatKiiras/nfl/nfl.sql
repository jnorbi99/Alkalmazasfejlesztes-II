CREATE TABLE Game (
 ID integer not null PRIMARY key AUTOINCREMENT,
 HomeClubName text not null,
 AwayClubName text not null,
 HomeFinalScore integer not null,
 AwayFinalScore integer not null,
 HomeNumberOfTD integer not null,
 AwayNumberOfTD integer not null,
 Week integer not null,
 Year integer not null
);
