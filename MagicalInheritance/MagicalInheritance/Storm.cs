namespace MagicalInheritance
{
    class Storm
    {
        /*Define three automatic properties. Each one should have a public getter and private setter:string Essence - the type of storm, like wind or rain bool IsStrong- true if the storm is strong string Caster - the title of the magician casting the storm*/
        public string Essence { get; private set; }
        public bool IsStrong { get; private set; }
        public string Caster { get; private set; }


        //Define a constructor that takes three arguments, one for each property.
        // In the body of the constructor, use those arguments to set the property values.
        public Storm(string essence, bool isStrong, string caster)
        {
            this.Essence = essence;
            this.IsStrong = isStrong;
            this.Caster = caster;
        }
        public string Announce()
        {


            if (IsStrong)
            {
                return $"{Caster} cast a Strong {Essence} storm!";
            }
            else
            {
                return $"{Caster} cast a weak {Essence} storm!";

            }
        }

    }
}
