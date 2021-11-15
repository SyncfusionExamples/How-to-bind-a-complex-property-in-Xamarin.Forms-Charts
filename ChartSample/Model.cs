using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ChartSample
{
    public class ChartModel : INotifyPropertyChanged
    {
        private string month;
        public string Month 
        {
            get { return month; }
            set 
            {
                month = value;
                RaisePropertyChanged(nameof(Month));
            }
        }

        public Model data;
        public Model Data 
        {
            get { return data; }
            set
            {
                data = value;
                RaisePropertyChanged(nameof(Data));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void RaisePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

    public class Model : INotifyPropertyChanged
    {
        private double[] yValue;
        public double[] YValue
        {
            get { return yValue; }
            set
            {
                if (value != yValue)
                {
                    yValue = value;
                    RaisePropertyChanged(nameof(YValue));
                }
            }
        }

        private Product products;
        public Product Products
        {
            get { return products; }
            set
            {
                if (value != products)
                {
                    products = value;
                    RaisePropertyChanged(nameof(Products));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void RaisePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

    public class Product : INotifyPropertyChanged
    {
        private double productA;
        public double ProductA
        {
            get { return productA; }
            set
            {
                if (value != productA)
                {
                    productA = value;
                    RaisePropertyChanged(nameof(ProductA));
                }
            }
        }

        private double productB;
        public double ProductB
        {
            get { return productB; }
            set
            {
                if (value != productB)
                {
                    productB = value;
                    RaisePropertyChanged(nameof(ProductB));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void RaisePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
