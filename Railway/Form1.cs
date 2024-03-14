using Railway.Model;
using Railway.Repositories;

namespace Railway
{
    public partial class Form1 : Form
    {
        private readonly VehicleRepository _vehicleRepository = new();
        private readonly ClientRepository _clientRepository = new();
        private readonly RouteRepository _routeRepository = new();
        private readonly CargoRepository _cargoRepository = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void allClientsButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = string.Empty;
            var allClients = _clientRepository.GetAllClients();
            foreach (var client in allClients)
            {
                mainTextBox.Text += client;
            }
        }

        private void allRoutesButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = string.Empty;
            var allRoutes = _routeRepository.GetAllRoutes();
            foreach (var route in allRoutes)
            {
                mainTextBox.Text += route;
            }
        }

        private void allVehiclesButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = string.Empty;
            var allVehicles = _vehicleRepository.GetAllVehicles();
            foreach (var vehicle in allVehicles)
            {
                mainTextBox.Text += vehicle;
            }
        }

        private void allCargoesButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = string.Empty;
            var allCargoes = _cargoRepository.GetAllCargo();
            foreach (var cargo in allCargoes)
            {
                mainTextBox.Text += cargo;
            }
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            _clientRepository.InsertClient(new Client
            {
                Address = clientAddress.Text,
                Contact_Phone = clientPhone.Text,
                Name = clientName.Text
            });
            clientAddress.Text = string.Empty;
            clientName.Text = string.Empty;
            clientPhone.Text = string.Empty;

            MessageBox.Show("Клієнт успішно доданий", "Усіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addRoute_Click(object sender, EventArgs e)
        {
            _routeRepository.InsertRoute(new Route
            {
                Distance = decimal.Parse(routeDistance.Text),
                Duration = int.Parse(routeDuration.Text),
                End_Location = routeEndStation.Text,
                Start_Location = routeStartStation.Text,
                Cargo_ID = int.Parse(routeCargoId.Text),
                Vehicle_ID = int.Parse(routeVehicleId.Text)
            });
            routeDistance.Text = string.Empty;
            routeDuration.Text = string.Empty;
            routeEndStation.Text = string.Empty;
            routeStartStation.Text = string.Empty;
            routeCargoId.Text = string.Empty;
            routeVehicleId.Text = string.Empty;

            MessageBox.Show("Маршрут успішно доданий", "Усіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addVehicle_Click(object sender, EventArgs e)
        {
            _vehicleRepository.InsertVehicle(new Vehicle
            {
                Registration_Number = vehicleNumber.Text,
                Type = vehicleType.Text,
                Year_of_Manufacture = int.Parse(vehicleYear.Text)
            });
            vehicleNumber.Text = string.Empty;
            vehicleType.Text = string.Empty;
            vehicleYear.Text = string.Empty;

            MessageBox.Show("Потяг успішно доданий", "Усіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addCargo_Click(object sender, EventArgs e)
        {
            _cargoRepository.InsertCargo(new Cargo
            {
                Description = cargoDescription.Text,
                Dimensions = cargoDimentions.Text,
                Client_ID = int.Parse(cargoClientId.Text),
                Name = cargoName.Text,
                Weight = decimal.Parse(cargoWeight.Text)
            });
            cargoDescription.Text = string.Empty;
            cargoName.Text = string.Empty;
            cargoDimentions.Text = string.Empty;
            cargoWeight.Text = string.Empty;
            cargoClientId.Text = string.Empty;
            MessageBox.Show("Вантаж успішно доданий", "Усіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
