--SELECT * FROM Payment JOIN Visit ON Payment.VisitId=Visit.Id JOIN Pet ON Pet.Id=Visit.PetId JOIN Vet ON Vet.Id=Visit.VetId

--SELECT Pet.Name, Visit.Reason, Payment.Price, Vet.Name as VetName, Vet.Surname as VetSurname FROM
--	Payment JOIN Visit ON Payment.VisitId=Visit.Id JOIN Pet ON Pet.Id=Visit.PetId JOIN Vet ON Vet.Id=Visit.VetId

SELECT Pet.Name, Visit.Reason, Payment.Price, CONCAT(Vet.Name, ' ', Vet.Surname) as Vet FROM
	Payment JOIN Visit ON Payment.VisitId=Visit.Id JOIN Pet ON Pet.Id=Visit.PetId JOIN Vet ON Vet.Id=Visit.VetId