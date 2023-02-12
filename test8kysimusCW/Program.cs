string folderPath = @"C:\Users\Ranno\Desktop\tktk\programmeerimise_algkursus_RKE132\";
string villainFile = "tunniks8_andmed_villains.txt";
string[] lines = File.ReadAllLines(Path.Combine(folderPath, villainFile));
Console.WriteLine(lines.Length);//kuvab loetelu arvu, alustades 1-st