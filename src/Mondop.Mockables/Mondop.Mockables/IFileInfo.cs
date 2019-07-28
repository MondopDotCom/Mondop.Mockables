namespace Mondop.Mockables
{
    public interface IFileInfo: IFileSystemInfo
    {
        IDirectoryInfo Directory { get; }
        string DirectoryName { get; }
        long Length { get; }
        string Name { get; }
        bool IsReadOnly { get; set; }
        bool Exists { get; }

        //StreamWriter AppendText();
        IFileInfo CopyTo(string destFileName);
        IFileInfo CopyTo(string destFileName, bool overwrite);
        //FileStream Create();
        //StreamWriter CreateText();

#if !NETSTANDARD1_3
        void Decrypt();
        void Encrypt();
        IFileInfo Replace(string destinationFileName, string destinationBackupFileName);
        IFileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors);
#endif
        void Delete();

        //FileSecurity GetAccessControl();
        //FileSecurity GetAccessControl(AccessControlSections includeSections);
        void MoveTo(string destFileName);
        //FileStream Open(FileMode mode);
        //FileStream Open(FileMode mode, FileAccess access, FileShare share);
        //FileStream Open(FileMode mode, FileAccess access);
        //FileStream OpenRead();
        //StreamReader OpenText();
        //FileStream OpenWrite();
        //void SetAccessControl(FileSecurity fileSecurity);
    }
}
