using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHomeService
    {
        List<Home> GetListAll();
        Home GetById(int id);
        void Insert(Home home);
        void Update(Home home);
        void Delete(int id);
    }
}
