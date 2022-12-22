using UC1_MoodAnalyse;

Console.WriteLine("Sad or Happy");
string input = Console.ReadLine();

MoodAnalyser analyse = new MoodAnalyser(input);
Console.WriteLine(analyse.Analyse());

