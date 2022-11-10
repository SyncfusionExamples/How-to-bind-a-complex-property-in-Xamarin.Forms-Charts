# How to bind a complex property in Xamarin.Forms Charts

The following example demonstrates how to bind a [Xamarin.Forms Chart](https://www.syncfusion.com/xamarin-ui-controls/xamarin-charts) using a complex data path with dots.

Complex property binding is used to access the nested object property value to chart series in [Xamarin.Forms SfChart](https://help.syncfusion.com/xamarin/charts/getting-started). The following code example considers the use case of binding the datapoint to chart for the same XValue and different YValue for each series with the same data collection.

You can bind the complex property by using a dot for nested object property value in Xamarin.Forms SfChart as shown in the following code example.

```
<chart:SfChart.Series>                
    <chart:ColumnSeries ItemsSource="{Binding CategoryData}"
                        XBindingPath="Month" 
                        YBindingPath="Data.YValue[1]"
                        Label="Column">
    </chart:ColumnSeries>
 
    <chart:LineSeries ItemsSource="{Binding CategoryData}"
                      XBindingPath="Month" 
                      YBindingPath="Data.Products.ProductA"
                      Label="Product A">
    </chart:LineSeries>
 
    <chart:LineSeries ItemsSource="{Binding CategoryData}"
                      XBindingPath="Month" 
                      YBindingPath="Data.Products.ProductB"
                      Label="Product B">
    </chart:LineSeries>
</chart:SfChart.Series>
```

**ViewModel.cs**
```
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
```

**ChartModel.cs**
```
public class ChartModel : INotifyPropertyChanged
{
    private string x;
    public string X 
    {
        get { return x; }
        set 
        {
            x = value;
            RaisePropertyChanged(nameof(X));
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
    . . .
}
```

**Model.cs**
```
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
. . .
}
```

**Product.cs**
```
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
. . .
 
}
```
> **Note:**
> 
> This data binding method is entirely done in XAML, and no code-behind file is required.

## Output:

![Complex property binding to Xamarin.Forms SfChart](https://user-images.githubusercontent.com/53489303/200567338-dafaf2b8-8001-4af0-98e7-120a99ffc556.png)

KB article - [How to bind a complex property in Xamarin.Forms Charts](https://www.syncfusion.com/kb/12961/how-to-bind-a-complex-property-in-xamarin-forms-charts)
