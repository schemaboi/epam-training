namespace Epam.HomeWork.Training_3
{
    public struct ContactNumber
    {
        public ContactNumber(string name = "", string phoneNumber = "")
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Number: {PhoneNumber}";
        }
    }
}
