using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T get<T>(string key);
        object Get(string key);
        void add(string key, object value,int duration);
    }
}
