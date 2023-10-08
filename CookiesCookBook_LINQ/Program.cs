using CookiesCookBook_LINQ.App;
using CookiesCookBook_LINQ.DataAccess;
using CookiesCookBook_LINQ.FileAccess;
using CookiesCookBook_LINQ.Recipes;

try
{
    const FileFormat Format = FileFormat.Json;

    IStringsRepository stringsRepository = Format == FileFormat.Json
        ? new StringsJsonRepository()
        : new StringsTextualRepository();

    const string FileName = "recipes";
    var fileMetadata = new FileMetadata(FileName, Format);


    var ingredientsRegister = new IngredientsRegister();

    var cookiesRecepiesApp = new CookiesRecipesApp(
        new RecipesRepository(
            new StringsJsonRepository(), ingredientsRegister),
        new RecipesConsoleUserInteraction(ingredientsRegister));

    cookiesRecepiesApp.Run(fileMetadata.ToPath());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}