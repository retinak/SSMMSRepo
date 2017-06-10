using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSMMS.Domain.Entities
{
    public class TemporaryMember 
    {
        
        public  Guid TemporaryMemberId { get; set; }
        public Guid MemberId { get; set; }
        public virtual Member Member { get; set; }
        public  DateTime RegisteredDate { get; set; }// number of Month

    }
}
