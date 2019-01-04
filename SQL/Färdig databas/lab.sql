use Chinook

--2)
--SELECT * FROM Artist

--3) 
--SELECT * FROM Artist
--ORDER BY Name

--4)
--SELECT * FROM Artist
--WHERE ArtistId BETWEEN 1 AND 10;

--5)
--SELECT *
--FROM Artist
--WHERE Name LIKE 'Academy%'

--6)
--SELECT * 
--FROM Album
--WHERE Title LIKE '_ar%'

--7)
--SELECT *
--FROM Album
--WHERE Title LIKE '[aouåeiyäö]%'

--8)
--SELECT Artist.Name, Album.Title
--FROM Artist
--FULL JOIN Album
--ON Album.AlbumId = Artist.ArtistId;

--9)
--inner join ? 
--left join = låter värdet till vänster vara kvar
--right join = låter värdet till höger vara kvar
--full join = låter båda värdena vara kvar 

----10)
--SELECT TOP 10 COUNT(*), name
--FROM Album
--JOIN Artist
--ON Album.ArtistId = Artist.ArtistId

--GROUP BY name
--ORDER BY COUNT(*) DESC;

----10) FUNKAR OSSÅ
--SELECT TOP 10 COUNT(*), Artist.name
--FROM Album
--JOIN Artist
--ON Album.ArtistId = Artist.ArtistId

--GROUP BY Artist.name
--ORDER BY COUNT(*) DESC;

----11)
--SELECT Album.Title
--FROM Album
--JOIN Track
--ON Track.AlbumId = Album.AlbumId
--WHERE Track.GenreId=2 OR Track.GenreId=6
--GROUP BY Album.Title


----13)
--select genre.Name, count(*)
--from Track
--join genre
--on genre.GenreId = track.GenreId
--group by genre.Name
--having count(*) > 100
--order by count(*) DESC


----14)
--DECLARE @MyCustomer int =
--(
--	select Customer.CustomerId
--	from Customer
--	where Customer.FirstName = 'Leonie' and Customer.LastName = 'Köhler'
--)

--	select CAST(Invoice.InvoiceDate as date)
--	from Invoice
--	where CustomerId=@MyCustomer


--select CAST(Invoice.InvoiceDate as date)
--from Invoice
--join Customer
--on Invoice.CustomerId = Customer.CustomerId
--Where Customer.FirstName='Leonie' and Customer.LastName='Köhler'



----15)
--drop table #CustomerWithSupport

--select Customer.FirstName as x, Customer.LastName as y, Employee.FirstName as z, Employee.LastName as t
--into #CustomerWithSupport
--from Customer
--join Employee
--on Customer.SupportRepId = Employee.EmployeeId

--select * 
--from #CustomerWithSupport



----16)
--select e1.firstname + ' ' + e1.LastName as EmployeeName, e2.FirstName + ' ' + e2.LastName as BossName
--from Employee e1
--join Employee e2
--on e1.ReportsTo = e2.EmployeeId


----17) 
--select MAX(LEN(email)) as LongestMail, MIN(LEN(email)) as ShortestMail
--from Customer


----18)
--select track.Name as Name, track.Milliseconds/60000.0 as Minutes 
--from Track 
--where track.Milliseconds/60000.0 > 45
--order by track.Milliseconds DESC


----19)
--select DISTINCT Customer.Country as DifferentCountries
--from Customer

--alter table Customers
--add UNIQUE (email);


----20)
--select DATEPART(YEAR, Invoice.InvoiceDate) as YEAR ,SUM(invoice.Total) as Sum
--from invoice
--group by DATEPART(YEAR, invoice.InvoiceDate)
--order by DATEPART(YEAR, invoice.InvoiceDate) desc



----21)
--select Playlist.Name, SUM(Track.Milliseconds/3600000.0) as TotalLengthInHours
--from Playlist
--join PlaylistTrack
--on Playlist.PlaylistId = PlaylistTrack.PlaylistId
--join Track
--on PlaylistTrack.TrackId = track.TrackId
--Group by Playlist.Name
--Order by SUM(Track.Milliseconds/3600000.0) DESC


----22)
--select e1.FirstName + ' ' + e1.LastName as EmployeeName, e3.FirstName + ' ' + e3.LastName as BossesBossName
--from Employee e1
--join Employee e2
--on e1.ReportsTo = e2.EmployeeId
--join Employee e3
--on e2.ReportsTo = e3.EmployeeId


--23)
--CREATE TABLE albumreview 
--(
--	AlbumID int,
--	AlbumReview varchar(50)
--);

--INSERT INTO albumreview (AlbumReview.AlbumID, AlbumReview.AlbumReview)
--VALUES ((select Album.AlbumId from album where title = 'Na Pista'), 'Albumet är grymt dåligt!, KÖP INTE')







