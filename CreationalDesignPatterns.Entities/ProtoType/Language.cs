namespace CreationalDesignPatterns.Entities.ProtoType
{
    using System;

    public class Language : ICloneable
    {
        public Language(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }


        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
