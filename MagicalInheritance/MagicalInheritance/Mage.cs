namespace MagicalInheritance
{
    //In Mage.cs, define an empty Mage class that inherits from Pupil
    class Mage : Pupil
    {
        //Add a Mage constructor with one string argument.It should call the base constructor with that same argument.
        public Mage(string title) : base(title) { }


        //It should be public with return type Storm. In the body of the method, construct a new Storm object and return it
        public virtual Storm CastRainStorm()
        {
            //You’ll need to call the Storm constructor in the method
            return new Storm("rain", false, Title);
        }
    }
}
