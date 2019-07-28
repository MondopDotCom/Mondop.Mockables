using Mondop.Guard;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Mondop.Mockables
{
    public class DirectoryInfoImplementation: FileSystemInfoImplementation, IDirectoryInfo
    {
        private readonly DirectoryInfo _directoryInfo;

        public DirectoryInfoImplementation(DirectoryInfo directoryInfo)
            : base(directoryInfo)
        {
            _directoryInfo = Ensure.IsNotNull(directoryInfo, nameof(directoryInfo));
        }

        public IDirectoryInfo Parent => _directoryInfo.Parent.ToImplementation();
        public string Name => _directoryInfo.Name;
        public bool Exists => _directoryInfo.Exists;
        public IDirectoryInfo Root => _directoryInfo.Root.ToImplementation();

        public void Create()
        {
            _directoryInfo.Create();
        }

        public IDirectoryInfo CreateSubdirectory(string path)
        {
            return _directoryInfo.CreateSubdirectory(path).ToImplementation();
        }

        public void Delete(bool recursive)
        {
            _directoryInfo.Delete(true);
        }

        public void Delete()
        {
            _directoryInfo.Delete();
        }

        public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption)
        {
            return _directoryInfo.EnumerateDirectories(searchPattern, searchOption).Select(x => x.ToImplementation());
        }

        public IEnumerable<IDirectoryInfo> EnumerateDirectories()
        {
            return _directoryInfo.EnumerateDirectories().Select(x => x.ToImplementation());
        }

        public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern)
        {
            return _directoryInfo.EnumerateDirectories(searchPattern).Select(x => x.ToImplementation());
        }

        public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption)
        {
            return _directoryInfo.EnumerateFiles(searchPattern, searchOption).Select(x => x.ToImplementation());
        }

        public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern)
        {
            return _directoryInfo.EnumerateFiles(searchPattern).Select(x => x.ToImplementation());
        }

        public IEnumerable<IFileInfo> EnumerateFiles()
        {
            return _directoryInfo.EnumerateFiles().Select(x => x.ToImplementation());
        }

        public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption)
        {
            return _directoryInfo.EnumerateFileSystemInfos(searchPattern, searchOption).Select(x => x.ToImplementation());
        }

        public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern)
        {
            return _directoryInfo.EnumerateFileSystemInfos(searchPattern).Select(x => x.ToImplementation());
        }

        public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos()
        {
            return _directoryInfo.EnumerateFileSystemInfos().Select(x => x.ToImplementation());
        }

        public IDirectoryInfo[] GetDirectories()
        {
            return _directoryInfo.GetDirectories().Select(x => x.ToImplementation()).ToArray();
        }

        public IDirectoryInfo[] GetDirectories(string searchPattern)
        {
            return _directoryInfo.GetDirectories(searchPattern).Select(x => x.ToImplementation()).ToArray();
        }

        public IDirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption)
        {
            return _directoryInfo.GetDirectories(searchPattern,searchOption).Select(x => x.ToImplementation()).ToArray();
        }

        public IFileInfo[] GetFiles()
        {
            return _directoryInfo.GetFiles().Select(x => x.ToImplementation()).ToArray();
        }

        public IFileInfo[] GetFiles(string searchPattern, SearchOption searchOption)
        {
            return _directoryInfo.GetFiles(searchPattern,searchOption).Select(x => x.ToImplementation()).ToArray();
        }

        public IFileInfo[] GetFiles(string searchPattern)
        {
            return _directoryInfo.GetFiles(searchPattern).Select(x => x.ToImplementation()).ToArray();
        }

        public IFileSystemInfo[] GetFileSystemInfos()
        {
            return _directoryInfo.GetFileSystemInfos().Select(x => x.ToImplementation()).ToArray();
        }

        public IFileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption)
        {
            return _directoryInfo.GetFileSystemInfos(searchPattern,searchOption).Select(x => x.ToImplementation()).ToArray();
        }

        public IFileSystemInfo[] GetFileSystemInfos(string searchPattern)
        {
            return _directoryInfo.GetFileSystemInfos(searchPattern).Select(x => x.ToImplementation()).ToArray();
        }

        public void MoveTo(string destDirName)
        {
            _directoryInfo.MoveTo(destDirName);
        }
    }
}
