using System;

namespace Except
{
    public class RomanNumberException : Exception
    {
        public RomanNumberException(string Warning) : base(Warning) { }
    }
}