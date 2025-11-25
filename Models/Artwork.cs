public class Artwork
{
    public required string Title { get; set; }
    public required string Price { get; set; }
    public required string ImageUrl { get; set; }
    public double ImageHeight { get; set; } // double defaults to 0, so it doesn't need 'required'
}