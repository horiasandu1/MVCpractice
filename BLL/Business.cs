using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Business
    {


        public List<Memo> GetMemos()
        {
            return DB.memos;

         //   var x = DB.memos.Where(m => m.Id == 5).Select(y => y).First();
        }

    }
}
