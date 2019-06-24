using System;
using System.Collections.Generic;
using FiguresBase.Figure;

namespace FiguresBase.FileManager
{
    public abstract class AbstractSerializer
    {
        public abstract IEnumerable<AbstractFigure> OpenFiles(string filePath);
        public abstract void SaveFiles(string filePath, IEnumerable<AbstractFigure> figuresOnDesk);
    }
}
