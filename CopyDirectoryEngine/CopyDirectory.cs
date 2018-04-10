using CopyDirectoryEngine.Concretes;
using CopyDirectoryEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDirectoryEngine
{
    public class DirectoryCopyEngine
    {
        public bool StartCopy(string fromDirectory, string toDirectory, IProgress progress)
        {
            IDirectoryCopy directorCopier = new DirectoryCopier(progress);

            try
            {
                directorCopier.CopyFromDirectory(fromDirectory, toDirectory);
                return true;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
