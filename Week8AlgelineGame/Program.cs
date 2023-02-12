string[] heroes = { "Harry Potter", "Luke Skywalker", "Lara Croft", "Scooby-Doo" };//sellest massiivist valib hero

Random rnd = new Random();//tahan valida suvalist tegelast
int randomIndex = rnd.Next(0, heroes.Length); //valida element massiivist ja välja kutsuda. gener. suvalise numbri vahemistku heroes.Length

string hero = heroes[randomIndex];//valin peategelase nime juhuslikult(index) 
Console.WriteLine($"Todey {hero} saves the day!"); //prindin välja valitud nime

string[] villains = { "Voldemort", "Darth Vader", "Dracula", "Joker", "Sauron" };//eelnevat Randomit ei saa kasutada, siin on 5 tegelast
                                                                                 // ja viimane jääb välja, sest randomIndex on 0-3, siin on 0-4 tegelast

randomIndex = rnd.Next(0, villains.Length);//teeb eraldi uue genereerimise indeksina pahalastele
string villain = villains[randomIndex];//valib pahalast juhusliku indeksiga ja annab sõna
Console.WriteLine($"Today {villain} tries to take over the world!");

//kood toimib, aga tegemist on DRY - don't repeat yourself!! selle vältimiseks toob sisse funktsioonid, et mitte korrata. pöörudme 
//funktsiooni juurde

//heros - massiiv; randomIndex - suvaline indeks. randomIndexist lahti saamiseks:
//EDASI FAIL EPIC GAME rida 48
