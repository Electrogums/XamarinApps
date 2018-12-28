using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void btnCalcular_Clicked(object sender, System.EventArgs e)
        {
            var total = (decimal.Parse(txtTotal.Text));
            var propina = (int.Parse(txtPropina.Text));
            var noPersona = (int.Parse(txtNumPersonas.Text));
            var totalPropina = ((total * propina) / 100);
            lblPropina.Detail = totalPropina.ToString("C");
            lblTotal.Detail = (total + totalPropina).ToString("C");
            lblPropinaPorPersona.Detail = (totalPropina / noPersona).ToString("C");
            lblTotalPorPersona.Detail = ((total + totalPropina) / noPersona).ToString("C");
        }
    }
}
