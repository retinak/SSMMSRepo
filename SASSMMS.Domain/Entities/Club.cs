using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSMMS.Domain.Entities
{
    /*
     * This model is equivalent of Nieus zerfs
     * used to implement zerfs
     */
    public class Club 
    {
        [Key]
        public Guid ClubId { get; set; }

        public string ClubName { get; set; }
        public string ClubType { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Purpose { get; set; }
        public Guid StatusId { get; set; }
        public  virtual  Status Status { get; set;  }
        
    }
}
