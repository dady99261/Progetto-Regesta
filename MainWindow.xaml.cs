using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



            private  void Btn1_Click(object sender, RoutedEventArgs e)
            {

            int Orders = Convert.ToInt32(Norders.Text);
            String MonthChoose = Convert.ToString(Month.Text);
            FirstShopR.Text = ""; FirstShopR.Background = Brushes.Transparent;
            SecondShopR.Text = ""; SecondShopR.Background = Brushes.Transparent;
            ThirdShopR.Text = ""; ThirdShopR.Background = Brushes.Transparent;

            int  FirstShop(int Orders )
            {
                


                int Stocks = 8;
                int Cost = 120;
                if (Orders <= Stocks)
                {

                    int Total = Orders * Cost;

                    if (Total > 1000)
                    {
                        int SalePrice = Total * 95 / 100;
                        return SalePrice;
                        
                    }
                    else
                    {
                        return Total;
                    }
                }
                else
                {
                    return 0;
                }
              }


                 int SecondShop(int Orders) 
            {
                


                int Stocks = 15;
                int Price = 128;
                if (Orders <= Stocks)
                {

                    int Total = Orders * Price;

                    if (Orders > 5 && Orders < 10)
                    {
                        int SalePrice = Total * 97 / 100;
                        return SalePrice;

                    }

                    else if (Orders > 10)
                    {
                        int SalePrice = Total * 95 / 100;
                        return SalePrice;
                    }
                    else



                    {
                        return Total;
                    }

                }



                else
                {
                    return 0;
                }
              }
                  int ThirdShop(int Orders, string MonthChoose)
            {
                
               

                int stocks = 23;
                int Price = 129;
                String MonthDiscount = "September";



                if (Orders < stocks)
                {
                    int Total = Orders * Price;



                    if (Total > 1000)
                    {
                        int Saleprice1 = Total * 95 / 100;


                        if (MonthChoose == MonthDiscount)
                        {
                            int Saleprice2 = Saleprice1 * 98 / 100;
                            return Saleprice2;
                        }

                        return Saleprice1;
                    }
                    else
                    {

                        return Total;
                    }

                }
                else
                {
                    return 0;
                }
            }

            double a= Convert.ToDouble(FirstShop(Orders));
            double b = Convert.ToDouble(SecondShop(Orders));
            double c = Convert.ToDouble(ThirdShop(Orders,MonthChoose));
            int Shiptime1 = 5;
            int Shiptime2 = 7;
            int Shiptime3 = 4;

            if (a != 0 && a < b && a < c)
            {


                FirstShopR.Background = Brushes.Yellow;
                FirstShopR.Text = a.ToString();
                PhraseResult1.Text = ("The first shop it's cheaper " + a + "the shipping time it's " + Shiptime1 + " days");

            }
            else if (b != 0 && b < c && a==0)
            {

                SecondShopR.Background = Brushes.Yellow;
                SecondShopR.Text = b.ToString();
                PhraseResult2.Text = ("The second shop it's cheaper " + b + "the shipping time it's " + Shiptime2 + " days");

            }
            else 
            {
                ThirdShopR.Background = Brushes.Yellow;
                ThirdShopR.Text = c.ToString();
                PhraseResult3.Text = ("The second shop it's cheaper " + c + "the shipping time it's " + Shiptime3 + " days");
            }

            if (a == 0)
            {
                PhraseResult1.Text = ("In the First shop there's not enough stocks ");
            }
            

            else
            {
                PhraseResult1.Text = ("The price of the first shop it's " + a + " euro , and " +
                     "the shipping time it's " + Shiptime1 + " days");
            }

            if (b == 0)
            {
                PhraseResult2.Text = ("In the Second shop there's not enough stocks ");

            }
          


            else
            {
                PhraseResult2.Text = ("The price of the second shop it's " + b + " euro , and " +
                        "the shipping time it's " + Shiptime2 + " days");

            }

            if (c == 0)
            {
                PhraseResult3.Text = ("In the third shop there's not enough stocks ");

            }
           
            else
            {

                PhraseResult3.Text = ("The price of the Third shop it's " + c + " euro , and " +
                        "the shipping time it's " + Shiptime3 + " days ");
            }





            

        }

    }


          

        }













    