using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class User : Entity<int>
{
    public string Email { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string SurName { get; set; } = default!;
    public string PhoneNumber { get; set; }
    public byte[] PasswordSalt { get; set; } = default!;
    public byte[] PasswordHash { get; set; } = default!;
    public UserType UserType { get; set; }

    //public ICollection<Tweet> Tweet { get; set; }

    //public ICollection<Tweet> Tweets { get; set; } // Kullanıcının kendi tweet'leri
    //public ICollection<Follow> Followers { get; set; } // Kullanıcının takipçileri
    //public ICollection<Follow> Followings { get; set; } // Kullanıcının takip ettikleri
}

public enum UserType
{
    Admin,
    User,
}