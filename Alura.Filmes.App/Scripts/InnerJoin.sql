select * from [dbo].film_actor AS filmografia
	inner join [dbo].film fa on fa.film_id = filmografia.film_id
	inner join( 
		SELECT TOP(1) [a].actor_id
		FROM [dbo].actor as [a]) AS [a] ON [a].actor_id = filmografia.actor_id;


select * from [dbo].film_actor as fa 
	inner join [dbo].film f on f.film_id = fa.film_id
	inner join( 
	SELECT [a].[actor_id], [a].first_name, [a].last_name FROM [dbo].actor AS [a]
	WHERE [a].actor_id = 2) AS [actor] on [actor].actor_id = fa.actor_id;

select [f].actor_id from [dbo].film [f]
	inner join [dbo].film_actor [fa] on [fa].film_id = [f].film_id;
