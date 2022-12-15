using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHotelService
    {
        List<Hotel> GetListAll();
        Hotel GetById(int id);
        void Insert(Hotel hotel);
        void Updated(Hotel hotel);
        void Delete(int id);
    }
}
