using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using RecipeBook.Api.Models;
using RecipeBook.Api.DataAccess;

namespace RecipeBook.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class RecipeController : ControllerBase {
	public IActionResult AddNewRecipe( RecipeModel recipeModel ) {

		var businessLogic = new RecipeBusinessLogic();
		businessLogic.SaveRecipe(recipeModel);

		Console.WriteLine("Adding new recipe.");
		return Ok();
	}






}
