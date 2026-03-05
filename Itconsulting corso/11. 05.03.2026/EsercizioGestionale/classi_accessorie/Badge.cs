public class Badge
{
    private long id;
    private DateOnly rilascio;

    public Badge(long id, DateOnly rilascio)
    {
        this.id = id;
        this.rilascio = rilascio;
    }

    public long Id
    {
        get => id;
    }
}