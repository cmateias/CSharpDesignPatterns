using System.Collections;

namespace Composite
{
    public abstract class MenuComponent
    {
        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        public virtual double Price { get; set; }

        public virtual void Add(MenuComponent menuComponent)
        {
            throw new UnsupportedOperationException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new UnsupportedOperationException();
        }

        public virtual MenuComponent GetChild(int i)
        {
            throw new UnsupportedOperationException();
        }

        public virtual string Print()
        {
            throw new UnsupportedOperationException();
        }

        public virtual ArrayList GetMenu()
        {
            throw new UnsupportedOperationException();
        }

        public virtual int Count()
        {
            throw new UnsupportedOperationException();
        }
    }
}