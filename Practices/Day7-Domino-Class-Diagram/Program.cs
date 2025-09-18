using Classes;

Player p1 = new(name: "Player 1");
Player p2 = new(name: "Player 2");

Game game = new(p1, p2);

Console.WriteLine("Player 1: " + game.players[0].Name);
Console.WriteLine("Palyer 2: " + game.players[1].Name);

