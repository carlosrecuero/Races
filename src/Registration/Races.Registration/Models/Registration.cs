using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races.Registrations.Models
{
    public class Registration
    {
        public int Id { get; set; }
        public int RaceId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompetitorNumber => $"C{Id}";
    }
}
