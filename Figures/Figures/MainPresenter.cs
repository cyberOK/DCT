using System;
using System.Collections.Generic;
using FiguresBase.FileManager;
using FiguresBase.Figure;

namespace FiguresForm
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
