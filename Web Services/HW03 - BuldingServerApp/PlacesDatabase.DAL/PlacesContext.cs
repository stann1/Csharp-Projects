using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlacesDatabase.Models;

namespace PlacesDatabase.DAL
{
    public class PlacesContext : DbContext
    {
  //<connectionStrings>
  //  <add name="PlacesDB" connectionString="Data Source=.;Initial Catalog=UniversitySystemDB;Integrated Security=True" providerName="System.Data.SqlClient" />
  //</connectionStrings>
        public DbSet<Place> MyProperty { get; set; }

        public PlacesContext() : base("PlacesDB")
        {
        }

    }
}
