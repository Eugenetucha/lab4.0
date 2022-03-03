
using System;
namespace lab4;
public class RomanNumberException : Exception
{
    public override string Message
    {
        get
        {
            return "значение меньше либо равно нулю";
        }
    }
}