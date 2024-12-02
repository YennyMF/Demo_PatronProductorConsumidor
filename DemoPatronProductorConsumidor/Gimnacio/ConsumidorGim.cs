using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPatronProductorConsumidor.Gimnacio
{
    public class ConsumidorGim
    {
        private ColaGim<Clientes> _colaGim;
        public ConsumidorGim(ColaGim<Clientes> colaGim)
        {
            _colaGim = colaGim;
        }
        public Clientes Consumir()
        {
            Clientes clientes = _colaGim.Extraer();
            Thread.Sleep(5000);
            return clientes;
                }
    }
    }

