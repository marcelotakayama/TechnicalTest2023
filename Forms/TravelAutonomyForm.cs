namespace TesteTecnico2023.Forms
{
    using System;
    using System.Windows.Forms;
    using TesteTecnico2023.Model;

    public partial class TravelAutonomyForm : Form
    {
        public TravelAutonomyForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Obtenha a distância e o peso da carga dos campos de entrada
            double distance = Convert.ToDouble(txtDistance.Text);
            double weight = Convert.ToDouble(txtWeight.Text);

            // Variáveis para acompanhar o veículo com o menor custo
            Vehicle idealVehicle = null;
            double minCost = double.MaxValue;

            foreach (Vehicle vehicle in Data.VEHICLES)
            {
                // Verifique se o veículo pode transportar a carga
                if (weight <= vehicle.WeightSupported)
                {
                    // Calcule o número de viagens necessárias
                    double trips = Math.Ceiling(distance / (vehicle.Autonomy / 1000.0));

                    // Verifique se existem preços de combustível disponíveis
                    if (Data.FUEL_PRICES.Count > 0)
                    {
                        double fuelCost = (distance / 1000.0) * (vehicle.Autonomy / 100.0) * Data.FUEL_PRICES[0].price;
                        double totalCost = trips * fuelCost;

                        if (totalCost < minCost)
                        {
                            idealVehicle = vehicle;
                            minCost = totalCost;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum preço de combustível cadastrado. Configure os preços de combustível antes de calcular o frete.");
                        return; // Saia da função se não houver preços de combustível
                    }
                }
            }

            if (idealVehicle != null)
            {
                // Exibir as informações do veículo ideal e custo do frete na tela
                MessageBox.Show($"Veículo Ideal: {idealVehicle.Type()}\nMarca: {idealVehicle.Brand}\nModelo: {idealVehicle.ModelName}\nCusto do Frete: R$ {minCost:F2}");
            }
            else
            {
                // Caso nenhum veículo seja adequado
                MessageBox.Show("Nenhum veículo adequado encontrado.");
            }
        }

    }
}
