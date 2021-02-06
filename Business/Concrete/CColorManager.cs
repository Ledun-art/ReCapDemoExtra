using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CColorManager : ICColorService
    {
        private ICColorDal _colorDal;

        public CColorManager(ICColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public List<CColor> GetsColors()
        {
            return _colorDal.GetAll();
        }
    }
}