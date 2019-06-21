using System;
using System.Collections.Generic;
using FiguresBase.Figure;
using System.Xml.Serialization;

namespace FiguresBase.FileManager
{
    public class XMLSerializer : AbstractSerializer
    {
        public override IEnumerable<AbstractFigure> OpenFiles(string fileName)
        {
            throw new NotImplementedException();
        }

        public override void SaveFiles(string filePath, IEnumerable<AbstractFigure> figuresOnDesk)
        {
            throw new NotImplementedException();
        }
    }
}
