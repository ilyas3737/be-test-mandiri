using Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infra;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<Test2Context>
{
    public Test2Context CreateDbContext(string[] args){
        var optionBuilder = new DbContextOptionsBuilder<Test2Context>();
        optionBuilder.UseSqlServer("Server=(localdb)\\local;Database=Test2;Trusted_Connection=True;");
        return new Test2Context(optionBuilder.Options);
    }
}
