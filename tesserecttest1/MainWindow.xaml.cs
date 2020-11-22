using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tesseract;

namespace tesserecttest1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            Bitmap img = new Bitmap("C:\\Users\\Bikalpa\\Documents\\testdll\\testimage.png");
            TesseractEngine engine = new TesseractEngine("./tessdata", "eng", EngineMode.Default);
            Tesseract.Page page = engine.Process(img, PageSegMode.Auto);
            string result = page.GetText();
            MessageBox.Show(result);
        }
    }
}
