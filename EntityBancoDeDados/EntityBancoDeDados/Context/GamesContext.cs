using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using EntityBancoDeDados.Models;

namespace EntityBancoDeDados.Context
{
	public class GamesContext : DbContext
	{
		public DbSet<Games> Games { get; set; }
		public GamesContext():base ("GamesConnection")
		{

		}
	}
}