using leftover_backend.Models;

namespace leftover_backend.Services;

public static class RecipeService {
    static List<Recipe> Recipes { get; }
    static int nextId = 1;
    static RecipeService()
    {
        Recipes = new List<Recipe>
        {
        };
    }

    public static List<Recipe> GetAll() => Recipes;

    public static Recipe? Get(int id) => Recipes.FirstOrDefault(r => r.Id == id);

    public static void Add(Recipe recipe)
    {
        recipe.Id = nextId++;
        Recipes.Add(recipe);
    }

    public static void Delete(int id)
    {
        var recipe = Get(id);
        if(recipe is null)
            return;

        Recipes.Remove(recipe);
    }

    public static void Update(Recipe recipe)
    {
        var index = Recipes.FindIndex(r => r.Id == recipe.Id);
        if(index == -1)
            return;

        Recipes[index] = recipe;
    }
}