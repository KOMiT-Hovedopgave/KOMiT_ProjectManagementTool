using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOMiT.DataAccess.Persistence
{
    public class DatabaseContext : DbContext
    {

            public DatabaseContext(DbContextOptions<DatabaseContext> options)
                : base(options)
            {
            }



    }
}
