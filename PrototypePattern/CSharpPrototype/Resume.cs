namespace PrototypePattern.CSharpPrototype
{
    internal class Resume : ICloneable
    {
        private string Name { get; set; }

        private string Company { get; set; }

        private Education Education { get; set; }

        public Resume(string name)
        {
            this.Name = name;
            this.Education = new Education();
        }

        private Resume(Education education)
        {
            this.Education = (Education)education.Clone();
        }

        public void SetWork(string company)
        {
            this.Company = company;
        }

        public void SetEducation(string school)
        {
            this.Education.School = school;
        }

        public void Display()
        {
            Console.WriteLine($"{this.Name} work in {this.Company}");
            Console.WriteLine($"{this.Name} graduate from {this.Education.School}");
        }

        public object Clone()
        {
            Resume resume = new Resume(this.Education);
            resume.Name = this.Name;
            resume.Company = this.Company;
            return resume;
        }
    }
}
