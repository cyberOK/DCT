using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using FiguresBase.Figure;


namespace FiguresBase.FileManager
{
    public class BinnarySerializer : AbstractSerializer
    {
        private BinaryFormatter formatter;

        public BinnarySerializer()
        {
            this.formatter = new BinaryFormatter();
        }

        public override IEnumerable<AbstractFigure> OpenFiles(string filePath)
        {
            using(FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                IEnumerable<AbstractFigure> figuresByLoad = (IEnumerable<AbstractFigure>)this.formatter.Deserialize(fs);
                return figuresByLoad;
            }          
        }

        public override void SaveFiles(string filePath, IEnumerable<AbstractFigure> figuresOnDesk)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, figuresOnDesk);
            }
        }
    }
}
