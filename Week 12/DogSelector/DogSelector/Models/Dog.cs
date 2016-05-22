using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DogSelector.Models
{
    public enum EScale { Low, Medium, High, NoPreference}
    public enum ELength { Short, Medium, Long}
    public enum ESize { Miniature = 1, Small = 2, Medium = 3, Large = 4, Giant = 5}

    public class Dog
    {
        public string BreedName { get; set; }
        public string DisplayName { get; set; }
        public string ImageName { get; set; }
        public EScale ActivityLevel { get; set; }
        public EScale SheddingLevel { get; set; }
        public EScale GroomingLevel { get; set; }
        public EScale IntelligenceLevel { get; set; }
        public bool GoodWithChildren { get; set; }
        public bool Drools { get; set; }
        public ELength CoatLength { get; set; }
        public ESize Size { get; set; }
    }
}