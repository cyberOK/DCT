using System;
using System.Collections.Generic;
using FiguresBase.Figure;
using System.Runtime.Serialization.Json;

namespace FiguresBase.FileManager
{
    public class JsonSerializer : AbstractSerializer
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
