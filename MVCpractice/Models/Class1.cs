using System;
using Entities;
using BLL;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCpractice.Models
{
    public class Model
    {
        private Business bll = new Business();

        public List<Memo> GetList()
        {
            return bll.GetMemos();
        }

    }
}