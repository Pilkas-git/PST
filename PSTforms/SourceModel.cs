using System.Collections.Generic;

namespace PST
{
    public class SourceCollection
    {
        public List<Source> Sources { get; set; }
    }

    public class Source
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
