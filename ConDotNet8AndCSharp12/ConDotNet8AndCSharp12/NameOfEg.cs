using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConDotNet8AndCSharp12
{
    public class NameOfEg
    {
        public string SampleText { get; set; } = string.Empty;
        public int SampleInt { get; set; }
        public Pie MyPie { get; set; }

        public const string NameOfSampleTextLength = nameof(SampleText.Length);
        public const string NameOfSampleIntMaxValue = nameof(SampleInt.MaxValue);
        public const string t = nameof(Pie.Name);

        [Description($"String {nameof(SampleText.Length)}")]
        public int StringLength(string s)
        {
            return s.Length;
        }
    }
}
