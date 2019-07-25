using System.Collections.Generic;

namespace SingleUse
{
    class People
    {
        public List<string> Names { get; set; }

        public People()
        {
            Names = new List<string> { "Lisa", "Bob", "Stephen", "Ricky", "Christine" };
        }

        public void AddName(string name)
        {
            Names.Add(name);
        }

        public int CountNames()
        {
            return Names.Count;
        }

        public string ListOfNames()
        {
            string output = "";

            foreach (string name in Names)
            {
                output += name + " ";
            }

            return output;
        }
    }
}
