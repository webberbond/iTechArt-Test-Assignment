using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;

namespace CsvParser
{
    [Serializable]
    class Players
    {
        [CsvColumn(Name = "Rank", FieldIndex = 1)]
        public int Rank { get; set; }

        [CsvColumn(Name = "Name", FieldIndex = 2)]
        public string Name { get; set; }

        [CsvColumn(Name = "Title", FieldIndex = 3)]
        public string Title { get; set; }

        [CsvColumn(Name = "Country", FieldIndex = 4)]
        public string Country { get; set; }

        [CsvColumn(Name = "Rating", FieldIndex = 5)]
        public int Rating { get; set; }

        [CsvColumn(Name = "Games", FieldIndex = 6)]
        public int Games { get; set; }

        [CsvColumn(Name = "B-Year,", FieldIndex = 7)]
        public int B_Year { get; set; }
    }
}
