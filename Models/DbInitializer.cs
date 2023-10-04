namespace CourseSite.Models;

public class DbInitializer
{
    public static void Initialize(ApplicationDbContext context)
    {
        context.Database.EnsureCreated();
        //context.Publications.ExecuteDelete(); // Очистити БД

        // Перевірте, чи вже є данні в БД
        if (context.Publications.Any())
        {
            return; // База даних ініційована
        }

        // Додайте початкові данні в БД
        var publications = new Publication[]
        {
            new("Заголовок 1", "Текст 1", "Автор 1"),
            new("Заголовок 2", "Текст 2", "Автор 2"),
            new("Заголовок 3", "Abcd Текст 3", "Автор 3", DateTime.MinValue),
        };

        foreach (var publication in publications)
        {
            context.Publications.Add(publication);
        }

        context.SaveChanges();
    }
}

