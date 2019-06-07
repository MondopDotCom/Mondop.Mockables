using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Mondop.Mockables
{
    public class FileImplementation : IFile
    {
        public void Copy(string sourceFileName, string destFileName) => File.Copy(sourceFileName, destFileName);
        public void Copy(string sourceFileName, string destFileName, bool overwrite) => File.Copy(sourceFileName, destFileName, overwrite);
        public void Move(string sourceFileName, string destFileName) => File.Move(sourceFileName, destFileName);
        public void Delete(string path) => File.Delete(path);
        public bool Exists(string path) => File.Exists(path);

        public FileAttributes GetAttributes(string path) => File.GetAttributes(path);
        public DateTime GetCreationTime(string path) => File.GetCreationTime(path);
        public DateTime GetCreationTimeUtc(string path) => File.GetCreationTimeUtc(path);
        public DateTime GetLastAccessTime(string path) => File.GetLastAccessTime(path);
        public DateTime GetLastAccessTimeUtc(string path) => File.GetLastAccessTimeUtc(path);
        public DateTime GetLastWriteTime(string path) => File.GetLastWriteTime(path);
        public DateTime GetLastWriteTimeUtc(string path) => File.GetLastWriteTimeUtc(path);

        public void SetAttributes(string path, FileAttributes fileAttributes) => File.SetAttributes(path, fileAttributes);
        public void SetCreationTime(string path, DateTime creationTime) => File.SetCreationTime(path, creationTime);
        public void SetCreationTimeUtc(string path, DateTime creationTimeUtc) => File.SetCreationTimeUtc(path, creationTimeUtc);
        public void SetLastAccessTime(string path, DateTime lastAccessTime) => File.SetLastAccessTime(path, lastAccessTime);
        public void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc) => File.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
        public void SetLastWriteTime(string path, DateTime lastWriteTime) => File.SetLastWriteTime(path, lastWriteTime);
        public void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc) => File.SetLastWriteTimeUtc(path, lastWriteTimeUtc);

        public byte[] ReadAllBytes(string path) => File.ReadAllBytes(path);
        public string[] ReadAllLines(string path) => File.ReadAllLines(path);
        public string[] ReadAllLines(string path, Encoding encoding) => File.ReadAllLines(path, encoding);
        public string ReadAllText(string path) => File.ReadAllText(path);
        public string ReadAllText(string path, Encoding encoding) => File.ReadAllText(path, encoding);
        public IEnumerable<string> ReadLines(string path) => File.ReadLines(path);
        public IEnumerable<string> ReadLines(string path, Encoding encoding) => File.ReadLines(path, encoding);

        public void AppendAllLines(string path, IEnumerable<string> contents) => File.AppendAllLines(path, contents);
        public void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding) => File.AppendAllLines(path, contents, encoding);
        public void AppendAllText(string path, string contents) => AppendAllText(path, contents);
        public void AppendAllText(string path, string contents, Encoding encoding) => File.AppendAllText(path, contents, encoding);

        public void WriteAllBytes(string path, byte[] bytes) => File.WriteAllBytes(path, bytes);
        public void WriteAllLines(string path, IEnumerable<string> contents) => File.WriteAllLines(path, contents);
        public void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding) => File.WriteAllLines(path, contents, encoding);
        public void WriteAllText(string path, string contents) => File.WriteAllText(path, contents);
        public void WriteAllText(string path, string contents, Encoding encoding) => File.WriteAllText(path, contents, encoding);
    }
}
