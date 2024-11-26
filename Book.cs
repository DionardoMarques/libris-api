namespace LibrisApi;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public enum Genders
    {
        Ficção,
        Romance,
        Mistério
    }
    public Genders Gender { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
}
