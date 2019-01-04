
--select person.Person, PersonLivesWhere.Location
--from person
--join PersonLivesWhere
--on PersonLivesWhere.ID = Person.PersonID





select	PersonName.Name, NameOfChurch.NameOfChurch, BuildYear.BuiltWhatYear, PreferedChurch.PreferedChurch
from CHURCH

join BuildYear
on CHURCH.ChurchID = BuildYear.ID

join NameOfChurch
on CHURCH.ChurchID = NameOfChurch.ID

Join PreferedChurch
on PreferedChurch.ID = CHURCH.ChurchID

Join Person
on Person.PersonID = PreferedChurch.ID

join PersonName
on Person.PersonID = personname.ID














