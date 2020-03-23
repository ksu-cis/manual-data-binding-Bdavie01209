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
using ManualDataBinding.Data;
namespace ManualDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Note note = new Note();

        public MainWindow()
        {
            InitializeComponent();
            Editor.Note = note;
        }

        /// <summary>
        /// event handler for new note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewNote(object sender, RoutedEventArgs e)
        {
            note = new Note();
            Editor.Note = note;
        }

        /// <summary>
        /// event handler for clear note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearNote(object sender, RoutedEventArgs e)
        {
            note.Body = "";
        }

        /// <summary>
        /// event handler for mutate note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MutateNote(object sender, RoutedEventArgs e)
        {
            note.Title = "Hot Leaf Juice";
            note.Body = "How could a member of my own family say something so horrible?";
        }
    }
}
