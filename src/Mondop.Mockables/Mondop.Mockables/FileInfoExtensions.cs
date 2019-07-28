using System.IO;

namespace Mondop.Mockables
{
    public static class FileInfoExtensions
    {
        public static IFileInfo ToImplementation(this FileInfo fileInfo)
        {
            return new FileInfoImplementation(fileInfo);
        }
    }
}
