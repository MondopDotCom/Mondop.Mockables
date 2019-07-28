using System.Collections.Generic;
using System.IO;

namespace Mondop.Mockables
{
    public interface IDirectoryInfo: IFileSystemInfo
    {
        //public DirectoryInfo(string path);
        IDirectoryInfo Parent { get; }
        string Name { get; }
        bool Exists { get; }
        IDirectoryInfo Root { get; }
        void Create();

        // DirectorySecurity not available in .Net standard
        //void Create(IDirectorySecurity directorySecurity);
        IDirectoryInfo CreateSubdirectory(string path);

        // DirectorySecurity not available in .Net standard
        //IDirectoryInfo CreateSubdirectory(string path, IDirectorySecurity directorySecurity);
        void Delete(bool recursive);
        void Delete();
        IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption);
        IEnumerable<IDirectoryInfo> EnumerateDirectories();
        IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern);
        IEnumerable<IFileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption);
        IEnumerable<IFileInfo> EnumerateFiles(string searchPattern);
        IEnumerable<IFileInfo> EnumerateFiles();
        IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption);
        IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern);
        IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos();

        // Exclude this method Enum DirectorySecurity not avialable in .Net standard
        //IDirectorySecurity GetAccessControl();
        // Exclude this method Enum AccessControlSections not avialable in .Net standard
        //IDirectorySecurity GetAccessControl(AccessControlSections includeSections);
        IDirectoryInfo[] GetDirectories();
        IDirectoryInfo[] GetDirectories(string searchPattern);
        IDirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption);
        IFileInfo[] GetFiles();
        IFileInfo[] GetFiles(string searchPattern, SearchOption searchOption);
        IFileInfo[] GetFiles(string searchPattern);
        IFileSystemInfo[] GetFileSystemInfos();
        IFileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption);
        IFileSystemInfo[] GetFileSystemInfos(string searchPattern);
        void MoveTo(string destDirName);

        // Exclude this method Enum DirectorySecurity not avialable in .Net standard
        //void SetAccessControl(IDirectorySecurity directorySecurity);
    }
}
