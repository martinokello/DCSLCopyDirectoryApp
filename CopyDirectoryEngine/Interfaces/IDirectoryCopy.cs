using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDirectoryEngine.Interfaces
{
    public interface IDirectoryCopy
    {
        void CopyFromDirectory(string sourceDirectory, string destinationDirectory);
    }
}
