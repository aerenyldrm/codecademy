using System;

namespace BibliographicalInheritance
{
    class Periodical : Resource
    {
        // PROPERTY
        public string Period { get; set; }

        // CONSTRUCTOR
        public Periodical(string title, string category, string period) : base(title, category)
        {
            Period = period;
        }

        // METHOD OVERRIDE
        public override void UpdateStatus()
        {
            Status = Status == "Available" ? "In-utilization" : "Available";
        }
    }
}
