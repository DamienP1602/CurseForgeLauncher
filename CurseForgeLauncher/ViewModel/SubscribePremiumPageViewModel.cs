using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurseForgeLauncher.ViewModel
{
    class SubscribePremiumPageViewModel : ModelViewBase
    {
        RelayCommand runArticleCommand => new RelayCommand(Run_Click_Article);
        RelayCommand runSupportCommand => new RelayCommand(Run_Click_Support);

        public SubscribePremiumPageViewModel()
        {

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
