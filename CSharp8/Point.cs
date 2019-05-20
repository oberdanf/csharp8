using System;
public struct Point
{
    public double X { get; set; }
    public double Y { get; set; }
    
    // If you remove readonly from here you're going to get a compiler warning message:
    // warning CS8656: Call to non-readonly member 'Point.Distance.get' from a 'readonly' member results in an implicit copy of 'this'
    public readonly double Distance => Math.Sqrt(X * X + Y * Y);

    public readonly override string ToString() => $"({X}, {Y}) is {Distance} from the origin";
}