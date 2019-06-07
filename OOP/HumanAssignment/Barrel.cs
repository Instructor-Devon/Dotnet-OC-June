class Barrel : IDamagable
{
    public int Health {get;set;}
    public string Name {get;set;}

    public Barrel()
    {
        Health = 5;
        Name = "Barrel";
    }
}