namespace MagicalInheritance
{
    internal class Pupil
    {
        public string Title { get; private set; }
        public Pupil(string title)
        {
            Title = title;
        }
        //It should be public with return type Storm. In the body of the method, construct a new Storm object and return it.
        public Storm CastWindStorm()
        {
            return new Storm("wind", false, Title);
        }



    }
}
