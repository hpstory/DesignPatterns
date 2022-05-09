namespace PrototypePattern.ImplementPrototype
{
    class ConcretePrototype : Prototype
    {
        public ConcretePrototype(string id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
