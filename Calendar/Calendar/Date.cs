using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class DateTime
    {
        public int ngay, thang, nam;
        public string thu;
        public int _NgayCuaThang()
        {
            if (thang == 2)
            {
                if (_NamNhuan()) return 29;
                return 28;
            }
            switch (thang)
            {
                case 1:
                    return 31;

                case 3:
                    return 31;

                case 5:
                    return 31;

                case 7:
                    return 31;

                case 8:
                    return 31;

                case 10:
                    return 31;

                case 12:
                    return 31;

                default:
                    return 30;

            }
        }
        private bool _NamNhuan()
        {
            {
                if (nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0))
                    return true;
                return false;
            }
        }
    }
}
