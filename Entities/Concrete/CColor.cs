using Entities.Abstract;

namespace Entities.Concrete
{
    public class CColor : IEntity
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}