using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Service.Models
{
    public class VehicleModel
    {
        public Guid Id { get; set; }
        public string MakeId { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }


        public virtual ICollection<VehicleMake> VehicleModels { get; set; }
    }
}