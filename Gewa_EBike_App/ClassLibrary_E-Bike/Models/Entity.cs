using System.Linq;

namespace ClassLibraryEBike
{
    public class Entity
    {
        public int Id { get; }
        private int currentId = 1;

        public Entity()
        {
            Id = currentId;
            currentId++;
        }

    }
}
