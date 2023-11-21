using CadNatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnNatura
{
    public class HistoriaClinicaCln
    {
        public static int insertar(HistoriaClinica historiaClinica)
        {
            using (var context = new NaturaEntities())
            {
                context.HistoriaClinica.Add(historiaClinica);
                context.SaveChanges();
                return historiaClinica.id;
            }
        }

        public static int actualizar(HistoriaClinica historiaClinica)
        {
            using (var context = new NaturaEntities())
            {
                var existente = context.HistoriaClinica.Find(historiaClinica.id);
                existente.antecedentes = historiaClinica.antecedentes;
                existente.sintomas = historiaClinica.sintomas;
                existente.diagnosticos = historiaClinica.diagnosticos;
                existente.tratamientos = historiaClinica.tratamientos;
                existente.observaciones = historiaClinica.observaciones;
                existente.usuarioRegistro = historiaClinica.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new NaturaEntities())
            {
                var existente = context.HistoriaClinica.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static HistoriaClinica get(int id)
        {
            using (var context = new NaturaEntities())
            {
                return context.HistoriaClinica.Find(id);
            }
        }

        public static List<HistoriaClinica> listar()
        {
            using (var context = new NaturaEntities())
            {
                return context.HistoriaClinica.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paHistoriaClinicaListar_Result> listarPa(string parametro)
        {
            using (var context = new NaturaEntities())
            {
                return context.paHistoriaClinicaListar(parametro).ToList();
            }
        }
    }
}

