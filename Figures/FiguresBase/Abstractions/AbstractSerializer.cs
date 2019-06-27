using System.Collections.Generic;

namespace FiguresBase
{
    public abstract class AbstractSerializer
    {
        public abstract IEnumerable<AbstractFigure> OpenFiles(string filePath);

        public abstract void SaveFiles(string filePath, List<AbstractFigure> figuresOnDesk);
    }
}
