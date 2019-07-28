using System;
using System.IO;

namespace Mondop.Mockables
{
    public interface IFileSystemInfo
    {
        DateTime LastWriteTime { get; set; }
        DateTime LastAccessTimeUtc { get; set; }
        DateTime LastAccessTime { get; set; }
        DateTime CreationTimeUtc { get; set; }
        DateTime CreationTime { get; set; }
        string Extension { get; }
        DateTime LastWriteTimeUtc { get; set; }
        string FullName { get; }
        FileAttributes Attributes { get; set; }

        // Implement later
        // void GetObjectData(SerializationInfo info, StreamingContext context);
        void Refresh();
    }
}
