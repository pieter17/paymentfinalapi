using System;
using Microsoft.EntityFrameworkCore;
using final_project.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace final_project.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public virtual DbSet<PaymentDetailItem> PaymentDetail { get; set; }
        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }
    }
}