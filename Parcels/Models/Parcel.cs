using System;

namespace Parcels.Models
{
  public class Parcel
  {
    public double Length { get; set; } = 0;
    public double Width { get; set; } = 0;
    public double Height { get; set; } = 0;
    public double Weight { get; set; } = 0;
    public double Volume { get; set; } = 0;
    public double Price { get; set; } = 0;

    public Parcel (double length, double width, double height, double weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
    }

    public double FindVolume ()
    {
      Volume = Length * Width * Height;
      return Volume;
    }

    public string CostToShip ()
    {
      Price = 0;
      Price += 0.10 * FindVolume();
      Price += 1.00 * Weight;
      Price = Math.Round(Price, 2);
      return Price.ToString("C2");
    }
  }
}