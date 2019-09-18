using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DB
    {
        public static int lastId = 0;

        public static List<Memo> memos = new List<Memo>() { 
            new Memo() {Id=1, Note = "Test1"},
            new Memo() {Id=1, Note = "Test2"}
        };


    }
}
