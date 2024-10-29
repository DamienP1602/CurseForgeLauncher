using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace CurseForgeLauncher.Views
{
    /// <summary>
    /// Interaction logic for SubscribePremiumPage.xaml
    /// </summary>
    public partial class SubscribePremiumPage : UserControl
    {
        RelayCommand runArticleCommand => new RelayCommand(Run_Click_Article);
        RelayCommand runSupportCommand => new RelayCommand(Run_Click_Support);
        public SubscribePremiumPage()
        {
            InitializeComponent();
        }

        void OpenLoginURL(string _url)
        {
            ProcessStartInfo _psi = new ProcessStartInfo(_url);
            _psi.UseShellExecute = true;
            Process.Start(_psi);
        }

        void Run_Click_Article(object obj)
        {
            OpenLoginURL("https://support.curseforge.com/en/support/solutions/articles/9000237396-curseforge-premium-switching-to-tebex-payment-system");
        }

        private void Run_Click_Support(object sender)
        {
            OpenLoginURL("https://support.curseforge.com/en/support/tickets/new");

        }
    }
}
