using AzeriChat2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace AzeriChat2
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Message> Messages { get; set; } = new ObservableCollection<Message>();
        public MainWindow()
        {
            InitializeComponent();
            MessageList.ItemsSource = Messages;
        }

        private void InputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string newText = txtbox1.Text;
                string time = DateTime.Now.ToString("HH:mm");
                var new_message = new Message();
                new_message.Text = newText;
                new_message.Time = time;
                Messages.Add(new_message);
                txtbox1.Clear();
            }
        }

        private void txtbox1_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e) => txtbox1.Clear();
    }
}