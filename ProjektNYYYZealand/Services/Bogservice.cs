using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjektNYYYZealand.Services
{
    public class Bogservice : IBogservice
    {
        ZealandProjektContext context;

        public Bog Bog { get; set; }
        public Bogservice(ZealandProjektContext services)
        {
            this.context = services;
        }

        public void AddBog(Bog bog)
        {
            context.Bøger.Add(bog);
            context.SaveChanges();
        }

        public void DeleteBog(Bog bog)
        {
            context.Bøger.Remove(bog);
            context.SaveChanges();
        }

        public void DeleteBog(int id)
        {
            Bog bog =GetBogById(id);
            context.Bøger.Remove(bog);
            context.SaveChanges(true);
        }

        public IEnumerable<Bog> GetBog(string Filter)
        {
            if(Filter != null)
            {
                return context.Bøger;
            }

           return context.Set<Bog>().Where(s=>s.Title.StartsWith(Filter));
            
            
        }

        public IEnumerable<Bog> GetBog()
        {
           return context.Bøger;
        }

        public Bog GetBogById(int id)
        {
            return context.Bøger.Find(id);
        }

        public void UpdateBog(Bog bog)
        {
            context.Bøger.Update(bog);
            context.SaveChanges();
        }

        public IEnumerable<Bog> GetBog(string Title, string Forfatter, double ISBN)
        {
            IEnumerable<Bog> result = context.Bøger;
            if(Title != null)
            {
                result = result.Where(t => t.Title.StartsWith(Title));
            }

            if(Forfatter != null)
            {
                result= result.Where(f=> f.Forfatter.StartsWith(Forfatter));
            }
            if(ISBN >= 0)
            {
                return context.Set<Bog>().Where(i => i.Isbn == ISBN);
            }
            return result;
        }
    }
}
