
using System.Collections.Generic;

namespace Repository.Data
{
    public static class AddDbContext<T>
    {
        public static List<T> datas;

        static AddDbContext()
        {
            datas = new List<T>();
        }
    }
}
