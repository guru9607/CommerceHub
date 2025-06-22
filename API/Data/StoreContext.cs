using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

// ✅ Definition:
// StoreContext is a custom class that inherits from DbContext.
// It tells EF Core how to talk to the database and what tables (entities) it should manage.

public class StoreContext(DbContextOptions options) : DbContext(options)
{
    // ✅ Products = Represents a table for Product entity.
    // Lets us run LINQ queries and perform CRUD operations.
    public DbSet<Product> Products { get; set; }
}


