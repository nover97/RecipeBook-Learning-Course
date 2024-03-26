using RecipeBook.Api.DataAccess;
using RecipeBook.Api.Models;

namespace RecipeBook.Api.BusinessLogic;

public class RecipeBusinessLogic {
	public void SaveRecipe( RecipeModel recipeModel ) {

		// Validate the recipe model
		var dataAccess = new RecipeDataAccess();
		dataAccess.SaveRecipeToDatabase(recipeModel);
		Console.WriteLine("Adding new recipe.");

	}
}
