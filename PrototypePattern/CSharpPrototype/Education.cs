namespace PrototypePattern.CSharpPrototype
{
    internal class Education : ICloneable
    {
        public string School { get; set; }

        public object Clone()
        {
            return (object)this.MemberwiseClone();
        }
    }
}
