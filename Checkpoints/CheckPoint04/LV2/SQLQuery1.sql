
--select PersonName.Name, PersonLivesWhere.Location
--from Person
--join PersonName
--on person.PersonID = Personname.ID
--join PersonLivesWhere
--on person.PersonID = PersonLivesWhere.ID



select Person.person, CHURCH.NameOfChurch, CHURCH.BuildYear
from CHURCH
join PreferedChurch
on CHURCH.ChurchID = PreferedChurch.PreferedChurchID
join Person
on PreferedChurch.PersonID = Person.PersonID









