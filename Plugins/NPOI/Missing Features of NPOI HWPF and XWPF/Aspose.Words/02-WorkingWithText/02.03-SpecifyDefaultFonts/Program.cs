﻿using Aspose.Words;
using Aspose.Words.Fonts;

namespace _02._03_SpecifyDefaultFonts
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document("../../data/document.doc");

            // If the default font defined here cannot be found during rendering then the closest font on the machine is used instead.
            FontSettings.DefaultInstance.SubstitutionSettings.DefaultFontSubstitution.DefaultFontName = "Courier New";

            // Now the set default font is used in place of any missing fonts during any rendering calls.
            doc.Save("SpecifyDefaultFonts.pdf");
            doc.Save("SpecifyDefaultFonts.xps");
        }
    }
}
