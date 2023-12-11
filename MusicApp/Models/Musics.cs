namespace MusicApp.Models;

public class Musics{
    public int Id { get; set; }
    public string Title { get; set; }
    public Albums Albums { get; set; }
    public Artists Artist { get; set; }
    public string Genre { get; set; }
    public DateTime PublishDate { get; set; }
    public decimal View { get; set; }

    public Musics(){}

    public Musics(int id, string title, Albums albums, Artists artist, string genre, DateTime publishDate, decimal view)
    {
        Id = id;
        Title = title;
        Albums = albums;
        Artist = artist;
        Genre = genre;
        PublishDate = publishDate;
        View = view;
    }
}