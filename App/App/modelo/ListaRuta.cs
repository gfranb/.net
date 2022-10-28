using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.modelo;

namespace WindowsFormsApp1.modelo
{
    internal class ListaRuta
    {
        private List<Ruta> listRuta;

        ListaRuta(List<Ruta> listRuta)
        {
            this.listRuta = listRuta;
        }

        ListaRuta()
        {

        }

        public void setListaRuta(List<Ruta> listRuta)
        {
            this.listRuta = listRuta;
        }

        public List<Ruta> getListaRuta()
        {
            return listRuta;
        }

    }
}
