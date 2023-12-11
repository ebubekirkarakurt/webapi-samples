namespace MusicApp.Models;

public class Albums{
    public int Id { get; set; }
    public string Title { get; set; }

    public Albums(){}

    public Albums(int id, string title)
    {
        Id = id;
        Title = title;
    }
}