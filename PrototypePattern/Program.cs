using PrototypePattern.CSharpPrototype;
using PrototypePattern.ImplementPrototype;

{
    ConcretePrototype prototype = new ConcretePrototype("1");
    ConcretePrototype copyPrototype = (ConcretePrototype)prototype.Clone();
    Console.WriteLine($"Cloned: {copyPrototype.Id}");
}
{
    Console.WriteLine("ICloneable");
    Resume resume = new Resume("A");
    resume.SetWork("companyA");
    resume.SetEducation("schoolA");

    Resume copyResume = (Resume)resume.Clone();
    copyResume.SetWork("companyB");
    copyResume.SetEducation("schoolB");

    resume.Display();
    copyResume.Display();
}