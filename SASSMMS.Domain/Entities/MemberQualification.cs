using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSMMS.Domain.Entities
{
    public class MemberQualification
    {
        [Key]
        [Column(Order = 1)]
        public Guid MemberId { get; set; }
        [Key]
        [Column(Order = 2)]
        public Guid QualificationId { get; set; }
        public virtual Member Member { get; set; }
        public virtual Qualification Qualification { get; set; }
    }
}
