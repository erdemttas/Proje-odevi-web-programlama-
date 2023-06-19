using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
	public class Context:DbContext
	{
        public DbSet<Movie> movies { get; set; }

    }
}
