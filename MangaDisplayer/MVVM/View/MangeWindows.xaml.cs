using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MangaDisplayer.MVVM.View
{
    /// <summary>
    /// MangeWindows.xaml 的交互逻辑
    /// </summary>
    public partial class MangeWindows : Window
    {
        Timer Timer;
        public MangeWindows()
        {
            InitializeComponent();
            //Timer = new (new TimerCallback())
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
            var bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.StreamSource = new System.IO.MemoryStream(File.ReadAllBytes(@"C:\Users\scixing\Pictures\野炊\ゼルダの伝説　ティアーズ オブ ザ キングダム _ Nintendo Switch _ 任天堂_files\sp_bg_layer1.jpg"));
            bitmap.EndInit();
            linliu.Source = bitmap;
            //this.Width = bitmap.Width ;
        }

        public void GoManga() { }
    }
}
