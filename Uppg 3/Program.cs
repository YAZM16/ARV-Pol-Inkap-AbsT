Arv

public class Fordon
{
    public string Märke { get; set; }
    public string Model { get; set; }
}

// File: Bil.cs
public class Bil : Fordon
{
    public int Rignum { get; set; }
}
