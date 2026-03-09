-- This is a SQL script for SQL-Server for using the Text2ArchiMate function in IDEA
-- Run this script in the database where EA is running
-- Tabellen verwijderen
DROP TABLE IDEA_TAG;

DROP TABLE IDEA_TAGOBJECT;

DROP TABLE IDEA_STOPWORD;
GO


CREATE TABLE IDEA_TAG 
( tag_id INT Identity(1,1) PRIMARY KEY NOT NULL
, tagname NVARCHAR(100) NULL);
GO

CREATE TABLE IDEA_TAGOBJECT 
( tag_id INT NOT NULL
, fieldname NVARCHAR(50) NULL
, ea_guid NVARCHAR(40) NOT NULL);
GO

CREATE TABLE IDEA_STOPWORD 
( stopword_id INT Identity(1,1) PRIMARY KEY NOT NULL
, stopword NVARCHAR(100) NOT NULL
, language CHAR(2) NOT NULL);
GO

CREATE OR ALTER FUNCTION [dbo].[IDEA_KeepWords](@Temp VarChar(4000))
Returns VarChar(4000)
AS
BEGIN

    Declare @KeepValues as varchar(50)
    Set @KeepValues = '%[^a-z ]%'
    While PatIndex(@KeepValues, @Temp) > 0
        Set @Temp = Stuff(@Temp, PatIndex(@KeepValues, @Temp), 1, '')
	return @Temp
END;
GO

CREATE OR ALTER PROCEDURE dbo.IDEA_Architecture2Keywords AS

BEGIN

DECLARE @nametags NVARCHAR(4000); 
DECLARE @aliastags NVARCHAR(4000); 
DECLARE @guid VARCHAR(50);
DECLARE tags_cursor CURSOR FOR  
SELECT lower(dbo.IDEA_KeepWords(t_object.name))
, lower(dbo.IDEA_KeepWords(t_object.alias))
, t_object.ea_guid 
FROM t_object
WHERE Stereotype LIKE 'ArchiMate%';

DELETE FROM IDEA_TAG;
DELETE FROM IDEA_TAGOBJECT;

OPEN tags_cursor;  
FETCH NEXT FROM tags_cursor  
INTO @nametags, @aliastags, @guid;  
WHILE @@FETCH_STATUS = 0  
BEGIN
   INSERT INTO IDEA_TAG (tagname) 
   SELECT value 
   FROM STRING_SPLIT(@nametags, ' ')
   WHERE value NOT IN(SELECT tagname FROM IDEA_TAG);

   INSERT INTO IDEA_TAG (tagname) 
   SELECT value 
   FROM STRING_SPLIT(@aliastags, ' ')
   WHERE value NOT IN(SELECT tagname FROM IDEA_TAG);

   INSERT INTO IDEA_TAGOBJECT (tag_id, ea_guid, fieldname) 
   SELECT tag_id, @guid, 'Name'  
   FROM STRING_SPLIT(@nametags, ' '), IDEA_TAG
   WHERE tagname =value;

   INSERT INTO IDEA_TAGOBJECT (tag_id, ea_guid, fieldname) 
   SELECT tag_id, @guid, 'Alias'  
   FROM STRING_SPLIT(@aliastags, ' '), IDEA_TAG
   WHERE tagname =value;
  
   FETCH NEXT FROM tags_cursor  
   INTO @nametags, @aliastags, @guid;  
END  
  
CLOSE tags_cursor;  
DEALLOCATE tags_cursor;  

END;
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE OR ALTER           FUNCTION [dbo].[IDEA_Text2Table]
(	
	@fultext nvarchar(4000) 
,	@includevalue bit
)
RETURNS TABLE 
AS
RETURN 
(
SELECT IIF(@includevalue=0, '--', value) as keyword, t_object.stereotype, t_object.name, count(t_diagramobjects.Instance_ID) as hitcount, t_object.Object_ID
FROM  STRING_SPLIT(lower(@fultext), ' ')
INNER JOIN IDEA_TAG ON value = IDEA_TAG.tagname
INNER JOIN IDEA_TAGOBJECT ON IDEA_TAG.tag_id = IDEA_TAGOBJECT.tag_id
INNER JOIN t_object ON IDEA_TAGOBJECT.ea_guid = t_object.ea_guid
INNER JOIN t_diagramobjects ON t_diagramobjects.Object_ID = t_object.Object_ID
WHERE value NOT IN(SELECT IDEA_STOPWORD.stopword  FROM IDEA_STOPWORD)
GROUP BY IIF(@includevalue=0, '--', value), t_object.stereotype, t_object.name, t_object.Object_ID

)
GO






