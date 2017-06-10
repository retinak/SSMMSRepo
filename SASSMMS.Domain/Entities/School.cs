using System;
using System.ComponentModel;

namespace SASSMMS.Domain.Entities
{
    public class School
    {
        public Guid SchoolId { get; set; }
        [DisplayName("School")]
        public string SchoolName { get; set; }
        [DisplayName("Address")]
        public string SchoolAddress { get; set; }
    }
}
