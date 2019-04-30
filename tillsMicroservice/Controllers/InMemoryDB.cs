using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tillsMicroservice.Controllers
{
    public class InMemoryDB
    {
        private Dictionary<string, string> _db;
        private Random _random;

        public InMemoryDB()
        {
           _random = new Random();
            _db = new Dictionary<string, string>();
        }

        public void Save(string key, string value)
        {
            _db.Add(key,value);
        }

        public string Read(string key)
        {
            return _db[key];
        }

        public string Insert(string value)
        {
            string key;
            key = "key" + _random.Next();
                while (_db.ContainsKey(key))
                {
                    key = "key" + _random.Next();
            }
            _db.Add(key,value);
            return key;
        }

        public int Count()
        {
            return _db.Count();
        }
    }
}
