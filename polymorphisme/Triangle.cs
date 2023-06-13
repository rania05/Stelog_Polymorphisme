using System;

public class Triangle : Forme
{
    private double baseTriangle;
    private double hauteur;

    public Triangle(double baseTriangle, double hauteur)
    {
        this.baseTriangle = baseTriangle;
        this.hauteur = hauteur;
    }

    public override double CalculSurface()
    {
        return (baseTriangle * hauteur) / 2;
    }
}