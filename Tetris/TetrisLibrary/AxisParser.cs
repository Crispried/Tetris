using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace TetrisLibrary
{
    public static class AxisParser
    {
        public static List<Axis> Parse(string pathToFile)
        {
            List<Axis> result = new List<Axis>();
            var xml = XDocument.Load(pathToFile);
            foreach (XElement el in xml.Root.Elements("axis"))
            {
                result.Add(new Axis(el.Value));
            }
            return result;
        }
    }
}
