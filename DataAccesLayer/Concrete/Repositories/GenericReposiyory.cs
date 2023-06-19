using DataAccesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete.Repositories
{
	public class GenericReposiyory<T> : IRepository<T> where T : class
	{
		Context c=new Context();
		DbSet<T> _object;

		public GenericReposiyory()
		{
			_object = c.Set<T>();
		}



		public void Delete(T p)
		{
			_object.Remove(p);
			c.SaveChanges();
		}

		public T Get(Expression<Func<T, bool>> filter)
		{
			return _object.SingleOrDefault(filter); //sadece bir değer döndürmek için kullanılır
		}

		public void Insert(T p)
		{
			_object.Add(p);
			c.SaveChanges();
		}

		public List<T> List()
		{
			return _object.ToList();
		}

		public List<T> List(Expression<Func<T, bool>> filter)
		{
			return _object.Where(filter).ToList();
		}

		public void Update(T p)
		{
			c.SaveChanges();
		}
	}
}
