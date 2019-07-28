using Mondop.Guard;
using System;
using System.IO;

namespace Mondop.Mockables
{
    public class FileSystemInfoImplementation: IFileSystemInfo
    {
        private readonly FileSystemInfo _fileSystemInfo;

        public FileSystemInfoImplementation(FileSystemInfo fileSystemInfo)
        {
            _fileSystemInfo = Ensure.IsNotNull(fileSystemInfo, nameof(fileSystemInfo));
        }

        public DateTime LastWriteTime { get => _fileSystemInfo.LastWriteTime; set => _fileSystemInfo.LastWriteTime = value; }
        public DateTime LastAccessTimeUtc { get => _fileSystemInfo.LastAccessTimeUtc; set => _fileSystemInfo.LastAccessTimeUtc = value; }
        public DateTime LastAccessTime { get => _fileSystemInfo.LastAccessTime; set => _fileSystemInfo.LastAccessTime = value; }
        public DateTime CreationTimeUtc { get => _fileSystemInfo.CreationTimeUtc; set => _fileSystemInfo.CreationTimeUtc = value; }
        public DateTime CreationTime { get => _fileSystemInfo.CreationTime; set => _fileSystemInfo.CreationTime = value; }
        public string Extension => _fileSystemInfo.Extension;
        public DateTime LastWriteTimeUtc { get => _fileSystemInfo.LastWriteTimeUtc; set => _fileSystemInfo.LastWriteTimeUtc = value; }
        public string FullName => _fileSystemInfo.FullName;
        public FileAttributes Attributes { get => _fileSystemInfo.Attributes; set => _fileSystemInfo.Attributes = value; }
        public void Refresh()
        {
            _fileSystemInfo.Refresh();
        }
    }
}
