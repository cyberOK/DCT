using System;
using FiguresForm;
using FiguresBase.FileManager;
using System.Collections.Generic;
using FiguresBase.Figure;

namespace Presenter
{
    public class MainPresenter
    {
        private readonly IFiguresForm figuresForm;
        private readonly IFileManager fileManager;

        public MainPresenter(IFiguresForm form, IFileManager fileManager)
        {
            this.figuresForm = form;
            this.fileManager = fileManager;

            form.FileOpenClick += Form_FileOpenClick;
            form.FileSaveClick += Form_FileSaveClick;
        }

        private void Form_FileSaveClick(object sender, EventArgs e)
        {
            string fileName = figuresForm.FilePath;
            IEnumerable<AbstractFigure> figuresOnDesk = figuresForm.FiguresOnDesk;

            fileManager.SaveGame(fileName, figuresOnDesk);
        }

        private void Form_FileOpenClick(object sender, EventArgs e)
        {
            string fileName = figuresForm.FilePath;

            figuresForm.FiguresOnDesk = fileManager.GetSaveGame(fileName);
        }
    }
}
