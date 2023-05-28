using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHTRQD.Models
{
 
    public class Nghe
    {
      public int Id { get; set; }
      public string TenNN { get; set; }

      public Nghe(int id, string tenNN)
      {
        Id = id;
        TenNN = tenNN;
      }

      public override string ToString()
      {
        return TenNN;
      }
    }

}
