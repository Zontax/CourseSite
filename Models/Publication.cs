using System.ComponentModel.DataAnnotations;

namespace CourseSite.Models;

public class Publication
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Назва обов'язкова")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Текст обов'язковий")]
    public string Text { get; set; }

    [Required(ErrorMessage = "Автор обов'язковий")]
    public string Author { get; set; }

    [Display(Name = "Дата та час")]
    public DateTime DateTime { get; set; }


    public Publication(string title, string text, string author)
    {
        Title = title;
        Text = text;
        Author = author;
        DateTime = DateTime.Now;
    }

    public Publication(string title, string text, string author, DateTime dateTime)
    {
        Title = title;
        Text = text;
        Author = author;
        DateTime = dateTime;
    }
}