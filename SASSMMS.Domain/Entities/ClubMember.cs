using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSMMS.Domain.Entities
{
    public class ClubMember
    {
        [Key]
        [Column(Order = 1)]
        public Guid ClubId { get; set; }
        [Key]
        [Column(Order = 2)]
        public Guid MemberId { get; set; }

        public DateTime MembershipDate { get; set; }

    }
}
