using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PackingListApp.Models
{
    
    public class User
    {
        public enum _AdminType { Normal, VIP, King }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public bool IsAdmin { get; set; }
        public _AdminType AdminType { get; set; }

        //public int OccupationId { get; set; } // Foreign key
        //public TestModel Occupation { get; set; } // Reference navigation

    }
}
