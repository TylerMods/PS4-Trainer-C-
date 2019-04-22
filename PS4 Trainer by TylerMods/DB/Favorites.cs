using System.Collections.Generic;

public class Favorites
{
    private RegistryData registryData;
    public Favorites()
    {
        registryData = new RegistryData("Software\\PS4 Trainer by TylerMods\\Favorite Games");
    }

    public List<string> GetAllGames()
    {
        var allGames = registryData.RegistryKey.GetValueNames();

        if (allGames == null)
            return default(List<string>);

        List<string> games = new List<string>();
        foreach (var game in allGames)
        {
            games.Add(game);
        }

        return games;
    }

    public void AddNewGame(string name)
    {
        registryData.Add(name, "");
    }

    public void Delete(string gameName)
    {
        registryData.Delete(gameName);
    }
}