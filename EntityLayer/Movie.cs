using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
	public class Movie
	{
        [Key]
        public int MovieID { get; set; }
        [StringLength(50)]
        public string MovieName { get; set; }
        [StringLength(20)]
        public string Duration { get; set; }
        [StringLength(400)]
        public string ImageUrl { get; set; }
        [StringLength(400)]
        public string Trailer { get; set; }
        [StringLength(20)]
        public string Score { get; set; }
        [StringLength(1500)]
        public string LongDescription { get; set; }
        [StringLength (1000)]
        public string ShortDescription { get; set; }
		[StringLength(100)]
		public string ActressName { get; set; }
		[StringLength(100)]
		public string DirectorName { get; set; }
		[StringLength(50)]
		public string CategoryName { get; set; }
		public DateTime ReleaseDate { get; set; }

	}
}
