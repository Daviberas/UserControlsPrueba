using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace UserControlsPrueba.UserControls
{
    public sealed partial class fichaAlumno : UserControl
    {
        public fichaAlumno()
        {
            this.InitializeComponent();
        }

        public int edadAlumno
        {
            get { return (int)GetValue(edadAlumnoProperty); }
            set { SetValue(edadAlumnoProperty, value); }
        }

        public static readonly DependencyProperty edadAlumnoProperty =
            DependencyProperty.Register("edadAlumno", typeof(int), typeof(fichaAlumno), new PropertyMetadata(0));



        public string nombreAlumno
        {
            get { return (string)GetValue(nombreAlumnoProperty); }
            set { SetValue(nombreAlumnoProperty, value); }
        }

        public static readonly DependencyProperty nombreAlumnoProperty =
            DependencyProperty.Register("nombreAlumno", typeof(string), typeof(fichaAlumno), new PropertyMetadata(""));



        public ImageSource imagenAlumno
        {
            get { return (ImageSource)GetValue(imagenAlumnoProperty); }
            set { SetValue(imagenAlumnoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for imagenAlumno.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty imagenAlumnoProperty =
            DependencyProperty.Register("imagenAlumno", typeof(ImageSource), typeof(fichaAlumno), new PropertyMetadata(new BitmapImage(new Uri("ms-appx://UserControlsPrueba/Assets/anon.jpg", UriKind.RelativeOrAbsolute))));
    }
}
