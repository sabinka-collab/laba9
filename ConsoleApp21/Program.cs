        Product sas = new Product("Val", "Mamam", 12, 2, 10);
        Product val = new Product("Val", "Sabina", 11, 4, 8);
        Product mal = new Product("Mal", "Hihi", 3, 6, 9);
        Product[] mass = new Product[] {sas, val, mal};
string sss = "Val";
        for (int i = 0; i < 3; i++)
        {
    if (mass[i].name == sss)
    {
        Console.WriteLine(mass[i].proizvoditel);
    }
        }
class Product
{
    public string name;
    public string proizvoditel;
    public int manny;
    public int srok;
    public int kolvo;
    public Product (string name, string proizvoditel, int manny, int srok, int kolvo)
    {
        this.name = name;
        this.proizvoditel = proizvoditel;
        this.manny = manny;
                this.srok = srok;
        this.kolvo = kolvo;
    }   
}

