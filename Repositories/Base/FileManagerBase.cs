using System.Collections.Generic;

namespace ArredondoPalomino_GabrielGiovani.Repositories.Base
{
    internal abstract class FileManagerBase<T>
    {
        private readonly string _pathFile;

        public FileManagerBase(string pathFile)
        {
            _pathFile = pathFile;
        }

        internal abstract IEnumerable<T> ReadFile();

        internal abstract void AppendFile(T entity);
    }
}
