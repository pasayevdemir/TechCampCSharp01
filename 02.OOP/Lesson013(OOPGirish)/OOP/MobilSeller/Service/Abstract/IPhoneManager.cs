using MobilSeller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilSeller.Service.Abstract
{
    public interface IPhoneManager
    {
        bool AddPhone(Phone phone);
        bool UpdatePhone(Phone phone,int id);
        bool DeletedPhone(int id);
        List<Phone> GetAll();
    }
}
