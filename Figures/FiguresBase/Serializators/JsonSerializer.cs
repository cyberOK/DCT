using System;
using System.Collections.Generic;
using System.IO;
using FiguresBase.Figures;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace FiguresBase.Serializators
{
    public class JsonSerializer : AbstractSerializer
    {
        private DataContractJsonSerializer jsonFormatter;

        public JsonSerializer()
        {
            jsonFormatter = new DataContractJsonSerializer(typeof(List<AbstractFigure>));
        }

        public override IEnumerable<AbstractFigure> OpenFiles(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                IEnumerable<AbstractFigure> loadMovement = (IEnumerable<AbstractFigure>)jsonFormatter.ReadObject(fs);
                return loadMovement;
            }
        }

        public override void SaveFiles(string filePath, List<AbstractFigure> figuresOnDesk)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs,figuresOnDesk);
            }
        }
    }
}
