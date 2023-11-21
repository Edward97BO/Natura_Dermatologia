using CadNatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnNatura
{
    public class PacienteCln
    {
        public static int insertar(Paciente paciente)
        {
            using (var context = new NaturaEntities())
            {
                context.Paciente.Add(paciente);
                context.SaveChanges();
                return paciente.id;
            }
        }

        public static int actualizar(Paciente paciente)
        {
            using (var context = new NaturaEntities())
            {
                var existente = context.Paciente.Find(paciente.id);
                existente.nombre = paciente.nombre;
                existente.apellido = paciente.apellido;
                existente.ci = paciente.ci;
                existente.fechaNacimiento = paciente.fechaNacimiento;
                existente.telefono = paciente.telefono;
                existente.email = paciente.email;
                existente.usuarioRegistro = paciente.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new NaturaEntities())
            {
                var existente = context.Paciente.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static Paciente get(int id)
        {
            using (var context = new NaturaEntities())
            {
                return context.Paciente.Find(id);
            }
        }

        public static List<Paciente> listar()
        {
            using (var context = new NaturaEntities())
            {
                return context.Paciente.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paPacienteListar_Result> listarPa(string parametro)
        {
            using (var context = new NaturaEntities())
            {
                return context.paPacienteListar(parametro).ToList();
            }
        }
    }
}

