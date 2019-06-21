using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresBase.FileManager
{
    public class ExtentionDefinder
    {
        public AbstractSerializer CreateSerializerByExtention(string extention)
        {
            switch (extention)
            {
                case ".dat":
                    return new BinnarySerializer();
                case ".xml":
                    return new XMLSerializer();
                case ".json":
                    return new JsonSerializer();
                default:
                    throw new Exception("Don't find save format");
            }
        }
    }
}
