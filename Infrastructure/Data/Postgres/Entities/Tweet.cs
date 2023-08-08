using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Tweet:Entity<int>
    {
        //public int UserId { get; set; }
        public string Text { get; set; } = default!;
        public DateOnly CreatedDate { get; set; } = default!;


        //public User User { get; set; } = default!;
    }
}
