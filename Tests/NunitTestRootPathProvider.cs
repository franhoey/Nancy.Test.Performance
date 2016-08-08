using System.IO;
using System.Linq;
using Nancy;
using NUnit.Framework;

namespace Tests
{
    public class NunitTestRootPathProvider : IRootPathProvider
    {
        private static string _cachedRootPath;

        private string TestDirectoryFromNUnit
            => TestContext.CurrentContext.TestDirectory;

        public string GetRootPath()
        {
            if (!string.IsNullOrEmpty(_cachedRootPath))
                return _cachedRootPath;

            _cachedRootPath = GetViewsRootPath(
                TestDirectoryFromNUnit);

            return _cachedRootPath;
        }

        private static string GetViewsRootPath(string executingPath)
        {
            var rootPath = string.Empty;

            var currentDirectory = new DirectoryInfo(executingPath);

            bool rootPathFound = false;
            while (!rootPathFound)
            {
                var directoriesContainingViewFolder = currentDirectory.GetDirectories(
                          "Views", SearchOption.AllDirectories);
                if (directoriesContainingViewFolder.Any())
                {
                    rootPath = directoriesContainingViewFolder.First().FullName;
                    rootPathFound = true;
                }

                currentDirectory = currentDirectory.Parent;
            }

            return rootPath;
        }
    }
}