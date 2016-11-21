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
    public sealed partial class Post : UserControl
    {
        public Post()
        {
            this.InitializeComponent();
        }

        public ImageSource imagenUsuario
        {
            get { return (ImageSource)GetValue(imagenUsuarioProperty); }
            set { SetValue(imagenUsuarioProperty, value); }
        }

        public static readonly DependencyProperty imagenUsuarioProperty =
            DependencyProperty.Register("imagenUsuario", typeof(ImageSource), typeof(Post), new PropertyMetadata(new BitmapImage(new Uri("ms-appx://UserControlsPrueba/Assets/anon.jpg", UriKind.RelativeOrAbsolute))));

        public string nombreUsuario
        {
            get { return (string)GetValue(nombreUsuarioProperty); }
            set { SetValue(nombreUsuarioProperty, value); }
        }

        public static readonly DependencyProperty nombreUsuarioProperty =
            DependencyProperty.Register("nombreUsuario", typeof(string), typeof(Post), new PropertyMetadata(string.Empty));



        public ImageSource fotoPost
        {
            get { return (ImageSource)GetValue(fotoPostProperty); }
            set { SetValue(fotoPostProperty, value); }
        }

        public static readonly DependencyProperty fotoPostProperty =
            DependencyProperty.Register("fotoPost", typeof(ImageSource), typeof(Post), new PropertyMetadata(new BitmapImage(new Uri("ms-appx://UserControlsPrueba/Assets/anon.jpg", UriKind.RelativeOrAbsolute))));
    }
}
