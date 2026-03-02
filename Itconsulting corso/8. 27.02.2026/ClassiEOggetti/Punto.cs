class Punto
{
    public int x;
    public int y;

    public override bool Equals(object? obj)
    {
        if(obj is Punto altro)
            return this.x == altro.x && this.y == altro.y;
        return false;
    }
}