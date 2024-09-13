using System;

namespace BibliographicalInheritance
{
    class Video : Resource
    {
        // PROPERTY
        public string Director { get; set; }
        public int Runtime { get; set; }
        public string MediaType { get; set; }

        // CONSTRUCTOR
        public Video(string title, string director, string category, int runtime, string mediaType) : base(title, category)
        {
            Director = director;
            Runtime = runtime;
            MediaType = mediaType;
        }

        // METHOD OVERRIDE
        public override void GetInfo()
        {
            Console.WriteLine($"TITLE: {Title}\nCATEGORY: {Category}\nSTATUS: {Status}\nDIRECTOR: {Director}\nRUNTIME: {Runtime}");
        }
    }
}
