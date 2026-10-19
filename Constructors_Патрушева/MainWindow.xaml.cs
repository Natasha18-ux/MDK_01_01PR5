using Constructors_Патрушева.Classes;
using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<Classes.Student> AllStudents = RepoStudents.AllStudent();
        public int Count = 8;
        public int step = 0;
        public MainWindow()
        {
            InitializeComponent();
            CreateStudent();
        }

        public void CreateStudent()
        {
            for (int iStudent = step; iStudent < Count + step; iStudent++)
            {
                if (AllStudents.Count > iStudent)
                {
                    parent.Children.Add(new Constructors_Патрушева.Student(AllStudents[iStudent]));
                }
            }
            this.step += Count;
        }

        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            ScrollViewer scroll = sender as ScrollViewer;
            double ParentHeight = parent.ActualHeight;
            double WindowHeight = scroll.ActualHeight - 20;
            double DeltaHeight = ParentHeight - WindowHeight;

            if (DeltaHeight - scroll.VerticalOffset < 140)
                CreateStudent();
        }
    }
}
