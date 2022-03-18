using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IESE.Service
{
    public class Config //В конфиг можно добавлять и другую информацию типо телефона университета, который может в какой то момент поменяться поэтому легче поменять в json файле чем в коде
    {
        public static string ConnectionString { get; set; } //Строка для SQL сервера
    }
}
