using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class HomeManager : IHomeService
    {
        private IHomeRepository _homeRepository;

        public HomeManager(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;   
        }

        public void Delete(int id)
        {
            var entity = _homeRepository.GetById(id);
            _homeRepository.Delete(entity);
        }

        public Home GetById(int id)
        {
            return _homeRepository.GetById(id);
        }

        public List<Home> GetListAll()
        {
            return _homeRepository.GetListAll();
        }

        public void Insert(Home home)
        {
            _homeRepository.Insert(home);
        }

        public void Update(Home home)
        {
            _homeRepository.Update(home);
        }
    }
}
