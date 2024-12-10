using Microsoft.EntityFrameworkCore;
using homework10_12.Data;

namespace homework10_12;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using TodoContext context = new TodoContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<TodoContext>>());
        if (context == null || context.Todo == null)
        {
            throw new ArgumentNullException("Null context");
        }

        if (context.Todo.Any())
        {
            return;
        }

        context.Todo.AddRange(
            new Models.Todo
            {
                Description = "Wash the clothes"
            },

            new Models.Todo
            {
                Description = "Do the dishes"
            }
        );
        context.SaveChanges();
    }
}