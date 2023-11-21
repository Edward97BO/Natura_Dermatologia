using CadNatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnNatura
{
    public class ReconsultaCln
    {
        public static int insertar(Reconsulta reconsulta)
        {
            using (var context = new NaturaEntities())
            {
                context.Reconsulta.Add(reconsulta);
                context.SaveChanges();
                return reconsulta.id;
            }
        }

        public static int actualizar(Reconsulta reconsulta)
        {
            using (var context = new NaturaEntities())
            {
                var existente = context.Reconsulta.Find(reconsulta.id);
                existente.fecha = reconsulta.fecha;
                existente.hora = reconsulta.hora;
                existente.motivo = reconsulta.motivo;
                existente.usuarioRegistro = reconsulta.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new NaturaEntities())
            {
                var existente = context.Reconsulta.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static Reconsulta get(int id)
        {
            using (var context = new NaturaEntities())
            {
                return context.Reconsulta.Find(id);
            }
        }

        public static List<Reconsulta> listar()
        {
            using (var context = new NaturaEntities())
            {
                return context.Reconsulta.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paReconsultaListar_Result> listarPa(string parametro)
        {
            using (var context = new NaturaEntities())
            {
                return context.paReconsultaListar(parametro).ToList();
            }
        }
    }
}

