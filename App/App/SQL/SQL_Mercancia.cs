using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SQL
{
    internal class SQL_Mercancia
    {
        public List<string> buscarMercancia(string id)
        {
            using (netAssistantsEntities db = new netAssistantsEntities())
            {
                List<Mercancia> mercancias = db.Mercancia.ToList();

                foreach(Mercancia m in mercancias)
                {
                    if (m.id_producto == Int32.Parse(id))
                    {
                        List<string> vs = new List<string>();
                        vs.Add(m.id_producto.ToString());
                        vs.Add(m.nombre.ToString());
                        vs.Add(m.volumenProducto.ToString());                        
                        return vs;
                        
                    }                    
                }
                return null;    

            }
        }
        public bool addMercancia(List<string> listaM)
        {
            Mercancia i = new Mercancia();
            i.id_producto = Int32.Parse(listaM[0]);
            i.nombre = listaM[1];
            i.volumenProducto =  (float)Int32.Parse(listaM[2]);

            using (netAssistantsEntities db = new netAssistantsEntities())
            {
                
                    var v = db.Mercancia.Where(a => a.id_producto.Equals(i.id_producto)).FirstOrDefault();
                    if (v != null)
                    {
                        v.id_producto = i.id_producto;
                        v.nombre = i.nombre;
                        v.volumenProducto = i.volumenProducto;
                    return false;
                    }
                    else
                    {
                        db.Mercancia.Add(i);
                    }
                
                
                db.SaveChanges();

                return true;
            }
        }

        public bool eliminarMercancia(string i)
        {
            int id = Int32.Parse(i);
            using (netAssistantsEntities db = new netAssistantsEntities())
            {

                var v = db.Mercancia.Where(a => a.id_producto.Equals(id)).FirstOrDefault();
                if (v != null)
                {
                    db.Mercancia.Remove(v);
                    db.SaveChanges();
                    return true;
                }
                                
                return false;
            }
        }
    }
}
