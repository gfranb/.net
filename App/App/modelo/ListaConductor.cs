using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.modelo
{
    internal class ListaConductor
    {
        
        private List<Conductor> listConductor;

        ListaConductor(List<Conductor> listConductor)
        {
            this.listConductor = listConductor;
        }

        ListaConductor()
        {

        }

        public void setListaConductor(List<Conductor> listConductor)
        {
            this.listConductor = listConductor;
        }

        public List<Conductor> getListaConductor()
        {
            return listConductor;
        }

    }
}

