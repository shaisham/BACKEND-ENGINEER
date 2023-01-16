namespace DatingProfile
{
    internal class Profile
    {
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronoun;
        private string[] hobbies;


        public Profile(string name, int age, string city = "n/a", string country = "n/a", string pronoun = "they/them")
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronoun = pronoun;
            this.hobbies = new string[0];


        }
        public string ViewProfile()
        {
            string bio = $"Name: {name}\n Age: {age}\n City: {city}\n Country: {country}\n Pronoun: {pronoun} ";
            if (this.hobbies.Length > 0)
            {
                bio += $"\n Hobbies:\n";

                foreach (string hobbie in hobbies)
                {
                    bio += $"- {hobbie}\n";
                }
            }

            return bio;

        }

        public void SetHobbies(string[] Hobbies)
        {
            this.hobbies = Hobbies;
        }
    }
}
