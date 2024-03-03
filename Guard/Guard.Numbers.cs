namespace Fitomad.Guard;

public sealed partial class Guard
{
    public static void InRange<Element>(Element value, Element lowerBound, Element upperBound) where Element : IComparable
    {
        Guard.InRange(value, lowerBound: lowerBound, upperBound: upperBound, perform: RangeAction);
    }

    public static void InRange<Element>(Element value, Element lowerBound, Element upperBound, Action perform) where Element : IComparable
    {
        bool rangeStartCheck = value.CompareTo(lowerBound) >= 0;
        bool rangeEndCheck = value.CompareTo(upperBound) <= 0;

        if(!(rangeStartCheck && rangeEndCheck))
        {
            Execute(perform);
        }
    }

    public static void NumberIsLower(double number, double lowerBound) 
    {
        Guard.NumberIsLower(number, lowerBound: lowerBound, perform: ArgumentAction);   
    }

    public static void NumberIsLower(double number, double lowerBound, Action perform) 
    {
        if (number >= lowerBound)
        {
            Execute(perform);
        }
    }

    public static void NumberIsLowerOrEquals(double number, double lowerBound) 
    {
        Guard.NumberIsLowerOrEquals(number, lowerBound: lowerBound, perform: ArgumentAction);   
    }

    public static void NumberIsLowerOrEquals(double number, double lowerBound, Action perform) 
    {
        if (number > lowerBound)
        {
            Execute(perform);
        }
    }

    public static void NumberIsGreater(double number, double upperBound) 
    {
        Guard.NumberIsGreater(number, upperBound: upperBound, perform: ArgumentAction);
    }

    public static void NumberIsGreater(double number, double upperBound, Action perform) 
    {
        if (number <= upperBound)
        {
            Execute(perform);
        }
    }

    public static void NumberIsGreaterOrEquals(double number, double upperBound) 
    {
        Guard.NumberIsGreaterOrEquals(number, upperBound: upperBound, perform: ArgumentAction);
    }

    public static void NumberIsGreaterOrEquals(double number, double upperBound, Action perform) 
    {
        if (number < upperBound)
        {
            Execute(perform);
        }
    }
}