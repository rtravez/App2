using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        private Double notaFinal;
        public MainPage()
        {
            InitializeComponent();
        }


        private void txtSeguimientoUno_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtSeguimientoUno.Text))
            {
                DisplayAlert("Error", "El campo seguimiento uno es obligatorio", "Atrás");
                return;
            }

            if (Convert.ToDouble(txtSeguimientoUno.Text) < 0 || Convert.ToDouble(txtSeguimientoUno.Text) > 10)
            {

                DisplayAlert("Error", "El campo seguimiento uno debe ser mayor a cero y menor igual a 10", "Atrás");
                return;
            }
            txtParcialUno.Text = ((Convert.ToDouble(txtSeguimientoUno.Text) * 0.3) + (Convert.ToDouble(txtExamenUno.Text) * 0.2)).ToString();

        }

        private void txtExamenUno_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (String.IsNullOrEmpty(txtExamenUno.Text))
            {


                DisplayAlert("Error", "El campo examen uno es obligatorio", "Atrás");
                return;
            }
            if (Convert.ToDouble(txtExamenUno.Text) < 0 || Convert.ToDouble(txtExamenUno.Text) > 10)
            {

                DisplayAlert("Error", "El campo examen uno debe ser mayor a cero y menor igual a 10", "Atrás");
                return;
            }

            txtParcialUno.Text = ((Convert.ToDouble(txtSeguimientoUno.Text) * 0.3) + (Convert.ToDouble(txtExamenUno.Text) * 0.2)).ToString();

        }

        private void txtSeguimientoDos_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (String.IsNullOrEmpty(txtSeguimientoDos.Text))
            {


                DisplayAlert("Error", "El campo seguimiento dos es obligatorio", "Atrás");
                return;
            }

            if (Convert.ToDouble(txtSeguimientoDos.Text) < 0 || Convert.ToDouble(txtSeguimientoDos.Text) > 10)
            {

                DisplayAlert("Error", "El campo seguimiento dos debe ser mayor a cero y menor igual a 10", "Atrás");
                return;
            }

            txtParcialDos.Text = ((Convert.ToDouble(txtSeguimientoDos.Text) * 0.3) + (Convert.ToDouble(txtExamenDos.Text) * 0.2)).ToString();

        }

        private void txtExamenDos_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtExamenDos.Text))
            {


                DisplayAlert("Error", "El campo examen dos es obligatorio", "Atrás");
                return;
            }

            if (Convert.ToDouble(txtExamenDos.Text) < 0 || Convert.ToDouble(txtExamenDos.Text) > 10)
            {

                DisplayAlert("Error", "El campo examen dos debe ser mayor a cero y menor igual a 10", "Atrás");
                return;
            }

            txtParcialDos.Text = ((Convert.ToDouble(txtSeguimientoDos.Text) * 0.3) + (Convert.ToDouble(txtExamenDos.Text) * 0.2)).ToString();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {

            if (!this.validarFormulario())
            {
                notaFinal = Convert.ToDouble(null == txtParcialUno ? "0" : txtParcialUno.Text) + Convert.ToDouble(null == txtParcialDos ? "0" : txtParcialDos.Text);

                if (notaFinal >= 7)
                {
                    DisplayAlert("Info", "APROBADO " + notaFinal + "", "Atrás");
                }
                else if (notaFinal >= 5 && notaFinal <= 6.9)
                {
                    DisplayAlert("Info", "COMPLEMENTARIO " + notaFinal + "", "Atrás");
                }
                else if (notaFinal < 5)
                {
                    DisplayAlert("Info", "REPROBADO " + notaFinal + "", "Atrás");
                }
            }
        }

        private bool validarFormulario()
        {
            if (String.IsNullOrEmpty(txtSeguimientoUno.Text))
            {


                DisplayAlert("Error", "El campo seguimiento uno es obligatorio", "Atrás");
                return true;
            }

            if (Convert.ToDouble(txtSeguimientoUno.Text) < 0 || Convert.ToDouble(txtSeguimientoUno.Text) > 10)
            {

                DisplayAlert("Error", "El campo seguimiento uno debe ser mayor a cero y menor igual a 10", "Atrás");
                return true;
            }

            if (String.IsNullOrEmpty(txtExamenUno.Text))
            {


                DisplayAlert("Error", "El campo examen uno es obligatorio", "Atrás");
                return true;
            }
            if (Convert.ToDouble(txtExamenUno.Text) < 0 || Convert.ToDouble(txtExamenUno.Text) > 10)
            {

                DisplayAlert("Error", "El campo examen uno debe ser mayor a cero y menor igual a 10", "Atrás");
                return true;
            }

            if (String.IsNullOrEmpty(txtSeguimientoDos.Text))
            {


                DisplayAlert("Error", "El campo seguimiento dos es obligatorio", "Atrás");
                return true;
            }

            if (Convert.ToDouble(txtSeguimientoDos.Text) < 0 || Convert.ToDouble(txtSeguimientoDos.Text) > 10)
            {

                DisplayAlert("Error", "El campo seguimiento dos debe ser mayor a cero y menor igual a 10", "Atrás");
                return true;
            }

            if (String.IsNullOrEmpty(txtExamenDos.Text))
            {


                DisplayAlert("Error", "El campo examen dos es obligatorio", "Atrás");
                return true;
            }

            if (Convert.ToDouble(txtExamenDos.Text) < 0 || Convert.ToDouble(txtExamenDos.Text) > 10)
            {

                DisplayAlert("Error", "El campo examen dos debe ser mayor a cero y menor igual a 10", "Atrás");
                return true;
            }

            return false;
        }
    }
}
