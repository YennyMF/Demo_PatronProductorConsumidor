using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPatronProductorConsumidor.Gimnacio
{
    public class ProductorGim
    {
        private ColaGim<Clientes> _colaGim;
        public ProductorGim(ColaGim<Clientes> colaGim)
        {
            _colaGim = colaGim;
        }
        public void Producir(Clientes item)
        {
            _colaGim.Agregar(item);
            Thread.Sleep(2000);
        }
    }
}
