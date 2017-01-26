using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Project.Service.Models;

namespace Project.Service.DAL
{
    public class VehicleInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<VehicleContext>
    {
        protected override void Seed(VehicleContext context)
        {
            var vehiclesMade = new List<VehicleMake>
            {
                 new VehicleMake{Name="Volkswagen",Abrv="VW"},
                 new VehicleMake{Name="Bembara",Abrv="BMW"}
            };

            vehiclesMade.ForEach(s => context.VehicleMade.Add(s));
            context.SaveChanges();

            var vehiclesModels = new List<VehicleModel>
            {
                 new VehicleModel{MakeId="1000",Name ="Volkswagen",Abrv="VW"},
                 new VehicleModel{MakeId="1505",Name="Bembara",Abrv="BMW"}
            };

            vehiclesModels.ForEach(s => context.VehicleModels.Add(s));
            context.SaveChanges();

            //base.Seed(context);
        }

    }
}