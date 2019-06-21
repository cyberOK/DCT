using FiguresBase.Figure;
using System;
using System.Collections.Generic;

namespace FiguresBase.FileManager
{
    public interface IFileManager
    {
        IEnumerable<AbstractFigure> GetSaveGame(string filePath);
        void SaveGame(string fileName, IEnumerable<AbstractFigure> figuresOnDesk);
    }

    public class FileManager:IFileManager
    {
        private AbstractSerializer serializer;

        public FileManager()
        {
            
        }

        public AbstractSerializer Serializer { get; }

        public IEnumerable<AbstractFigure> GetSaveGame(string fileName)
        {
            ExtentionDefinder definder = new ExtentionDefinder();
            IEnumerable<AbstractFigure> loadGame;

            string fileExtension = GetFileExtention(fileName);

            try
            {
                serializer = definder.CreateSerializerByExtention(fileExtension);
                loadGame = serializer.OpenFiles(fileName);
                return loadGame;
            }
            catch (Exception) // Need to complete this
            {

                throw;
            }
        }

        public void SaveGame(string fileName, IEnumerable<AbstractFigure> figuresOnDesk)
        {
            ExtentionDefinder definder = new ExtentionDefinder();

            string fileExtention = GetFileExtention(fileName);

            try
            {
                serializer = definder.CreateSerializerByExtention(fileExtention);
                serializer.SaveFiles(fileName, figuresOnDesk);
            }
            catch (Exception) // Need to complete this
            {

                throw;
            }

        }

        private string GetFileExtention(string fileWithExtention)
        {
            int dotIndex = fileWithExtention.IndexOf('.');
            string extention = fileWithExtention.Substring(dotIndex);
            return extention;
        }
    }
}
