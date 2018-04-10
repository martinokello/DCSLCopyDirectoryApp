using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using CopyDirectoryEngine.Interfaces;

namespace CopyDirectoryEngine.Concretes
{
    public class DirectoryCopier:IDirectoryCopy
    {
        private IProgress _progress;
        public DirectoryCopier(IProgress progress)
        {
            _progress = progress;

        }
        public void CopyFromDirectory(string sourceDirectory, string destinationDirectory)
        {
            var sourceInfo = new DirectoryInfo(sourceDirectory);
            var destinationInfo = new DirectoryInfo(destinationDirectory);
            const int byteSize = 4096;

            if (!sourceInfo.Exists || string.IsNullOrEmpty(destinationDirectory))
            {
                throw new Exception("Ensure both Source and Destination Directories Exist");
            }
            if (!destinationInfo.Exists)
            {
                destinationInfo.Create();
            }
            //copy:

            var sourceFileInfos = sourceInfo.GetFiles();

            foreach (var srcFileInfo in sourceFileInfos)
            {
                using (var fstream = srcFileInfo.OpenRead())
                {
                    var buffer = new byte[byteSize];
                    var bytesRead = 0;
                    while((bytesRead = fstream.Read(buffer, 0, byteSize)) > 0)
                    {
                        var dstFileInfo = new FileInfo(destinationInfo.FullName + "\\" + srcFileInfo.Name);
                        FileStream ostream = null;

                        if (!dstFileInfo.Exists) {
                            using (ostream = dstFileInfo.Create())
                            {
                                //can log creation
                            }
                        }
                        using (var ofileStream = dstFileInfo.OpenWrite())
                        {
                            ofileStream.Write(buffer, 0, bytesRead);
                        }
                    }
                }
            }

            var directories = sourceInfo.GetDirectories();
            const int units = 100;
            var prg = 1;

            foreach (var dirInfo in directories)
            {
                var prgResult = prg * units / directories.Length;
                var currentProgress = (_progress as OperationProgress).Progress;
                if (currentProgress + prgResult >= 100)
                {
                    (_progress as OperationProgress).Progress = 100;
                }
                else
                {
                    (_progress as OperationProgress).Progress = currentProgress + prgResult;
                }

                var destDirectory = destinationDirectory + "\\" + dirInfo.Name;
                prg += 1;
                CopyFromDirectory(dirInfo.FullName, destDirectory);
            }

        }


    }
}
