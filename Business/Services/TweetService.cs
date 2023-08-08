using Business.Models.Response;
using Business.Services.Base.Interface;
using Business.Services.Base;
using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Services.Interface;
using Infrastructure.Data.Postgres;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;
using Business.Utilities.Mapping.Interface;

namespace Business.Services
{
    public class TweetService : BaseService<Tweet, int, TweetInfoDto>, ITweetService
    {
        public TweetService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper) : base(unitOfWork, unitOfWork.TweetRepository, mapperHelper)
        {
        }
    }
}
