
select Location.Location, BuildYear.BuiltWhatYear, NameOfChurch.NameOfChurch
from CHURCH
join Location
on CHURCH.ChurchID = Location.ID
join BuildYear
on CHURCH.ChurchID = BuildYear.ID
join NameOfChurch
on CHURCH.ChurchID = NameOfChurch.ID










