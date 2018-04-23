using System;
using System.Windows;
using System.Reflection;

namespace LoadPDFDocument {

    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();

            Uri baseUri = new Uri(Assembly.GetEntryAssembly().Location);
            Uri uri = new Uri(baseUri, "..\\..\\Demo.pdf");
            Viewer.DocumentSource = uri;
        }
    }
}
