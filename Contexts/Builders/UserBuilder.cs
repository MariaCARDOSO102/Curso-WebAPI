using Microsoft.EntityFrameworkCore;
using ReserveiAPI.Objects.Models.Entities;

namespace ReserveiAPI.Contexts.Builders
{
    public class UserBuilder
    {
        public static void Build(ModelBuilder modelBuilder)
        {
            // Builder
            modelBuilder.Entity<UserModel>().HasKey(u => u.Id);
            modelBuilder.Entity<UserModel>().Property(u => u.ImageProfile);
            modelBuilder.Entity<UserModel>().Property(u => u.NameUser).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<UserModel>().Property(u => u.EmailUser).HasMaxLength(200).IsRequired();
            modelBuilder.Entity<UserModel>().Property(u => u.PasswordUser).HasMaxLength(256).IsRequired();
            modelBuilder.Entity<UserModel>().Property(u => u.PhoneUser).HasMaxLength(15).IsRequired();

            // Inserções 
            modelBuilder.Entity<UserModel>().HasData(
                new UserModel
                {
                    Id = 1,
                    NameUser = "master@development.com",
                    PasswordUser = "2634c3097f98e36865f0c572009c4ffd73316bc8b88ccfe8d196af35f46e2394",
                    PhoneUser = "",
                    ImageProfile = ""
                }
            );
        }
            
    }
}
