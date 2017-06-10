using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SASSMMS.Domain.Entities;

namespace SASSMMS.ApplicationService.Services.Interfaces
{
    public interface IMemberAttendanceService
    {
        bool InsertAttendance(Attendance attendance);
        bool UpdateAttendance(Attendance attendance);
        bool DeleteAttendance(Attendance attendance);
        List<Attendance> GetAttendances();
        Attendance GetAttendance(Guid? id);
        IEnumerable<Attendance> Get(
         Expression<Func<Attendance, bool>> filter = null,
         Func<IQueryable<Attendance>, IOrderedQueryable<Attendance>> orderBy = null,
         string includeProperties = "");
        List<Attendance> FindBy(Expression<Func<Attendance, bool>> predicate);
    }
}
