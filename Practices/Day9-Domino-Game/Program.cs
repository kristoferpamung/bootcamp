using DominoGameClasses;
using DominoGameInterface;

Console.WriteLine("=== WELCOME TO MY BEST DOMINO GAME IN THE WORLD ===");
Console.Write("Masukan jumlah player (2-4): ");
int playerCount = 0;
if (int.TryParse(Console.ReadLine(), out int player))
{
    if (player >= 2 && player <= 4)
    {
        playerCount = player;
    }
    else if (player > 4)
    {
        Console.WriteLine("Tidak bisa melebihi 4");
    }
    else
    {
        Console.WriteLine("Player tidak bisa dibawah 2");
    }
}
else
{
    Console.WriteLine("Inputan anda Salah");
}

List<IPlayer> players = [];

for (int i = 1; i <= playerCount; i++)
{
    Console.Write("Masukan nama player " + i + ": ");
    players.Add(new Player(Console.ReadLine()!));
}

Game game = new(players);

game.GameEvent += game.HandleGameStart!;
game.StartGame();

foreach (DominoTile d in game.deck.dominoTiles)
{
    Console.WriteLine($"{d.PipLeft} - {d.PipRight}");
}