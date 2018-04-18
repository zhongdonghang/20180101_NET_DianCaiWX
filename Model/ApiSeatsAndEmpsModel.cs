
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class ApiSeatsAndEmpsModel
    {
        public List<T_SEATEntity> Seats { get; set; }

        public List<T_MEMBERSEntity> Members { get; set; }
    }
}
