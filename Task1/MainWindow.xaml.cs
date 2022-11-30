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

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resRubl = rateDollar * sumDollar;
            resSum.Text = resRubl.ToString();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate_E.Text);
            double sumDollar = Convert.ToDouble(sum_E.Text);
            double resRubl = rateDollar * sumDollar;
            resSum_E.Text = resRubl.ToString();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate_G.Text);
            double sumDollar = Convert.ToDouble(sum_G.Text);
            double resRubl = rateDollar * sumDollar;
            resSum_G.Text = resRubl.ToString();
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate_D.Text);
            double sumDollar = Convert.ToDouble(sum_D.Text);
            double resRubl = rateDollar * sumDollar;
            resSum_D.Text = resRubl.ToString();
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            //double k = 1;
            //if (inches.Content.ToString() == inches1.Content.ToString())
            //    valuePreobr.Text = valueIshod.Text;
            //else if (inches.Content.ToString() == "Дюймы" && inches1.Content.ToString() == "Метры")
            //    valuePreobr.Text = Convert.ToString(Convert.ToDouble(valueIshod.Text)/39.97);
            if (valueIshod.Text != null && valuePreobr.Text != null)
            {
                if (Convert.ToString((itemIshod.SelectedItem as ComboBoxItem).Content) ==  Convert.ToString((itemPreobr.SelectedItem as ComboBoxItem).Content))
                    valuePreobr.Text = valueIshod.Text;
                else if (Convert.ToString((itemIshod.SelectedItem as ComboBoxItem).Content) == "Дюймы" && Convert.ToString((itemPreobr.SelectedItem as ComboBoxItem).Content) == "Метры")
                    valuePreobr.Text = Convert.ToString(Convert.ToDouble(valueIshod.Text) / 39.97);
                else if (Convert.ToString((itemIshod.SelectedItem as ComboBoxItem).Content) == "Футы" && Convert.ToString((itemPreobr.SelectedItem as ComboBoxItem).Content) == "Метры")
                    valuePreobr.Text = Convert.ToString(Convert.ToDouble(valueIshod.Text) / 3.281);
                else if (Convert.ToString((itemIshod.SelectedItem as ComboBoxItem).Content) == "Мили" && Convert.ToString((itemPreobr.SelectedItem as ComboBoxItem).Content) == "Метры")
                    valuePreobr.Text = Convert.ToString(Convert.ToDouble(valueIshod.Text) * 1609);
                else if (Convert.ToString((itemIshod.SelectedItem as ComboBoxItem).Content) == "Версты" && Convert.ToString((itemPreobr.SelectedItem as ComboBoxItem).Content) == "Метры")
                    valuePreobr.Text = Convert.ToString(Convert.ToDouble(valueIshod.Text) * 1067);
                else if (Convert.ToString((itemIshod.SelectedItem as ComboBoxItem).Content) == "Метры" && Convert.ToString((itemPreobr.SelectedItem as ComboBoxItem).Content) == "Дюймы")
                    valuePreobr.Text = Convert.ToString(Convert.ToDouble(valueIshod.Text) * 39.97);
                else if (Convert.ToString((itemIshod.SelectedItem as ComboBoxItem).Content) == "Метры" && Convert.ToString((itemPreobr.SelectedItem as ComboBoxItem).Content) == "Футы")
                    valuePreobr.Text = Convert.ToString(Convert.ToDouble(valueIshod.Text) * 3.281);
                else if (Convert.ToString((itemIshod.SelectedItem as ComboBoxItem).Content) == "Метры" && Convert.ToString((itemPreobr.SelectedItem as ComboBoxItem).Content) == "Мили")
                    valuePreobr.Text = Convert.ToString(Convert.ToDouble(valueIshod.Text) / 1609);
                else if (Convert.ToString((itemIshod.SelectedItem as ComboBoxItem).Content) == "Метры" && Convert.ToString((itemPreobr.SelectedItem as ComboBoxItem).Content) == "Версты")
                    valuePreobr.Text = Convert.ToString(Convert.ToDouble(valueIshod.Text) / 1067);
                else if (Convert.ToString((itemIshod.SelectedItem as ComboBoxItem).Content) == "Дюймы" && Convert.ToString((itemPreobr.SelectedItem as ComboBoxItem).Content) == "Футы")
                    valuePreobr.Text = Convert.ToString(Convert.ToDouble(valueIshod.Text) / 12);
                else if (Convert.ToString((itemIshod.SelectedItem as ComboBoxItem).Content) == "Дюймы" && Convert.ToString((itemPreobr.SelectedItem as ComboBoxItem).Content) == "Мили")
                    valuePreobr.Text = Convert.ToString(Convert.ToDouble(valueIshod.Text) / 63360);
                else if (Convert.ToString((itemIshod.SelectedItem as ComboBoxItem).Content) == "Дюймы" && Convert.ToString((itemPreobr.SelectedItem as ComboBoxItem).Content) == "Версты")
                    valuePreobr.Text = Convert.ToString(Convert.ToDouble(valueIshod.Text) / 42000);
                else if (Convert.ToString((itemIshod.SelectedItem as ComboBoxItem).Content) == "Футы" && Convert.ToString((itemPreobr.SelectedItem as ComboBoxItem).Content) == "Дюймы")
                    valuePreobr.Text = Convert.ToString(Convert.ToDouble(valueIshod.Text) * 12);
                else if (Convert.ToString((itemIshod.SelectedItem as ComboBoxItem).Content) == "Футы" && Convert.ToString((itemPreobr.SelectedItem as ComboBoxItem).Content) == "Мили")
                    valuePreobr.Text = Convert.ToString(Convert.ToDouble(valueIshod.Text) / 5280);
                else if (Convert.ToString((itemIshod.SelectedItem as ComboBoxItem).Content) == "Футы" && Convert.ToString((itemPreobr.SelectedItem as ComboBoxItem).Content) == "Версты")
                    valuePreobr.Text = Convert.ToString(Convert.ToDouble(valueIshod.Text) / 3500);
                else if (Convert.ToString((itemIshod.SelectedItem as ComboBoxItem).Content) == "Мили" && Convert.ToString((itemPreobr.SelectedItem as ComboBoxItem).Content) == "Дюймы")
                    valuePreobr.Text = Convert.ToString(Convert.ToDouble(valueIshod.Text) * 63360);
                else if (Convert.ToString((itemIshod.SelectedItem as ComboBoxItem).Content) == "Мили" && Convert.ToString((itemPreobr.SelectedItem as ComboBoxItem).Content) == "Футы")
                    valuePreobr.Text = Convert.ToString(Convert.ToDouble(valueIshod.Text) * 5280);
                else if (Convert.ToString((itemIshod.SelectedItem as ComboBoxItem).Content) == "Мили" && Convert.ToString((itemPreobr.SelectedItem as ComboBoxItem).Content) == "Версты")
                    valuePreobr.Text = Convert.ToString(Convert.ToDouble(valueIshod.Text) * 1.509);
                else if (Convert.ToString((itemIshod.SelectedItem as ComboBoxItem).Content) == "Версты" && Convert.ToString((itemPreobr.SelectedItem as ComboBoxItem).Content) == "Дюймы")
                    valuePreobr.Text = Convert.ToString(Convert.ToDouble(valueIshod.Text) * 42000);
                else if (Convert.ToString((itemIshod.SelectedItem as ComboBoxItem).Content) == "Версты" && Convert.ToString((itemPreobr.SelectedItem as ComboBoxItem).Content) == "Футы")
                    valuePreobr.Text = Convert.ToString(Convert.ToDouble(valueIshod.Text) * 3500);
                else if (Convert.ToString((itemIshod.SelectedItem as ComboBoxItem).Content) == "Версты" && Convert.ToString((itemPreobr.SelectedItem as ComboBoxItem).Content) == "Мили")
                    valuePreobr.Text = Convert.ToString(Convert.ToDouble(valueIshod.Text) / 1.509);
            }
        }

        private void itemIshod_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {

        }
        private void itemIshod_SelectionChanged(object sender, RoutedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            //MessageBox.Show(selectedItem.Content.ToString());
        }

        private void itemPreobr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            //MessageBox.Show(selectedItem.Content.ToString());
        }
    }
}
