using CadNatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnNatura
{
    public class DermatologoCln
    {
        public static int insertar(Dermatologo dermatologo)
        {
            using (var context = new NaturaEntities())
            {
                context.Dermatologo.Add(dermatologo);
                context.SaveChanges();
                return dermatologo.id;
            }
        }

        public static int actualizar(Dermatologo dermatologo)
        {
            using (var context = new NaturaEntities())
            {
                var existente = context.Dermatologo.Find(dermatologo.id);
                existente.nombre = dermatologo.nombre;
                existente.apellido = dermatologo.apellido;
                existente.matricula= dermatologo.matricula;
                existente.especialidad = dermatologo.especialidad;
                existente.usuarioRegistro = dermatologo.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new NaturaEntities())
            {
                var existente = context.Dermatologo.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static Dermatologo get(int id)
        {
            using (var context = new NaturaEntities())
            {
                return context.Dermatologo.Find(id);
            }
        }

        public static List<Dermatologo> listar()
        {
            using (var context = new NaturaEntities())
            {
                return context.Dermatologo.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paDermatologoListar_Result> listarPa(string parametro)
        {
            using (var context = new NaturaEntities())
            {
                return context.paDermatologoListar(parametro).ToList();
            }
        }
    }
}

