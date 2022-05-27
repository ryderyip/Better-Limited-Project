using System;

namespace Better_Limited_Project.CustomerRecord
{
    public class Address : IEntity
    {
        private string? _id;

        public string Id
        {
            get => _id ?? throw new ArgumentException("Id is not initialized.");
            set => _id = value;
        }

        public string Address1 { get; set; }
        public string Address2 { get; set; }

        public void Save()
        {
            var repo = new AddressRepository();
            if (_id == null)
                repo.Insert(this);
        }
    }
}