using TC1._2_MoodAnalyse;

Console.WriteLine("Ability to Analyse and Respond Happy or Sad Mood");
string input = Console.ReadLine();

MoodAnalyserClass analyse = new MoodAnalyserClass(input);
Console.WriteLine(analyse.Analyse());

