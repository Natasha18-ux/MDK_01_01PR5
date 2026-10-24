using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Constructors_Патрушева
{
    /// <summary>
    /// Логика взаимодействия для Student.xaml
    /// </summary>
    public partial class Student : UserControl
    {
        public Student( Classes.Student student)
        {
            InitializeComponent();

            tb_info.Content = student.GetFIO();
            tb_scholarship.Content = student.Scholarship ? "Степендия: получает" : "Степендия: не получает";
            tb_course.Content = $"Курс: {student.Course}";
        }

        

        private void Get_image(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "= Изображения файлы (*.jpg;*.png;*.bmp;*.avif)|*.jpg;*.png;*.bmp;*.avif";
            if (ofd.ShowDialog() == true)
            {
               
                string sfp = ofd.FileName; //запись путя файла из проводника

                BitmapImage bitmapImage = new BitmapImage(); //обьект картинки
                bitmapImage.BeginInit(); // начало работы с файлом
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.UriSource = new Uri(sfp);
                bitmapImage.EndInit(); //конец работы с файлом

                Here_image.Source = bitmapImage;
                Delet_after.Visibility = Visibility.Collapsed; // убираю заглушку
            }
        }
    }
}
