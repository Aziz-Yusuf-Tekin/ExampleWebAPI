using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Home:BaseModel
    {
        [StringLength(50)]
        public String StreetName { get; set; }

        [StringLength(50)]
        public string ApartmentName { get; set; }

    }
}
