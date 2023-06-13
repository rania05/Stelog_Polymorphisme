using System;

public class Cercle : Forme
{
    private double rayon;

    public Cercle(double rayon)
    {
        this.rayon = rayon;
    }

    public override double CalculSurface()
    {
        return Math.PI * rayon * rayon;
    }
}