using System.Linq;

namespace ClassLibraryEBike
{
    public class Entity
    {
        public int Id { get; }
        private static int idCounter = 1;
        

        public Entity()
        {
            Id = idCounter;
            idCounter++;
        }

    }
}
