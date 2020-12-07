using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace TreeViewXamarin
{
    #region Folder

    [Preserve(AllMembers = true)]
    public class Folder : INotifyPropertyChanged
    {
        #region Fields

        private string fileName;
        private ObservableCollection<SubFolder> files;

        #endregion

        #region Constructor
        public Folder()
        {
        }

        #endregion

        #region Properties
        public ObservableCollection<SubFolder> SubFolder
        {
            get { return files; }
            set
            {
                files = value;
                RaisedOnPropertyChanged("SubFolder");
            }
        }

        public string FileName
        {
            get { return fileName; }
            set
            {
                fileName = value;
                RaisedOnPropertyChanged("FileName");
            }
        }
        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }

        #endregion
    }
    #endregion

    #region SubFolder

    [Preserve(AllMembers = true)]
    public class SubFolder : INotifyPropertyChanged
    {
        #region Fields

        private string fileName;
        private ObservableCollection<File> files;

        #endregion

        #region Constructor
        public SubFolder()
        {
        }

        #endregion

        #region Properties
        public ObservableCollection<File> Files
        {
            get { return files; }
            set
            {
                files = value;
                RaisedOnPropertyChanged("Files");
            }
        }

        public string FileName
        {
            get { return fileName; }
            set
            {
                fileName = value;
                RaisedOnPropertyChanged("FileName");
            }
        }
        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }

        #endregion
    }

    #endregion

    #region File

    [Preserve(AllMembers = true)]
    public class File : INotifyPropertyChanged
    {
        #region Fields

        private string fileName;
        private ObservableCollection<SubFile> subFiles;

        #endregion

        #region Constructor
        public File()
        {
        }

        #endregion

        #region Properties
        public ObservableCollection<SubFile> SubFiles
        {
            get { return subFiles; }
            set
            {
                subFiles = value;
                RaisedOnPropertyChanged("SubFiles");
            }
        }

        public string FileName
        {
            get { return fileName; }
            set
            {
                fileName = value;
                RaisedOnPropertyChanged("FileName");
            }
        }
        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }

        #endregion
    }
    #endregion

    #region SubFile

    [Preserve(AllMembers = true)]
    public class SubFile : INotifyPropertyChanged
    {
        #region Fields

        private string fileName;
        #endregion

        #region Constructor
        public SubFile()
        {
        }

        #endregion

        #region Properties

        public string FileName
        {
            get { return fileName; }
            set
            {
                fileName = value;
                RaisedOnPropertyChanged("FolderName");
            }
        }
        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }

        #endregion
    }
    #endregion
}