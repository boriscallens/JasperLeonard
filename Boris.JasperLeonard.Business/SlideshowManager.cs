using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Boris.JasperLeonard.Business
{
    public class SlideshowManager
    {
        private readonly string slideshowsPath;
        public List<string> SlideshowNames { get; set; }

        public SlideshowManager(string slideshowsPath)
        {
            this.slideshowsPath = slideshowsPath;
            InitializeShows();
        }

        public IEnumerable<string> GetImageNames(string showname)
        {
            var showDir = new DirectoryInfo(Path.Combine(slideshowsPath, showname));

            if (!showDir.Exists) { return new List<string>(); }

            var images = showDir.GetFiles("*.jpg");
            return images.Select(i => i.Name).ToList();
        }

        private void InitializeShows()
        {
            var showDir = new DirectoryInfo(slideshowsPath);
            if (!showDir.Exists) { return; }

            SlideshowNames = showDir.GetDirectories().Select(d => d.Name).ToList();
        }
    }
}
