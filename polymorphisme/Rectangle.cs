using System;

public class Rectangle : Forme
{
    private double longueur;
    private double largeur;

    public Rectangle(double longueur, double largeur)
    {
        this.longueur = longueur;
        this.largeur = largeur;
    }

    public override double CalculSurface()
    {
        return longueur * largeur;
    }
}
