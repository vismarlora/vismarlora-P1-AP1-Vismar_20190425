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

namespace P1_AP1_Vismar_20190425.UI.Registros
{
    /// <summary>
    /// Interaction logic for rAportes.xaml
    /// </summary>
    public partial class rAportes : Window
    {
        private Aportes aporte = new Aportes();

        public rAportes()
        {
            InitializeComponent();

            this.DataContext = aporte;

        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {

            var encontrado = AportesBLL.Buscar(Utilidades.ToInt(AporteIdTextBox.Text));
            if (encontrado != null)
                this.aporte = encontrado;
            else
            {
                this.aporte = new Aportes();

                MessageBox.Show("Id no encontrado!", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            this.DataContext = this.aporte;

        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();

            FechaDatePicker.SelectedDate = DateTime.Now;
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            //Validar

            if (!validar())
                return;

            bool paso = AportesBLL.Guardar(this.aporte);

            if (paso)
            {
                //Limpiar

                Limpiar();

                MessageBox.Show("Transacción Exitosa!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
                MessageBox.Show("Transacción Fallida!", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);

        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {

            if (AportesBLL.Eliminar(Utilidades.ToInt(AporteIdTextBox.Text)))
            {
                Limpiar();

                MessageBox.Show("Registro Eliminado!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("No fue posible eliminar!", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);

        }

        private void Limpiar()
        {
            this.aporte = new Aportes();
            this.DataContext = this.aporte;
        }

        private bool validar()
        {

            string MensajeValidacion = "";

            if (string.IsNullOrWhiteSpace(PersonaTextBox.Text))
            {
                PersonaTextBox.Focus();
                MensajeValidacion = "Favor indicar el Nombre";
            }

            if (string.IsNullOrWhiteSpace(ConceptoTextBox.Text))
            {
                ConceptoTextBox.Focus();
                MensajeValidacion = "Favor indicar el Concepto";
            }

            if (MensajeValidacion.Length > 0)
                MessageBox.Show(MensajeValidacion, "Validacion", MessageBoxButton.OK, MessageBoxImage.Information);

            MontoTextBox.Text = aporte.Monto.ToString("N2");

            return MensajeValidacion.Length == 0;
        }
    }
}
