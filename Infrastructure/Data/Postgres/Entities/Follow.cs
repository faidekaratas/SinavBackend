using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Follow:Entity<int>
    {
        public int FollowerUserId { get; set; } //takip eden kullanıcı id
        public int FolloweeUserId { get; set; } //takip edilen kullanıcı id
        public DateOnly FollowDate { get; set; } = default!;

       // public User FollowerUser { get; set; } // Takip eden kullanıcı
        //public User FolloweeUser { get; set; } // Takip edilen kullanıcı
    }
}
