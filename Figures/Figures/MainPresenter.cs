using System;
using System.Collections.Generic;
using FiguresBase;
using FiguresBase.FileManager;

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

            form.FileOpenClick += this.Form_FileOpenClick;
            form.FileSaveClick += this.Form_FileSaveClick;            
        }

        private void Form_FileSaveClick(object sender, EventArgs e)
        {
            string fileName = this.figuresForm.FilePath;
            List<AbstractFigure> figuresOnDesk = (List<AbstractFigure>)this.figuresForm.FiguresOnDesk;

            this.fileManager.SaveGame(fileName, figuresOnDesk);
        }

        private void Form_FileOpenClick(object sender, EventArgs e)
        {
            string fileName = this.figuresForm.FilePath;

            this.figuresForm.FiguresOnDesk = this.fileManager.GetSaveGame(fileName);
        }
    }
}
