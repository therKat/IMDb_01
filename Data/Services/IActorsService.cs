using IMDb.Data.Base;
using IMDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMDb.Data.Services
{
    public interface IActorsService:IEntityBaseRepository<Actor>
    {
    }
}
