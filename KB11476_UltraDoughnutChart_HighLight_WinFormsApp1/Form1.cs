using Infragistics.Win.DataVisualization;
using System.Data;

namespace KB11476_UltraDoughnutChart_HighLight_WinFormsApp1;

public partial class Form1 : Form
{
    private List<SampleDataItem> _sampleDataItems;
    private BrushCollection _defaultSliceBrushes = new BrushCollection();
    private BrushCollection _lowlightSliceBrushes = new BrushCollection() { Color.LightGray };

    public Form1()
    {
        InitializeComponent();

        this._sampleDataItems = new()
        {
            new (){Category = "Category 1", Value = 300},
            new (){Category = "Category 2", Value = 300},
            new (){Category = "Category 3", Value = 200},
            new (){Category = "Category 4", Value = 200},
            new (){Category = "Category 5", Value = 100},
        };
        this.ultraDoughnutChart1.SliceClick += UltraDoughnutChart1_SliceClick;
    }

    private void UltraDoughnutChart1_SliceClick(object sender, DoughnutSliceClickEventArgs e)
    {
        var dataVisualizationArgs = e as Infragistics.Win.DataVisualization.SliceClickEventArgs;
        if (dataVisualizationArgs == null) return;

        if (dataVisualizationArgs.IsSelected)
        {
            e.Series.Brushes = this._lowlightSliceBrushes;
        }
        else
        {
            e.Series.Brushes = this._defaultSliceBrushes;
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        var ringSeries = new RingSeries()
        {
            DataSource = this._sampleDataItems,
            LabelMemberPath = "Category",
            ValueMemberPath = "Value",
            StartAngle = 270,

            // çÄñ⁄ëIëéûÇÃêFÇÃê›íË
            SelectedStyle = new Style()
            {
                Fill = Color.OrangeRed
            }
        };
        this.ultraDoughnutChart1.Series.Add(ringSeries);

        foreach (var brush in ringSeries.Brushes)
        {
            this._defaultSliceBrushes.Add(brush);
        }
    }
}
