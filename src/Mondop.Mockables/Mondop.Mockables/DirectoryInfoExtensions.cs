using System.IO;

namespace Mondop.Mockables
{
    public static class DirectoryInfoExtensions
    {
        public static DirectoryInfoImplementation ToImplementation(this DirectoryInfo directoryInfo)
        {
            return new DirectoryInfoImplementation(directoryInfo);
        }
    }
}
