using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.modelo
{
    internal class ListaMercancia
    {
        private List<Mercancia> listMercancia;

        ListaMercancia(List<Mercancia> listMercancia)
        {
            this.listMercancia = listMercancia;
        }

        ListaMercancia()
        {

        }

        public void setListaMercancia(List<Mercancia> listMercancia)
        {
            this.listMercancia = listMercancia;
        }

        public List<Mercancia> getListaMercancia()
        {
            return listMercancia;
        }

    }
}
