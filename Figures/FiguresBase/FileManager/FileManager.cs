using System;
using System.Collections.Generic;
using FiguresBase.Serializators;

namespace FiguresBase.FileManager
{
    public interface IFileManager
    {
        IEnumerable<AbstractFigure> GetSaveGame(string filePath);
        void SaveGame(string fileName, List<AbstractFigure> figuresOnDesk);
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
            IEnumerable<AbstractFigure> loadGame;

            string fileExtension = this.GetFileExtention(fileName);

            try
            {
                this.serializer = this.CreateSerializerByExtention(fileExtension);
                loadGame = this.serializer.OpenFiles(fileName);
                return loadGame;
            }
            catch (Exception e) // Need to complete this
            {
                throw e;
            }
        }

        public void SaveGame(string fileName, List<AbstractFigure> figuresOnDesk)
        {
            string fileExtention = this.GetFileExtention(fileName);

            try
            {
                this.serializer = this.CreateSerializerByExtention(fileExtention);
                this.serializer.SaveFiles(fileName, figuresOnDesk);
            }
            catch (Exception e) // Need to complete this
            {
                throw e;
            }
        }

        private string GetFileExtention(string fileWithExtention)
        {
            int dotIndex = fileWithExtention.IndexOf('.');
            string extention = fileWithExtention.Substring(dotIndex);
            return extention;
        }

        private AbstractSerializer CreateSerializerByExtention(string extention)
        {
            switch (extention)
            {
                case ".dat":
                    return new BinnarySerializer();
                case ".xml":
                    return new XMLSerialize();
                case ".json":
                    return new JsonSerializer();
                default:
                    throw new Exception("Don't define save format");
            }
        }
    }
}
