namespace LINQ
{
    public class MartialArtsMaster
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public int Age { get; set; }
        public  string Menpai { get; set; }
        public string Kongfu { get; set; }
        public int Level { get; set; }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}  \t  {nameof(Name)}: {Name}  \t  {nameof(Age)}: {Age}  \t  {nameof(Menpai)}: {Menpai}  \t  {nameof(Kongfu)}: {Kongfu}  \t  {nameof(Level)}: {Level}  \t  ";
        }
    }
}