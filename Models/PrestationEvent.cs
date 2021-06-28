using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace Geoffroy.Models
{
    public class PrestationEvent
    {
        public int Id { get; set; }
        public int PrestationId { get; set; }
        public Prestation Prestation { get; set; }
        public int EvenementId { get; set; }
        public Evenement Evenement { get; set; }
    }
}
