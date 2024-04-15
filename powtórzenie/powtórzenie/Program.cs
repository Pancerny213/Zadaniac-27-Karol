using powtórzenie;

class PlikGłówny 
{
    
    static void Main(string[] args)
    {
        //to jest baza naszego projektu
        Tablice tablica = new Tablice(); 
        tablica.wyswietl();
        int[] tab = tablica.Tworzenie_Tablicy();    
    }
}