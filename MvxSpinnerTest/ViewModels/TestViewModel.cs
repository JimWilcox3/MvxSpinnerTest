using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace MPS_Mobile_Driver.Droid.ViewModels
{
    public class TestViewModel
      : MvxViewModel
    {
        public void Init()
        {
            ObservableCollection<TestItem> t = new ObservableCollection<TestItem>();
            TestItem i = new TestItem() { TagColor = "Blue", TagLot = "123", InventoryNumber = "1" };
            t.Add(i);
            i = new TestItem() { TagColor = "Blue", TagLot = "123", InventoryNumber = "2" };
            t.Add(i);
            i = new TestItem() { TagColor = "Blue", TagLot = "123", InventoryNumber = "3" };
            t.Add(i);
            i = new TestItem() { TagColor = "Blue", TagLot = "123", InventoryNumber = "4" };
            t.Add(i);
            i = new TestItem() { TagColor = "Blue", TagLot = "123", InventoryNumber = "5" };
            t.Add(i);
            i = new TestItem() { TagColor = "Blue", TagLot = "123", InventoryNumber = "6" };
            t.Add(i);
            i = new TestItem() { TagColor = "Blue", TagLot = "123", InventoryNumber = "7" };
            t.Add(i);

            Items = t;        
        }



        private ObservableCollection<TestItem> _Items;
        public ObservableCollection<TestItem > Items
        {
            get
            {
                return _Items;
            }
            set
            {
                _Items = value;
                RaisePropertyChanged(() => Items);
            }
        }

    }

    public class TestItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        private string _TagColor;
        public string TagColor
        {
            get
            {
                return _TagColor;
            }
            set
            {
                _TagColor = value;
                this.RaisePropertyChanged("TagColor");
            }
        }

        private string _TagLot;
        public string TagLot
        {
            get
            {
                return _TagLot;
            }
            set
            {
                _TagLot = value;
                this.RaisePropertyChanged("TagLot");
            }
        }

        private string _InventoryNumber;
        public string InventoryNumber
        {
            get
            {
                return _InventoryNumber;
            }
            set
            {
                _InventoryNumber = value;
                this.RaisePropertyChanged("InventoryNumber");
            }
        }

        private static string[] _TagColors = { "Yellow", "Brown", "White", "Blue", "Orange", "Red", "Green", "Purple" };
        public string[] TagColors
        {
            get { return _TagColors; }
        }

    }
}