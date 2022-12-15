using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class HotelManager : IHotelService
    {
        private IHotelRepository _hotelRepository;

        public HotelManager(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public void Delete(int id)
        {
            var entity = _hotelRepository.GetById(id);
            _hotelRepository.Delete(entity);
        }

        public Hotel GetById(int id)
        {
            return _hotelRepository.GetById(id);
        }

        public List<Hotel> GetListAll()
        {
            return _hotelRepository.GetListAll();
        }

        public void Insert(Hotel hotel)
        {
            _hotelRepository.Insert(hotel);
        }

        public void Updated(Hotel hotel)
        {
            _hotelRepository.Update(hotel);
        }
    }
}
