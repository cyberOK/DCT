using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace FiguresBase.Serializators
{
    public class XMLSerialize : AbstractSerializer
    {
        private XmlSerializer formatter;

        public XMLSerialize()
        {
            this.formatter = new XmlSerializer(typeof(List<AbstractFigure>));
        }

        public override IEnumerable<AbstractFigure> OpenFiles(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                IEnumerable<AbstractFigure> loadMovement = (IEnumerable<AbstractFigure>)formatter.Deserialize(fs);
                return loadMovement;
            }
        }

        public override void SaveFiles(string filePath, List<AbstractFigure> figuresOnDesk)
        {
            using (FileStream fs = new FileStream(filePath,FileMode.OpenOrCreate))
            {
                this.formatter.Serialize(fs, figuresOnDesk);
            }
        }
    }
}
