using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace ChartSample
{
    public class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<ChartModel> categoryData;
        public ObservableCollection<ChartModel> CategoryData
        {
            get { return categoryData; }
            set
            {
                categoryData = value;
                RaisePropertyChanged(nameof(CategoryData));
            }
        }

        public ViewModel()
        {
            CategoryData = new ObservableCollection<ChartModel>()
            {
                new ChartModel()
                {
                    Month = "Jan",
                    Data = new Model() { YValue = new double[] { 28, 12 }, Products = new Product(){ ProductA = 15, ProductB = 18 } }
                },
                
                new ChartModel()
                {
                    Month = "Feb",
                    Data = new Model() { YValue = new double[] { 18 , 20 }, Products = new Product(){ ProductA = 12, ProductB = 28 } }
                },

                new ChartModel()
                {
                    Month = "Mar",
                    Data = new Model() { YValue = new double[] { 22, 24 }, Products = new Product(){ ProductA = 15, ProductB = 18 } }
                },

                new ChartModel()
                {
                    Month = "Apr",
                    Data = new Model() { YValue = new double[] { 16, 18 }, Products = new Product(){ ProductA = 8, ProductB = 14 } }
                },

                new ChartModel()
                {
                    Month = "May",
                    Data = new Model() { YValue = new double[] { 32, 28 }, Products = new Product(){ ProductA = 22, ProductB = 28 } }
                },

                new ChartModel()
                {
                    Month = "Jun",
                    Data = new Model() { YValue = new double[] { 30, 23 }, Products = new Product(){ ProductA = 18, ProductB = 24 } }
                },
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void RaisePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
