using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Partner.Model
{
    public class Partner
    {
        public int PartnerTypeId { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int PartnerNumber { get; set; }
        public int CroatianPIN { get; set; }
        public DateTime CreatedAtUtc { get; set; }
        public string CreateByUser { get; set; }
        public bool IsForeign { get; set; }
        public string ExternalCode { get; set; }
        public string Gender { get; set; }
    }
}