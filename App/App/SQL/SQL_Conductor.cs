using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SQL
{
    internal class SQL_Conductor
    {
        public List<string> buscarConductor(string id)
        {
            using (netAssistantsEntities db = new netAssistantsEntities())
            {
                List<Conductor> conductores = db.Conductor.ToList();

                foreach (Conductor c in conductores)
                {
                    if (c.id_conductor == Int32.Parse(id))
                    {
                        List<string> con = new List<string>();
                        con.Add(c.id_conductor.ToString());
                        con.Add(c.nombre.ToString());
                        con.Add(c.apellidos.ToString());
                        con.Add(c.domicilio.ToString());
                        con.Add(c.permiso.ToString());
                        con.Add(c.disponibilidad.ToString());
                        return con;
                    }
                }
                return null;

            }
        }

        public bool addConductor(List<string> listaCon)
        {
            Conductor conductor = new Conductor();
            conductor.id_conductor = Int32.Parse(listaCon[0]);
            conductor.nombre = listaCon[1];
            conductor.apellidos = listaCon[2];
            conductor.domicilio = listaCon[3];
            conductor.permiso = listaCon[4];
            conductor.disponibilidad = bool.Parse(listaCon[5]);

            using (netAssistantsEntities db = new netAssistantsEntities())
            {
                
                var v = db.Conductor.Where(a => a.id_conductor.Equals(conductor.id_conductor)).FirstOrDefault();
                if (v != null)
                {
                    v.id_conductor = conductor.id_conductor;
                    v.nombre = conductor.nombre;
                    v.apellidos = conductor.apellidos;
                    v.domicilio = conductor.domicilio;
                    v.permiso = conductor.permiso;
                    v.disponibilidad = (bool)conductor.disponibilidad;
                    return false;
                }
                else
                {
                    db.Conductor.Add(conductor);
                }
                
                db.SaveChanges();
                return true;
            }
        }
        public bool eliminarConductor(string i)
        {
            int id = Int32.Parse(i);
            using (netAssistantsEntities db = new netAssistantsEntities())
            {
                var conductor = db.Conductor.Where(a => a.id_conductor.Equals(id)).FirstOrDefault();
                if (conductor != null)
                {
                    db.Conductor.Remove(conductor);
                    db.SaveChanges();
                    return true;
                    
                }

                return false;
            }
        }
        public bool editarConductor(List<string> listaCon)
        {
            Conductor conductor = new Conductor();
            conductor.id_conductor = Int32.Parse(listaCon[0]);
            conductor.nombre = listaCon[1];
            conductor.apellidos = listaCon[2];
            conductor.domicilio = listaCon[3];
            conductor.permiso = listaCon[4];
            conductor.disponibilidad = bool.Parse(listaCon[5]);

            using (netAssistantsEntities db = new netAssistantsEntities())
            {

                var v = db.Conductor.Where(a => a.id_conductor.Equals(conductor.id_conductor)).FirstOrDefault();
                if (v != null)
                {
                    v.id_conductor = conductor.id_conductor;
                    v.nombre = conductor.nombre;
                    v.apellidos = conductor.apellidos;
                    v.domicilio = conductor.domicilio;
                    v.permiso = conductor.permiso;
                    v.disponibilidad = (bool)conductor.disponibilidad;
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
