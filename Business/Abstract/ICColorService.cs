using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICColorService
    {
        List<CColor> GetsColors();
    }
}