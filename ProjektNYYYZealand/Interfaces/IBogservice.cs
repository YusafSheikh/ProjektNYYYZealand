using ProjektNYYYZealand.Models;
using System.Collections;
using System.Collections.Generic;

namespace ProjektNYYYZealand.Interfaces
{
    public interface IBogservice
    {
        public IEnumerable<Bog> GetBog(string Filter);

        public IEnumerable<Bog> GetBog();

        void AddBog(Bog bog);

        void DeleteBog(Bog bog);

        void DeleteBog(int id);

        void UpdateBog(Bog bog);    

        Bog GetBogById(int id);

        public IEnumerable<Bog> GetBog(string Title, string Forfatter, double ISBN);
    }
}
