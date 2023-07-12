using Domain.Contracts.Repositories;
using Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
	public class ScheduleRepository : AbstractRepository<Schedule>, IScheduleRepository
	{
		public ScheduleRepository(DatabaseContext dbContext) : base(dbContext)
		{
		}
	}
}
