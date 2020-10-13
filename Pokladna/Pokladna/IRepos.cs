using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokladna
{
   public interface IRepos
    {
         List<PokladniZaznam> Nactivse();
        PokladniZaznam NactiZaznam(int IdPokladniZaznam);
        PokladniZaznam VytvorZaznam(PokladniZaznam pokladniZaznam);
        void UpravZaznam(PokladniZaznam pokladniZaznam);
        void SmazZaznam(PokladniZaznam pokladniZaznam);
    }
}
