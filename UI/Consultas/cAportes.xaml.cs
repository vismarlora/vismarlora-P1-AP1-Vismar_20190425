using P1_AP1_Vismar_20190425.BLL;
using P1_AP1_Vismar_20190425.Entidades;
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
using System.Windows.Shapes;

namespace P1_AP1_Vismar_20190425.UI.Consultas
{
    /// <summary>
    /// Interaction logic for cAportes.xaml
    /// </summary>
    public partial class cAportes : Window
    {
        public cAportes()
        {
            InitializeComponent();
        }

        public static string Conteo = "";
        public static string Total = "";
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Aportes>();

            if (!string.IsNullOrWhiteSpace(CriterioTextBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: //Persona
                        listado = AportesBLL.GetList(e => e.Persona.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        break;

                    case 1: //Concepto
                        listado = AportesBLL.GetList(e => e.Concepto.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        break;
                }
            }
            else
            {
                listado = AportesBLL.GetList(c => true);
            }

            if (DesdeDatePicker.SelectedDate != null)
                listado = AportesBLL.GetList(c => c.Fecha.Date >= DesdeDatePicker.SelectedDate);

            if (HastaDatePicker.SelectedDate != null)
                listado = AportesBLL.GetList(c => c.Fecha.Date >= HastaDatePicker.SelectedDate);


            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;

            Conteo = listado.Count().ToString();
            Total = listado.Sum(c => c.Monto).ToString("N2");
            ConteoTextBox.Text = Conteo;
            TotalTextBox.Text = Total;
        }
    }
}