--lijst van standaard stopwoorden
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'aan') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'aangaande') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'aangezien') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'achter') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'achterna') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'afgelopen') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'al') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'aldaar') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'aldus') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'alhoewel') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'alias') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'alle') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'allebei') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'alleen') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'alsnog') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'altijd') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'altoos') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'ander') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'andere') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'anders') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'anderszins') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'behalve') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'behoudens') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'beide') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'beiden') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'ben') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'beneden') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'bent') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'bepaald') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'betreffende') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'bij') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'binnen') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'binnenin') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'boven') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'bovenal') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'bovendien') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'bovengenoemd') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'bovenstaand') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'bovenvermeld') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'buiten') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'daar') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'daarheen') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'daarin') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'daarna') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'daarnet') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'daarom') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'daarop') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'daarvanlangs') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'dan') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'dat') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'de') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'die') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'dikwijls') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'dit') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'door') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'doorgaand') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'dus') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'echter') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'eer') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'eerdat') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'eerder') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'eerlang') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'eerst') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'elk') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'elke') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'en') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'enig') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'enigszins') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'enkel') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'er') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'erdoor') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'even') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'eveneens') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'evenwel') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'gauw') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'gedurende') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'geen') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'gehad') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'gekund') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'geleden') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'gelijk') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'gemoeten') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'gemogen') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'geweest') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'gewoon') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'gewoonweg') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'haar') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'had') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'hadden') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'hare') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'heb') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'hebben') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'hebt') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'heeft') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'hem') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'hen') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'het') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'hierbeneden') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'hierboven') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'hij') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'hoe') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'hoewel') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'hun') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'hunne') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'ik') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'ikzelf') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'in') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'inmiddels') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'inzake') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'is') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'jezelf') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'jij') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'jijzelf') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'jou') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'jouw') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'jouwe') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'juist') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'jullie') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'kan') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'klaar') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'kon') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'konden') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'krachtens') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'kunnen') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'kunt') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'later') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'liever') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'maar') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'mag') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'meer') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'met') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'mezelf') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'mij') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'mijn') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'mijnent') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'mijner') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'mijzelf') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'misschien') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'mocht') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'mochten') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'moest') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'moesten') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'moet') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'moeten') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'mogen') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'na') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'naar') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'nadat') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'net') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'niet') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'noch') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'nog') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'nogal') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'nu') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'of') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'ofschoon') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'om') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'omdat') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'omhoog') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'omlaag') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'omstreeks') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'omtrent') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'omver') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'onder') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'ondertussen') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'ongeveer') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'ons') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'onszelf') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'onze') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'ook') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'op') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'opnieuw') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'opzij') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'over') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'overeind') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'overigens') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'pas') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'precies') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'reeds') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'rond') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'rondom') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'sedert') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'sinds') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'sindsdien') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'slechts') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'sommige') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'spoedig') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'steeds') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'tamelijk') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'tenzij') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'terwijl') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'thans') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'tijdens') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'toch') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'toen') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'toenmaals') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'toenmalig') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'tot') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'totdat') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'tussen') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'uit') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'uitgezonderd') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'vaak') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'van') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'vandaan') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'vanuit') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'vanwege') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'veeleer') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'verder') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'vervolgens') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'vol') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'volgens') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'voor') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'vooraf') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'vooral') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'vooralsnog') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'voorbij') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'voordat') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'voordezen') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'voordien') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'voorheen') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'voorop') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'vooruit') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'vrij') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'vroeg') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'WAAR') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'waarom') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'wanneer') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'want') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'waren') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'was') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'wat') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'weer') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'weg') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'wegens') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'wel') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'weldra') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'welk') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'welke') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'wie') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'wiens') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'wier') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'wij') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'wijzelf') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'zal') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'ze') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'zelfs') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'zichzelf') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'zij') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'zijn') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'zijne') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'zo') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'zodra') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'zonder') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'zou') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'zouden') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'zowat') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'zulke') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'zullen') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'zult') 
INSERT INTO IDEA_STOPWORD (language, stopword) VALUES ('NL', 'een') 
GO


