using ArredondoPalomino_GabrielGiovani.Repositories.Base;
using GestorAlumnos.Models;
using System.Collections.Generic;

namespace ArredondoPalomino_GabrielGiovani.Repositories
{
    internal class AlumnoTextRepository : FileManagerBase<Alumno>
    {
        public AlumnoTextRepository(string pathFile) : base(pathFile)
        {
        }

        internal override void AppendFile(Alumno entity)
        {
            throw new System.NotImplementedException();
        }

        internal override IEnumerable<Alumno> ReadFile()
        {
            throw new System.NotImplementedException();
        }
    }
}
