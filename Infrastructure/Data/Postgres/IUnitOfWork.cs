﻿using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Infrastructure.Data.Postgres;

public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    IUserTokenRepository UserTokens { get; }
    ITweetRepository TweetRepository { get; }
    IFollowRepository FollowRepository { get; }

    Task<int> CommitAsync();
}