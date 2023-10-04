using SolutionKata;

// Lire le fichier d'entrée
string[] lines = File.ReadAllLines("input.txt");

// Parser les coordonnées de la pelouse
string[] gridSize = lines[0].Split(' ');
int maxX = int.Parse(gridSize[0]);
int maxY = int.Parse(gridSize[1]);

List<Tondeuse> tondeuses = new List<Tondeuse>();

// Parcourir les lignes d'instructions pour chaque tondeuse
for (int i = 1; i < lines.Length; i += 2)
{
    string[] initialPosition = lines[i].Split(' ');
    int initialX = int.Parse(initialPosition[0]);
    int initialY = int.Parse(initialPosition[1]);
    char initialOrientation = char.Parse(initialPosition[2]);

    Tondeuse tondeuse = new Tondeuse(initialX, initialY, initialOrientation);
    string instructions = lines[i + 1];

    // Exécuter les instructions
    tondeuse.ExecuteInstructions(instructions, maxX, maxY);

    // Ajouter la tondeuse à la liste
    tondeuses.Add(tondeuse);
}

// Afficher la position finale de chaque tondeuse
foreach (var tondeuse in tondeuses)
{
    Console.WriteLine($"{tondeuse.X} {tondeuse.Y} {tondeuse.Orientation}");
}