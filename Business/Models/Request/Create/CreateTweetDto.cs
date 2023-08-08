using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class CreateTweetDto
    {
        //public int UserId { get; }
        public string Text { get; set; } = default!;
        public DateOnly CreatedDate { get; set; } = default!;
    }
}
