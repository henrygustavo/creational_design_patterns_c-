namespace CreationalDesignPatterns.Entities.ProtoType
{
    using System;

    public abstract  class Item: ICloneable
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public string Url { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
