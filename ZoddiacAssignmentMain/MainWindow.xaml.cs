using System;
using System.Windows.Shapes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows.Navigation;

namespace ZoddiacAssignmentMain
{

    public enum zodiacsigns
    {
      taurs, aries, libra, leo, gemini, pieces, capricorn, sagittarius, virgo, cancer, aquaries, scorpio 
    }
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show("Your Zodiac sign is: " + month.Text);
                //MessageBox.Show(month.Text.All);
                if (month.Text.All(char.IsDigit))
                {
                    e.Handled = false;
                    MessageBox.Show("You forgot to specify which month you were born in.");
                }
                else if (date.Text.All(char.IsDigit))
                {
                    e.Handled = true;
                }

                if (double.Parse(date.Text) > 31)
                {
                    MessageBox.Show("please enter a valid date");
                }else{

                    if (month.Text == "december")
                    {
                        if (double.Parse(date.Text) < 22)
                        {
                            MessageBox.Show("Your Zodiac sign is: " + zodiacsigns.capricorn);
                        }
                        else
                        {

                            MessageBox.Show("Your Zodiac sign is: " + zodiacsigns.sagittarius);
                        }
                    }
                    if (month.Text == "january")
                    {
                        if (double.Parse(date.Text) < 20)
                        {
                            MessageBox.Show("Your Zodiac sign is: " + zodiacsigns.capricorn);
                        }
                        else
                        {
                            MessageBox.Show("Your Zodiac sign is: " + zodiacsigns.aquaries);
                        }
                    }

                    if (month.Text == "feburary")
                    {
                        if (double.Parse(date.Text) < 19)
                        {
                            MessageBox.Show("Your Zodiac sign is: " + zodiacsigns.aquaries);
                        }
                        else
                        {

                            MessageBox.Show("Your Zodiac sign is: " + zodiacsigns.pieces);
                        }
                    }

                    if (month.Text == "march")
                    {
                        if (double.Parse(date.Text) < 21)
                        {

                            MessageBox.Show("Your Zodiac sign is: " + zodiacsigns.pieces);
                        }
                        else
                        {

                            MessageBox.Show("Your Zodiac sign is: " + zodiacsigns.aries);
                        }
                    }
                    if (month.Text == "april")
                    {
                        if (double.Parse(date.Text) < 20)
                        {

                            MessageBox.Show("Your Zodiac sign is: " + zodiacsigns.aries);
                        }
                        else
                        {

                            MessageBox.Show("Your Zodiac sign is: " + zodiacsigns.taurs);
                        }
                    }
                    if (month.Text == "may")
                    {
                        if (double.Parse(date.Text) < 21)
                        {

                            MessageBox.Show("Your Zodiac sign is: " + zodiacsigns.taurs);
                        }
                        else
                        {

                            MessageBox.Show("Your Zodiac sign is: " + zodiacsigns.gemini);
                        }
                    }
                    if (month.Text == "june")
                    {
                        if (double.Parse(date.Text) < 21)
                        {

                            MessageBox.Show("Your Zodiac sign is: " + zodiacsigns.gemini);
                        }
                        else
                        {

                            MessageBox.Show("Your Zodiac sign is: " + zodiacsigns.cancer);
                        }
                    }
                    if (month.Text == "july")
                    {
                        if (double.Parse(date.Text) < 22)
                        {

                            MessageBox.Show("Your Zodiac sign is: " + zodiacsigns.cancer);
                        }
                        else
                        {

                            MessageBox.Show("Your Zodiac sign is: " + zodiacsigns.leo);
                        }
                    }
                    if (month.Text == "august")
                    {
                        if (double.Parse(date.Text) < 23)
                        {

                            MessageBox.Show("Your Zodiac sign is: " + zodiacsigns.leo);
                        }
                        else
                        {

                            MessageBox.Show("Your Zodiac sign is: " + zodiacsigns.virgo);
                        }
                    }
                    if (month.Text == "september")
                    {
                        if (double.Parse(date.Text) < 23)
                        {

                            MessageBox.Show("Your Zodiac sign is: " + zodiacsigns.virgo);
                        }
                        else
                        {

                            MessageBox.Show("your Zodiac sign is:" + zodiacsigns.libra);
                        }
                    }
                    if (month.Text == "october")
                    {
                        if (double.Parse(date.Text) < 23)
                        {

                            MessageBox.Show("Your Zodiac sign is: " + zodiacsigns.libra);
                        }
                        else
                        {

                            MessageBox.Show("Your Zodiac sign is: " + zodiacsigns.scorpio);
                        }
                    }
                    if (month.Text == "november")
                    {
                        if (double.Parse(date.Text) < 22)
                        {

                            MessageBox.Show("Your Zodiac sign is: " + zodiacsigns.scorpio);
                        }
                        else
                        {

                            MessageBox.Show("Your Zodiac sign is: " + zodiacsigns.sagittarius);
                        }
                    }

                }

            }
            catch
            {
                MessageBox.Show("please enter number for the day");
            }
        }

        private void capricon_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Good manners, self control and responsible");
        }
        private void Taurs_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Reliable, patient and devoted");
        }

        private void Aries_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Confident,Passionate and Honest");
        }
        private void Libra_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Cooperative, diplomatic, gracious");
        }
        private void Aquaris_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Progressive, original, independent");
        }
        private void Picses_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Compassionate, artistic, intuitive");
        }
        private void Gemini_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Gentle, affectionate, curious");
        }
        private void Cancer_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Highly imaginative, loyal, emotiona");
        }
        private void Leo_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Creative, passionate, generous");
        }
        private void Virgo_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Loyal, analytical, kind");
        }
        private void Scorpio_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Resourceful, brave, passionate");
        }
        private void Sagttarius_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Generous, idealistic, great sense of humor");
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}