DECLARE	@return_value int

EXEC	@return_value = [dbo].[IDEA_Architecture2Keywords]

SELECT	'Return Value' = @return_value

GO

--voorbeeld select statement
SELECT * FROM [dbo].[IDEA_Text2Table] (
   'In de database worden alleen SELECT rechten op RPUN relevante tabellen en het CDW schema toegekend aan het RPUN ontwikkelteam. Het toekennen van autorisaties wordt door beheer gedaan.
Er wordt geen aparte programmatuur voor het laden van ACE RPUN gemaakt.
De tabellen in het CDW schema worden als scripts door het ontwikkelteam aan beheer geleverd, beheer maakt de tabellen aan.
Er wordt een nieuwe Azure Blob Storage aangemaakt in het productiedomein waar de CDW data op gezet wordt. Dit wordt handmatig door het ontwikkelteam gedaan. Hiervoor krijgt het ontwikkelteam schrijfrechten op de Azure Blob Storage.
Het RPUN ontwikkelteam maakt een eenmalige Informatica flow om de CDW data vanaf Azure Blob Storage naar de database te schrijven. Deze flow kan door het ontwikkelteam gestart worden in Informatica Administrator. Hiervoor krijgt het ontwikkelteam rechten om de specifieke app in Informatica Administrator te starten.
De ACE RPUN data wordt via de reguliere processen geladen. Hiervoor krijgt het RPUN-team tijdelijk rechten om de apps in Informatica Administrator te starten.
Door bovenstaande maatregelen hoeft beheer, na eenmalig aanmaken van technische componenten en toekennen van rechten, in principe geen acties meer te ondernemen.
', 1)
ORDER BY name
GO

--Voorbeeld Pivot table op stereotype
SELECT * FROM (SELECT value as keyword, 
t_object.name,
t_object.stereotype,
count(t_object.object_id) as hitcount
FROM  STRING_SPLIT(lower('In de database worden alleen SELECT rechten op RPUN relevante tabellen en het CDW schema toegekend aan het RPUN ontwikkelteam. Het toekennen van autorisaties wordt door beheer gedaan.
Er wordt geen aparte programmatuur voor het laden van ACE RPUN gemaakt.
De tabellen CDW schema worden als scripts door het ontwikkelteam aan beheer geleverd, beheer maakt de tabellen aan.
Er wordt een Azure Blob Storage aangemaakt in het productiedomein waar de CDW data op gezet wordt. Dit wordt handmatig door het ontwikkelteam gedaan. Hiervoor krijgt het ontwikkelteam schrijfrechten op de Azure Blob Storage.
Het RPUN ontwikkelteam maakt een eenmalige Informatica flow om de CDW data vanaf Azure Blob Storage naar de database te schrijven. Deze flow kan door het ontwikkelteam gestart worden in Informatica Administrator. Hiervoor krijgt het ontwikkelteam rechten om de specifieke app in Informatica Administrator te starten.
De ACE RPUN data wordt via de reguliere processen geladen. Hiervoor krijgt het RPUN-team tijdelijk rechten om de apps in Informatica Administrator te starten.
Door bovenstaande maatregelen hoeft beheer, na eenmalig aanmaken van technische componenten en toekennen van rechten, in principe geen acties meer te ondernemen.
'), ' ')
INNER JOIN IDEA_TAG ON value = IDEA_TAG.tagname
INNER JOIN IDEA_TAGOBJECT ON IDEA_TAG.tag_id = IDEA_TAGOBJECT.tag_id
INNER JOIN t_object ON IDEA_TAGOBJECT.ea_guid = t_object.ea_guid
WHERE value NOT IN(SELECT IDEA_STOPWORD.stopword  FROM IDEA_STOPWORD)
GROUP BY value, t_object.name, t_object.stereotype
HAVING count(t_object.object_id) IS NOT NULL) As Keywordresult
PIVOT (
  SUM(hitcount)
  FOR stereotype
    IN(ArchiMate_BusinessRole, 
	ArchiMate_BusinessService, 
	ArchiMate_BusinessProcess, 
	ArchiMate_BusinessObject,
	ArchiMate_ApplicationComponent, 
	ArchiMate_ApplicationService, 
	ArchiMate_ApplicationFunction, 
	ArchiMate_DataObject)
  ) as PivotTable

  
  












