namespace MagicalInheritance
{
    class Archmage : Mage
    {
        public Archmage(string title) : base(title)
        { }


        public override Storm CastRainStorm()
        {
            //You’ll need to call the Storm constructor in the method
            return new Storm("rain", true, Title);
        }
        public Storm CastLightningStorm()
        {
            return new Storm("Lightning", true, Title);
        }
    }

}
