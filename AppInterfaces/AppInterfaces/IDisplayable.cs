// In IDisplayable.cs, define an empty IDisplayable interface.

namespace AppInterface
{

    interface IDisplayable
    {

        //Within IDisplayable declare one method that: is named Display() returns nothing
        void Display();
        //Add a get-only property to IDisplayable called HeaderSymbol. This should be used in Display() as a header.
        string HeaderSymbol { get; }
    }

}