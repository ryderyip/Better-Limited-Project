namespace Better_Limited_Project.ProductUtility.Entity
{
    public class Category
    {
        public string Id { get; }
        public string Name { get; }

        public Category(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}