using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using FiguresBase.Abstractions;

namespace FiguresBase.Serializators
{
    public class XMLSerialize
    {
        XMLSerializer formatter;

        public XMLSerializer()
        {
            this.formatter = new XMLSerializer();
        }

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
