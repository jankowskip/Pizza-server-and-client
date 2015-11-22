using System;
using System.Collections;
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
using WPFTablicaAplikacja.Properties;
using WPFTablicaAplikacja.ServiceReference1;

//using System.Diagnostics;
//using System.Threading;





namespace WPFTablicaAplikacja
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TablicaClient Klient = new TablicaClient("WSHttpBinding_ITablica");
        private List<Pizza> tab = new List<Pizza>();
        private List<Pizza>tab2 = new List<Pizza>();

                                    
        //  Stopwatch stopWatch = new Stopwatch();

        public MainWindow()
        {
            InitializeComponent();
            TextBox1.Text = "Produkt";
            TextBox2.Text = "Skladniki";
            TextBox3.Text = "Cena";
            tab = new List<Pizza>(Klient.ListaPizz());
            tab2 = new List<Pizza>(Klient.ListaPizz2());
         ListBox1.ItemsSource = tab;
            zamow.ItemsSource = tab2;
            TextBox1.IsReadOnly = true;
            TextBox2.IsReadOnly = true;
            TextBox3.IsReadOnly = true;
            Status.IsReadOnly = true;
            Menu.IsReadOnly = true;
            Status.Text = "Zloz zamowienie "; 
            Zamowienie.IsReadOnly = true;
    //        Imie.Text = nazwa;
     //       Adres.Text = Klient.adresik;
   //         nrtelefonu = TextBox3.Text;
          

            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)  //dodaj
        {
            Pizza pizza = new Pizza();
            pizza.Produkt = TextBox1.Text;
            pizza.Skladniki = TextBox2.Text;
            string stringPole = TextBox3.Text;
            pizza.Cena = Int32.Parse(stringPole);
            Klient.Dodaj(pizza);   // dodaje
            tab2 = new List<Pizza>(Klient.ListaPizz2());  //odseiza liste
            zamow.ItemsSource = tab2;           //odseiza liste
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //usun
        {
            string Produkt = TextBox1.Text;
            Klient.Usun(Produkt);
            tab2 = new List<Pizza>(Klient.ListaPizz2());
            zamow.ItemsSource = tab2;
        }

        private void ListBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Pizza pizza = (Pizza)ListBox1.SelectedItem;
            if (pizza != null)
            {
                TextBox1.Text = pizza.Produkt;
                TextBox2.Text = pizza.Skladniki;
                TextBox3.Text = pizza.Cena.ToString();
            }
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) //menu
        {
            Menu.Text = "Menu";
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e) // status
        {
   
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) // wyslij
        {
  
            if (Telefon.Text != null)
            {
                Status.Text = "Wyslano zamowienie, czekaj na telefon.";
                Klient.Wyslij();
                Klient.WriteToConsole();
          
            }
            else
            {
                Status.Text = "Wpisz swoj nr telefonu!";
            }


            //      stopWatch.Start();
            //     Thread.Sleep(10000);
            //    stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            //   TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value. 
            //   string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            //      ts.Hours, ts.Minutes, ts.Seconds,
            //     ts.Milliseconds / 10);
            // Console.WriteLine("RunTime " + elapsedTime);
            

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)  //Zamow
        {

        }

        private void Zamowienie_TextChanged(object sender, TextChangedEventArgs e) //zamowienie
        {
          
        }

        private void Imie_TextChanged(object sender, TextChangedEventArgs e) //imie
        {

        }

        private void Adres_TextChanged(object sender, TextChangedEventArgs e) //adres
        {

        }

        private void Telefon_TextChanged(object sender, TextChangedEventArgs e) //telefon
        {

        }

    }
}

// imie = produkt
// nazwisko usun
// indeks = cena 
// student = pizza
// Studnet = Pizza
//
