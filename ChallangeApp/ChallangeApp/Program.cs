string[] dniTygodnia = { "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedziela" };

for (int i = 0; i < dniTygodnia.Length; i += 2 )
{
    Console.WriteLine(dniTygodnia[i]);
}