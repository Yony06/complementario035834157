namespace complementario035834157
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            //obtendra y validará los numeros ingresados en los entry del proyecto

            {
                double cal1 = double.Parse(calificacion1.Text);
                double cal2 = double.Parse(calificacion2.Text);
                double cal3 = double.Parse(calificacion3.Text);
                double cal4 = double.Parse(calificacion4.Text);
                double cal5 = double.Parse(calificacion5.Text);

                //Calculará el promedio del estudiante con las calificaciones ingresadas
                double promedio = (cal1 + cal2 + cal3 + cal4 + cal5) / 5;

                //Nos mostrará el resultado de la ecuacion de las notas
                resultadoLabel.Text = $"El promedio es: {promedio:F2}";
            }
        }
    }
}


   
   
    


