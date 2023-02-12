using System.Runtime.InteropServices;

string folderPath = @"C:\Users\Ranno\Desktop\tktk\programmeerimise_algkursus_RKE132\";//näitan kus failid asuvad, @ loeb kriipsud sõna osana
string heroFile = "tunniks8_andmed_heroes.txt";//näitan kaustas faili (faili laiendi lisan ise siin). 
string villainFile = "tunniks8_andmed_villains.txt";//näitan kaustas faili

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));//loeb andmed ridade kaupa failist, üks rida üks element. Path parandab faili aadressi
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));//Path parandab faili aadressi
//string[] heroes = { "Harry Potter", "Luke Skywalker", "Lara Croft", "Scooby-Doo" }; andmebaasi asemel andmed välja kirjutatud
//string[] villains = { "Voldemort", "Darth Vader", "Dracula", "Joker", "Sauron" };
string[] weapon = { "magic wand", "plastic fork", "banana", "wooden sword", "Lego brick" }; //selle saab teha ka failina võtmiseks! tegemata


string hero = GetRandomValueFromArray(heroes);//GRVFA kutsub massiivist heroes välja ühe suvalise kangelase
string heroWeapon = GetRandomValueFromArray(weapon);//GRVFA kutsub relva välja kangelasele
int heroHP = GetCharacterHP(hero);//HitPoints kasutamiseks lõime all logaritmi ja funktsiooni
int heroStrikeStrength = heroHP;//fikseerib löögitugevuse algtugevusega, JULIA PARANDAS MÄNGU TÖÖD
Console.WriteLine($"Today {hero} ({heroHP} HP) with {heroWeapon} saves the day!");

string villain = GetRandomValueFromArray(villains);//GRVFA kutsub massiivist villains välja ühe suvalise
string villainWeapon = GetRandomValueFromArray(weapon); //GRVFA kutsub relva välja pahalasele
int villainHP = GetCharacterHP(villain);//HitPoints kasutamiseks lõime all logaritmi ja funktsiooni
int villaStrikeStrength = villainHP;//fikseerib löögitugevuse algtugevusega, JULIA PARANDAS MÄNGU TÖÖD
Console.WriteLine($"Today {villain} ({villainHP} HP) with {villainWeapon} tries to take over the world!");

while(heroHP > 0 && villainHP > 0)//siin lahutame HPd tegelase väärtusest. Ei tea, millal lõpeb s.p kasut. while loopi.
    //kui üks nendes jõuab nullini, siis enam while tsüklit käima ei pane. SIIN LÄKS JULIAL MIDAGI VALESTI?
{
    heroHP = heroHP - Hit(villain, villaStrikeStrength);
    villainHP = villainHP - Hit(hero, heroStrikeStrength);
}

Console.WriteLine($"Hero {hero} HP: {heroHP}");//annab tagasisidet "mängu"
Console.WriteLine($"Villain {villain} HP: {villainHP}");//annab tagasisidet "mängu"

if (heroHP > 0)//kui kangelase HP on suurem nullist
{
    Console.WriteLine($"{hero} saves the day!");
}
else if (villainHP > 0)
{
    Console.WriteLine($"Dark side wins!");
}
else
{
    Console.WriteLine("Draw!");//kui mõlemal on väärtused alla nulli, siis viik (imelik?)
}

static string GetRandomValueFromArray(string[] someArray)//samade randomitest loobumine. soovin salvestada string tüübina
                                                         //GRVFA - enda välja mõeldud funktsiooni nimi. Hakkan valims string massiividest (sama tüüpi peavad olema)
{//kood algab siit
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length); //genereerib indexit lähtudes massiivi pikkusest someArray (pakun seda hiljem)
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;//tagastan vahemälusse
}//kood lõpeb siin. koodi täitmisel kustutatakse kõik vahemälust, jääb ainult string väärtus
//kõik mida siin plokis tegin, jääb siia ja kustutatakse peale tegevust. Jääb ainult loodud funktsioon GRVFA
//ja seda kasut. üleval pool!

static int GetCharacterHP(string characterName) //HP on täisarvud, s.p int. characterName - vb nii kangelane kui pahalane
{
    if(characterName.Length < 10) //kui nimi on alla 10 tähe, siis võtab HP ikkagi 10
    {
        return 10;
    }
    else
    {
        return characterName.Length;//kui on 10st suurem, siis võtab HP nime pikkuse järgi
    }
}

static int Hit(string characterName, int characterHP)//funktsioon löögitugevustest. võtsime tegelase ja tema HP
{
    Random rnd = new Random();
    int strike = rnd.Next(0, characterHP);//lõi uue muutuja strike(hoop/löök). See on suvaline arvuti pakutud väärtus
    
    if(strike == 0)
    {
        Console.WriteLine($"{characterName} missed the target!");// kui löök 0, siis lõi mööda
    }
    else if(strike == characterHP - 1)//siin maksimumtugevusega löök
    {
        Console.WriteLine($"{characterName} made a critical hit!");
    }
    else
    {
        Console.WriteLine($"{characterName} hit {strike}!");
    }
    return strike;
}