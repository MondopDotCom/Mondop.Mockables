using System.IO;

namespace Mondop.Mockables
{
    public static class FileSystemInfoExtensions
    {
        public static FileSystemInfoImplementation ToImplementation(this FileSystemInfo fileSystemInfo)
        {
            return new FileSystemInfoImplementation(fileSystemInfo);
        }
    }
}
