namespace Petstore
{
    public class Pet
    {
        public Pet()
        {
        }

        public Pet(string id, string name, string tag)
        {
            Id = id;
            Name = name;
            Tag = tag;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }
    }
}
