namespace leftover_backend.Models;

public class Recipe
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Image { get; set; }
    public int Time { get; set; }
    public List<string>? MatchedIngredients { get; set; }
    public List<string>? RemainingIngredients { get; set; }
    public string? Link { get; set; }
}