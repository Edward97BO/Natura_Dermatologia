using CadNatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnNatura
{
    public class CitaCln
    {
        public static int insertar(Cita cita)
        {
            using (var context = new NaturaEntities())
            {
                context.Cita.Add(cita);
                context.SaveChanges();
                return cita.id;
            }
        }

        public static int actualizar(Cita cita)
        {
            using (var context = new NaturaEntities())
            {
                var existente = context.Cita.Find(cita.id);
                existente.fecha = cita.fecha;
                existente.hora = cita.hora;
                existente.motivo = cita.motivo;
                existente.usuarioRegistro = cita.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new NaturaEntities())
            {
                var existente = context.Cita.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static Cita get(int id)
        {
            using (var context = new NaturaEntities())
            {
                return context.Cita.Find(id);
            }
        }

        public static List<Cita> listar()
        {
            using (var context = new NaturaEntities())
            {
                return context.Cita.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paCitaListar_Result> listarPa(string parametro)
        {
            using (var context = new NaturaEntities())
            {
                return context.paCitaListar(parametro).ToList();
            }
        }
    }
}

