using System;

namespace SASSMMS.Domain.Entities
{
    /*
     * Attendance model
     */
    public class Attendance
    {
        public  Guid AttendanceId { get; set; }
        public  Guid MemberId { get; set; }
        public virtual Member Member { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
