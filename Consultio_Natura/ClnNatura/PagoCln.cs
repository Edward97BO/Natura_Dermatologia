using CadNatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnNatura
{
    public class PagoCln
    {
        public static int insertar(Pago pago)
        {
            using (var context = new NaturaEntities())
            {
                context.Pago.Add(pago);
                context.SaveChanges();
                return pago.id;
            }
        }

        public static int actualizar(Pago pago)
        {
            using (var context = new NaturaEntities())
            {
                var existente = context.Pago.Find(pago.id);
                existente.importe = pago.importe;
                existente.estado = pago.estado;
                existente.usuarioRegistro = pago.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new NaturaEntities())
            {
                var existente = context.Pago.Find(id);
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static Pago get(int id)
        {
            using (var context = new NaturaEntities())
            {
                return context.Pago.Find(id);
            }
        }

        public static List<Pago> listar()
        {
            using (var context = new NaturaEntities())
            {
                return context.Pago.ToList();
            }
        }

        public static List<paPagoListar_Result> listarPa(string parametro)
        {
            using (var context = new NaturaEntities())
            {
                return context.paPagoListar(parametro).ToList();
            }
        }
    }
}

