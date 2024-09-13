using System;

namespace AppInterfaces
{
    interface IDisplayable
    {
        // property
        string HeaderSymbol { get; }

        // method
        void Display();
    }
}