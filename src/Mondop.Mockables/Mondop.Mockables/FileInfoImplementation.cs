using Mondop.Guard;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Mondop.Mockables
{
    public class FileInfoImplementation : FileSystemInfoImplementation, IFileInfo
    {
        private readonly FileInfo _fileInfo;

        public FileInfoImplementation(FileInfo fileInfo): base(fileInfo)
        {
            _fileInfo = Ensure.IsNotNull(fileInfo, nameof(fileInfo));
        }

        public IDirectoryInfo Directory => _fileInfo.Directory.ToImplementation();

        public string DirectoryName => _fileInfo.DirectoryName;

        public long Length => _fileInfo.Length;

        public string Name => _fileInfo.Name;

        public bool IsReadOnly { get => _fileInfo.IsReadOnly; set => _fileInfo.IsReadOnly = true; }

        public bool Exists => _fileInfo.Exists;

        public IFileInfo CopyTo(string destFileName)
        {
            return _fileInfo.CopyTo(destFileName).ToImplementation();
        }

        public IFileInfo CopyTo(string destFileName, bool overwrite)
        {
            return _fileInfo.CopyTo(destFileName, overwrite).ToImplementation();
        }

        public void Delete()
        {
            _fileInfo.Delete();
        }

        public void MoveTo(string destFileName)
        {
            _fileInfo.MoveTo(destFileName);
        }

#if !NETSTANDARD1_3
        public void Decrypt()
        {
            _fileInfo.Decrypt();
        }

        public void Encrypt()
        {
            _fileInfo.Encrypt();
        }

        public IFileInfo Replace(string destinationFileName, string destinationBackupFileName)
        {
            return _fileInfo.Replace(destinationFileName, destinationBackupFileName).ToImplementation();
        }

        public IFileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
        {
            return _fileInfo.Replace(destinationFileName, destinationBackupFileName, ignoreMetadataErrors).ToImplementation();
        }
#endif
    }
}
