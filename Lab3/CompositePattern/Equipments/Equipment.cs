using System;

namespace CompositePattern.Equipments
{
    abstract class Equipment
    {
        public abstract decimal NetPrice();
        public abstract decimal DiscountPrice();
        public abstract int Power();
        public virtual void Add(Equipment component) => throw new NotImplementedException();
        public virtual void Remove(Equipment component) => throw new NotImplementedException();
        public virtual bool IsComposite() => true;
    }
}
