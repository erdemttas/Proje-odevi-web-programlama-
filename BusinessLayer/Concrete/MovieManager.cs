using BusinessLayer.Abstract;
using DataAccesLayer.Concrete.Repositories;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class MovieManager:IMovieService
	{
		GenericReposiyory<Movie> repo=new GenericReposiyory<Movie>();
		
		public List<Movie> getAllBL()
		{
			return repo.List();
		}

		public Movie getById(int id)
		{
			return repo.Get(x => x.MovieID == id);
		}

		public void MovieAddBL(Movie p)
		{
			repo.Insert(p);
		}

	}
}
