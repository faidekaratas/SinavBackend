using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class TweetInfoDto
    {
        public int Id { get; set; } = default!;
        //public int UserId { get; set; }
        public string Text { get; set; } = default!;
        public DateOnly CreatedDate { get; set; } = default!;
    }
}
