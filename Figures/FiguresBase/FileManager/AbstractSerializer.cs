using FiguresBase.Figure;
using System.Collections.Generic;

namespace FiguresBase.FileManager
{
    public abstract class AbstractSerializer
    {
        public abstract IEnumerable<AbstractFigure> OpenFiles(string filePath);
        public abstract void SaveFiles(string filePath, IEnumerable<AbstractFigure> figuresOnDesk);
    }
}
