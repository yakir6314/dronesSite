using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Data.Entity;
using System;
using System.Web;
namespace drones.Models
{
    public class dronesCatalog
    {
        public int DroneId {get;set;}
        public string DroneName {get;set;}
        public string DroneCreator{get;set;}
        public double DronePrice{get;set;}
        public int Quantity{get;set;}
        public DateTime UpdateDate{get;set;}
        
    }

}