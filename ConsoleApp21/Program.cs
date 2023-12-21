Product sas = new Product("Sas", "Mamam", 12, 2, 10);
int[] mass = new int[1];
for (int i = 0; i < 1; i++)
{
    Console.WriteLine(sas.name);
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


