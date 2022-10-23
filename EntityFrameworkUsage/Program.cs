using EntityFrameworkUsage.EntityFramework;
using Microsoft.EntityFrameworkCore.ChangeTracking;

internal class Program
{
    private static void Main(string[] args)
    {
        using GoodsContext context = new GoodsContext();

        EntityEntry<Goods> addResult = context.Add(new Goods()
        {
            Id = new Guid(),
            Name = "firstName"
        });

        var result = context.SaveChanges();
    }
}