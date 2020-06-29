select a.*
from actor a
	inner join
(select top(5) a.actor_id, count(*) as total
from actor a
	inner join [dbo].film_actor fa on fa.actor_id = a.actor_id
group by a.actor_id
order by total desc) filmes on filmes.actor_id = a.actor_id;

select distinct top(5) a.first_name, a.last_name, count(*) as total
	from [dbo].actor as a
		inner join [dbo].film_actor as fa on fa.actor_id = a.actor_id
group by a.first_name, a.last_name
order by total desc;

select distinct top(5) f.title, f.length as duracao from [dbo].film as f
	inner join [dbo].film_actor as fa on fa.film_id = f.film_id
group by duracao;