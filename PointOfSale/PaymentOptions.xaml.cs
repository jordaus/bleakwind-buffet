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
using PointOfSale.ExtensionMethod;
using RoundRegister;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Interface;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentOptions.xaml
    /// </summary>
    public partial class PaymentOptions : UserControl
    {
        /// <summary>
        /// Initializes Component
        /// </summary>
        public PaymentOptions()
        {
            InitializeComponent();
        }

        /// <summary>
        /// function for the back click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Back_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var screen = new MenuControl();
            orderControl.SwapScreen(screen);
        }

        /// <summary>
        /// fucnction for the card option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Card_Click(object sender, RoutedEventArgs e)
        {
            var order = (Order)DataContext;
            var result = CardReader.RunCard(order.Total);
            if (result == CardTransactionResult.Approved)
            {
                if(DataContext is Order o)
                {
                    List<string> receipt = new List<string>();
                    receipt.Add($"Order #{o.Number}");

                    foreach(IOrderItem item in o)
                    {
                        receipt.Add($"{item.ToString()} :");
                        foreach(string a in item.SpecialInstructions)
                        {
                            receipt.Add(a);
                        }
                        receipt.Add($"Calories: {item.Calories}");
                        receipt.Add("Price: " + (String.Format("{0:0.00}", item.Price)));
                        receipt.Add("\n");
                    }
                    receipt.Add($"Total Calories: {o.Calories}");
                    receipt.Add($"Subtotal: {((String.Format("{0:0.00}", order.Subtotal)))}");
                    receipt.Add($"Tax: {((String.Format("{0:0.00}", order.Tax)))}");
                    receipt.Add($"Total: {((String.Format("{0:0.00}", order.Total)))}");

                    foreach(string itemorder in receipt)
                    {
                        RecieptPrinter.PrintLine(itemorder);
                    }
                    RecieptPrinter.CutTape();

                    order.Clear();
                    
                }
                MessageBox.Show("Card was Approved! Thank You!");
                var freshOrder = new Order();
                DataContext = freshOrder;
            }
            else if (result == CardTransactionResult.Declined)
            {
                MessageBox.Show("Your Card has been Declined! Please Try another option!");
            }
            else if (result == CardTransactionResult.IncorrectPin)
            {
                MessageBox.Show("Your Pin was incorrect. Please Try Again");
            }
            else if (result == CardTransactionResult.InsufficientFunds)
            {
                MessageBox.Show("Insufficient Funds! Please try again!");
            }
            else if (result == CardTransactionResult.ReadError)
            {
                MessageBox.Show("There was a error! Please try again");
            }

        }
    }
}
