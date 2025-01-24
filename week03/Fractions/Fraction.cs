using System;



public class Fraction
{
    //Attributes for the top and bottom numbers
   private int _top;
   private int _bottom;
   //Constructors
   public Fraction()
   {
    _top = 1;
    _bottom = 1;
   }
   public Fraction(int wholeNumber)
   {
    _top = wholeNumber;
    _bottom = 1;
   }

   public Fraction(int top, int bottom)
   {
    _top = top;
    _bottom = bottom;

   }
   //Getters and setters for the top and bottom numbers


    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
      
        return (double)_top / (double)_bottom;
    }



   //Methods to return representations of both the fractional and decimal views.

}