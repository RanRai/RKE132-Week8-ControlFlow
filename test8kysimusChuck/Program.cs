//kuvada konsoolis chuck.txt faili sisu "tunniks8_andmed_villains.txt" nummerdatud loetelu kujul:

string folderPath = @"C:\Users\Ranno\Desktop\tktk\programmeerimise_algkursus_RKE132\";
string villainFile = "tunniks8_andmed_villains.txt";
string[] lines = File.ReadAllLines(Path.Combine(folderPath, villainFile));

ShowFileContent(lines);
static void ShowFileContent(string[] fileContentArray)
{
    int i = 1;
    foreach (string line in fileContentArray)//iga rida ContentArray massiivis. line on enda kirjutatud ja võib asendada
    {
        Console.WriteLine($"{i}. {line}");
        i++;
    }
}
