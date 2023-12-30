namespace ConsoleApplication1
{
    public class Wife
    {
        public int Age { get; set; }
        public string BodyType { get; set; }
        public int HairLength { get; set; }
        public int PartnerCount { get; set; }

        public Wife(int age, string bodyType, int hairLength, int partnerCount)
        {
            Age = age;
            BodyType = bodyType;
            HairLength = hairLength;
            PartnerCount = partnerCount;
        }
    }
}