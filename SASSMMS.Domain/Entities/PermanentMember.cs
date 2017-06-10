using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSMMS.Domain.Entities
{
    public class PermanetMember 
    {
        
        public Guid PermanetMemberId { get; set; }
        public Guid MemberId { get; set; }
        public virtual Member Member { get; set; }
        public DateTime PermanetStatusDate { get; set; } //Number of Month

    }
}
