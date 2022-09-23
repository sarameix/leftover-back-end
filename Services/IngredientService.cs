using leftover_backend.Models;

namespace leftover_backend.Services;

public static class IngredientService {
    static List<Ingredient> Ingredients { get; }
    static int nextId = 1;
    static IngredientService()
    {
        Ingredients = new List<Ingredient>
        {
        };
    }

    public static List<Ingredient> GetAll() => Ingredients;

    public static Ingredient? Get(int id) => Ingredients.FirstOrDefault(i => i.Id == id);

    public static void Add(Ingredient ingredient)
    {
        ingredient.Id = nextId++;
        Ingredients.Add(ingredient);
    }

    public static void Delete(int id)
    {
        var ingredient = Get(id);
        if(ingredient is null)
            return;

        Ingredients.Remove(ingredient);
    }

    public static void Update(Ingredient ingredient)
    {
        var index = Ingredients.FindIndex(i => i.Id == ingredient.Id);
        if(index == -1)
            return;

        Ingredients[index] = ingredient;
    }
}