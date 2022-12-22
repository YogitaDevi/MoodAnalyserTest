using TC1._1_MoodAnalyse;

Console.WriteLine("Ability to Analyse and Respond 'Sad or Happy Mood'");
string input = Console.ReadLine();

MoodAnalyseClass analyse = new MoodAnalyseClass(input);
Console.WriteLine(analyse.Analyse());

