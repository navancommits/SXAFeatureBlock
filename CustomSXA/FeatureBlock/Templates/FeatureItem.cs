using Sitecore.Data;
using System.Runtime.InteropServices;

namespace CustomSXA.Feature.CustomRenderings.Templates
{
    public static class Data
    {
        [StructLayout(LayoutKind.Sequential, Size = 1)]
        public struct FeatureItem
        {
            public static readonly ID ID = ID.Parse("");

            [StructLayout(LayoutKind.Sequential, Size = 1)]
            public struct Fields
            {
                public static ID Title { get; } = new ID("");

                public static ID Description { get; } = new ID("");

                public static ID Blurb { get; } = new ID("");

                public static ID Image { get; } = new ID("");

                public static ID Url { get; } = new ID("");
            }
        }
    }
}


   
