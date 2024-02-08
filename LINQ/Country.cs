using System;
public class Country
{
    public string Name { get; set; }
    public string Capital { get; set; }
    public string Continent { get; set; }
    public long Population { get; set; }
    public DateTime IndependenceDay { get; set; }

    public Country(string N, string Cp, String C, long p, DateTime i = default)
    {
        Name = N;
        Capital = Cp;
        Continent = C;
        Population = p;
        IndependenceDay = i;
    }




}