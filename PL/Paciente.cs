using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Paciente
    {
        public static ML.Result  GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.HospitalEntities context = new DL.HospitalEntities())
                {
                    var query = context.PacienteGetAll();

                    if(query != null)
                    {

                        ML.Paciente paciente = new ML.Paciente();
                        foreach (var obj in query)
                        {
                            paciente.IdPaciente = obj.IdPaciente;
                            paciente.Nombre = obj.NombrePaciente;
                            paciente.ApellidoPaterno = obj.ApellidoPaterno;
                            paciente.ApellidoMaterno = obj.ApellidoMaterno;
                            paciente.FechaNacimeinto = obj.FechaNacimiento.ToString();
                            paciente.FechaIngreso = obj.FechaIngreso.ToString();
                            paciente.Sexo = obj.Sexo;
                            paciente.Sintomas = obj.Sintomas;
                            paciente.TipoSangre = new ML.TipoSangre();
                            paciente.TipoSangre.IdTipoSangre = obj.IdTipoSangre;
                            paciente.TipoSangre.Nombre = obj.NombreTipoSangre;

                            result.Objects.Add(paciente);
                            result.Correct = true;
                        }
                    }
                    else
                    {
                        result.ErrorMessage = "Ocurrio un error al realizar la consulta";
                        result.Correct = false;
                    }
                }
            }
            catch
            {
                result.Correct = false;
            }
            return result;
        }
    }
}
