using Classes;

Player p1 = new("Player 1");
Player p2 = new("Player 2");

Game game = new(player1: p1, player2: p2);
game.ShuffleDomino();


Console.WriteLine("==== Player 1 Hand ====");

foreach (Domino d in p1.Hand)
{
    Console.WriteLine("Domino dihand: " + d.PipTop + " - " + d.PipBottom);
}

Console.WriteLine("==== Player 2 Hand ====");        
        
foreach (Domino d in p2.Hand)
{
    Console.WriteLine("Domino dihand: " + d.PipTop + " - " + d.PipBottom);
}