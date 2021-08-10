using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntityBancoDeDados.Context;
using EntityBancoDeDados.Models;

namespace EntityBancoDeDados.Repository
{
	public class GamesRepository
	{
		public void Create(Games model)
		{
			using (var context = new GamesContext())
			{
				context.Games.Add(model);
				context.SaveChanges();
			}
		}
		public List<Games> Read()
		{
			List<Games> list = new List<Games>();
			using (var context = new GamesContext())
			{
				list = context.Games.ToList();
			}
			return list;
		}
		public Games Read(int id) 
		{
			Games model = new Games();
			using (var context = new GamesContext()) 
			{
				model = context.Games.Find(id);
			}
			return model;
		}
		public void Update(Games model) 
		{
			using (var context = new GamesContext()) 
			{
				context.Entry<Games>(model).State = System.Data.Entity.EntityState.Modified;
				context.SaveChanges();
			}
		}
		public void Delete(int id) 
		{
			using (var context = new GamesContext()) 
			{
				context.Entry<Games>(this.Read(id)).State = System.Data.Entity.EntityState.Deleted;
				context.SaveChanges();
			}
		}
	}
}