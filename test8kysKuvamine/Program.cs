//Mis programm loeb andmeid failist chuck.txt, kuvab neid konsoolis, ega ei viska veateadet?
//*Vihje - pange erilist tähelepanu kausta-ja faili aadressile

string folderPath = @"C:\Users\Ranno\Desktop\tktk\programmeerimise_algkursus_RKE132\";
string villainFile = "tunniks8_andmed_villains.txt";
string[] lines = File.ReadAllLines(Path.Combine(folderPath, villainFile));

foreach (string hero in lines)
{
    Console.WriteLine(hero);
}


//SEE TÖÖTAB SAMUTI
//string folderPath = @"C:\Users\Ranno\Desktop\tktk\programmeerimise_algkursus_RKE132\";
//string villainFile = "tunniks8_andmed_villains.txt";
//string[] lines = File.ReadAllLines(folderPath+villainFile);

//foreach (string hero in lines)
//{
//    Console.WriteLine(hero);
//}
