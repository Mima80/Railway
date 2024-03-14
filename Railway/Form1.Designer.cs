namespace Railway
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainTextBox = new TextBox();
            allClientsButton = new Button();
            allRoutesButton = new Button();
            allVehiclesButton = new Button();
            allCargoesButton = new Button();
            addClient = new Button();
            panel1 = new Panel();
            clientName = new TextBox();
            clientAddress = new TextBox();
            clientPhone = new TextBox();
            routeDistance = new TextBox();
            routeEndStation = new TextBox();
            routeStartStation = new TextBox();
            addRoute = new Button();
            routeDuration = new TextBox();
            routeCargoId = new TextBox();
            routeVehicleId = new TextBox();
            vehicleNumber = new TextBox();
            vehicleYear = new TextBox();
            vehicleType = new TextBox();
            addVehicle = new Button();
            cargoDimentions = new TextBox();
            cargoWeight = new TextBox();
            cargoName = new TextBox();
            addCargo = new Button();
            cargoDescription = new TextBox();
            cargoClientId = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            SuspendLayout();
            // 
            // mainTextBox
            // 
            mainTextBox.AllowDrop = true;
            mainTextBox.Location = new Point(209, 12);
            mainTextBox.Multiline = true;
            mainTextBox.Name = "mainTextBox";
            mainTextBox.PlaceholderText = "Тут будуть виведені результати пошуку";
            mainTextBox.ScrollBars = ScrollBars.Vertical;
            mainTextBox.Size = new Size(740, 246);
            mainTextBox.TabIndex = 0;
            // 
            // allClientsButton
            // 
            allClientsButton.Location = new Point(12, 12);
            allClientsButton.Name = "allClientsButton";
            allClientsButton.Size = new Size(191, 57);
            allClientsButton.TabIndex = 1;
            allClientsButton.Text = "Показати всіх клієнтів";
            allClientsButton.UseVisualStyleBackColor = true;
            allClientsButton.Click += allClientsButton_Click;
            // 
            // allRoutesButton
            // 
            allRoutesButton.Location = new Point(12, 75);
            allRoutesButton.Name = "allRoutesButton";
            allRoutesButton.Size = new Size(191, 57);
            allRoutesButton.TabIndex = 2;
            allRoutesButton.Text = "Показати всі маршрути";
            allRoutesButton.UseVisualStyleBackColor = true;
            allRoutesButton.Click += allRoutesButton_Click;
            // 
            // allVehiclesButton
            // 
            allVehiclesButton.Location = new Point(12, 138);
            allVehiclesButton.Name = "allVehiclesButton";
            allVehiclesButton.Size = new Size(191, 57);
            allVehiclesButton.TabIndex = 3;
            allVehiclesButton.Text = "Показати всі потяги";
            allVehiclesButton.UseVisualStyleBackColor = true;
            allVehiclesButton.Click += allVehiclesButton_Click;
            // 
            // allCargoesButton
            // 
            allCargoesButton.Location = new Point(12, 201);
            allCargoesButton.Name = "allCargoesButton";
            allCargoesButton.Size = new Size(191, 57);
            allCargoesButton.TabIndex = 4;
            allCargoesButton.Text = "Показати всі вантажі";
            allCargoesButton.UseVisualStyleBackColor = true;
            allCargoesButton.Click += allCargoesButton_Click;
            // 
            // addClient
            // 
            addClient.Location = new Point(12, 293);
            addClient.Name = "addClient";
            addClient.Size = new Size(154, 27);
            addClient.TabIndex = 5;
            addClient.Text = "Додати клієнта";
            addClient.UseVisualStyleBackColor = true;
            addClient.Click += addClient_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(12, 264);
            panel1.Name = "panel1";
            panel1.Size = new Size(937, 23);
            panel1.TabIndex = 9;
            // 
            // clientName
            // 
            clientName.Location = new Point(169, 293);
            clientName.Name = "clientName";
            clientName.PlaceholderText = "Назва";
            clientName.Size = new Size(125, 27);
            clientName.TabIndex = 10;
            // 
            // clientAddress
            // 
            clientAddress.Location = new Point(300, 293);
            clientAddress.Name = "clientAddress";
            clientAddress.PlaceholderText = "Адреса";
            clientAddress.Size = new Size(125, 27);
            clientAddress.TabIndex = 11;
            // 
            // clientPhone
            // 
            clientPhone.Location = new Point(431, 293);
            clientPhone.Name = "clientPhone";
            clientPhone.PlaceholderText = "Телефон";
            clientPhone.Size = new Size(125, 27);
            clientPhone.TabIndex = 12;
            // 
            // routeDistance
            // 
            routeDistance.Location = new Point(432, 342);
            routeDistance.Name = "routeDistance";
            routeDistance.PlaceholderText = "Відстань";
            routeDistance.Size = new Size(125, 27);
            routeDistance.TabIndex = 16;
            routeDistance.TabStop = false;
            // 
            // routeEndStation
            // 
            routeEndStation.Location = new Point(301, 342);
            routeEndStation.Name = "routeEndStation";
            routeEndStation.PlaceholderText = "Кінцева ст.";
            routeEndStation.Size = new Size(125, 27);
            routeEndStation.TabIndex = 15;
            // 
            // routeStartStation
            // 
            routeStartStation.Location = new Point(170, 342);
            routeStartStation.Name = "routeStartStation";
            routeStartStation.PlaceholderText = "Початкова ст.";
            routeStartStation.Size = new Size(125, 27);
            routeStartStation.TabIndex = 14;
            // 
            // addRoute
            // 
            addRoute.Location = new Point(13, 342);
            addRoute.Name = "addRoute";
            addRoute.Size = new Size(154, 27);
            addRoute.TabIndex = 13;
            addRoute.Text = "Додати маршрут";
            addRoute.UseVisualStyleBackColor = true;
            addRoute.Click += addRoute_Click;
            // 
            // routeDuration
            // 
            routeDuration.Location = new Point(563, 342);
            routeDuration.Name = "routeDuration";
            routeDuration.PlaceholderText = "Час(год)";
            routeDuration.Size = new Size(125, 27);
            routeDuration.TabIndex = 17;
            routeDuration.TabStop = false;
            // 
            // routeCargoId
            // 
            routeCargoId.Location = new Point(694, 342);
            routeCargoId.Name = "routeCargoId";
            routeCargoId.PlaceholderText = "ID груза";
            routeCargoId.Size = new Size(125, 27);
            routeCargoId.TabIndex = 18;
            routeCargoId.TabStop = false;
            // 
            // routeVehicleId
            // 
            routeVehicleId.Location = new Point(825, 342);
            routeVehicleId.Name = "routeVehicleId";
            routeVehicleId.PlaceholderText = "ID потяга";
            routeVehicleId.Size = new Size(125, 27);
            routeVehicleId.TabIndex = 19;
            routeVehicleId.TabStop = false;
            // 
            // vehicleNumber
            // 
            vehicleNumber.Location = new Point(432, 388);
            vehicleNumber.Name = "vehicleNumber";
            vehicleNumber.PlaceholderText = "Рег. номер";
            vehicleNumber.Size = new Size(125, 27);
            vehicleNumber.TabIndex = 23;
            vehicleNumber.TabStop = false;
            // 
            // vehicleYear
            // 
            vehicleYear.Location = new Point(301, 388);
            vehicleYear.Name = "vehicleYear";
            vehicleYear.PlaceholderText = "Рік виг.";
            vehicleYear.Size = new Size(125, 27);
            vehicleYear.TabIndex = 22;
            // 
            // vehicleType
            // 
            vehicleType.Location = new Point(170, 388);
            vehicleType.Name = "vehicleType";
            vehicleType.PlaceholderText = "Тип";
            vehicleType.Size = new Size(125, 27);
            vehicleType.TabIndex = 21;
            // 
            // addVehicle
            // 
            addVehicle.Location = new Point(13, 388);
            addVehicle.Name = "addVehicle";
            addVehicle.Size = new Size(154, 27);
            addVehicle.TabIndex = 20;
            addVehicle.Text = "Додати потяг";
            addVehicle.UseVisualStyleBackColor = true;
            addVehicle.Click += addVehicle_Click;
            // 
            // cargoDimentions
            // 
            cargoDimentions.Location = new Point(432, 437);
            cargoDimentions.Name = "cargoDimentions";
            cargoDimentions.PlaceholderText = "Розміри (NxN)";
            cargoDimentions.Size = new Size(125, 27);
            cargoDimentions.TabIndex = 27;
            cargoDimentions.TabStop = false;
            // 
            // cargoWeight
            // 
            cargoWeight.Location = new Point(301, 437);
            cargoWeight.Name = "cargoWeight";
            cargoWeight.PlaceholderText = "Вага";
            cargoWeight.Size = new Size(125, 27);
            cargoWeight.TabIndex = 26;
            // 
            // cargoName
            // 
            cargoName.Location = new Point(170, 437);
            cargoName.Name = "cargoName";
            cargoName.PlaceholderText = "Назва";
            cargoName.Size = new Size(125, 27);
            cargoName.TabIndex = 25;
            // 
            // addCargo
            // 
            addCargo.Location = new Point(13, 437);
            addCargo.Name = "addCargo";
            addCargo.Size = new Size(154, 27);
            addCargo.TabIndex = 24;
            addCargo.Text = "Додати вантаж";
            addCargo.UseVisualStyleBackColor = true;
            addCargo.Click += addCargo_Click;
            // 
            // cargoDescription
            // 
            cargoDescription.Location = new Point(563, 437);
            cargoDescription.Name = "cargoDescription";
            cargoDescription.PlaceholderText = "Опис";
            cargoDescription.Size = new Size(125, 27);
            cargoDescription.TabIndex = 28;
            cargoDescription.TabStop = false;
            // 
            // cargoClientId
            // 
            cargoClientId.Location = new Point(694, 438);
            cargoClientId.Name = "cargoClientId";
            cargoClientId.PlaceholderText = "ID клієнта";
            cargoClientId.Size = new Size(125, 27);
            cargoClientId.TabIndex = 29;
            cargoClientId.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(13, 326);
            panel2.Name = "panel2";
            panel2.Size = new Size(937, 10);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Location = new Point(13, 372);
            panel3.Name = "panel3";
            panel3.Size = new Size(937, 10);
            panel3.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Location = new Point(13, 421);
            panel4.Name = "panel4";
            panel4.Size = new Size(937, 10);
            panel4.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 472);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(cargoClientId);
            Controls.Add(cargoDescription);
            Controls.Add(cargoDimentions);
            Controls.Add(cargoWeight);
            Controls.Add(cargoName);
            Controls.Add(addCargo);
            Controls.Add(vehicleNumber);
            Controls.Add(vehicleYear);
            Controls.Add(vehicleType);
            Controls.Add(addVehicle);
            Controls.Add(routeVehicleId);
            Controls.Add(routeCargoId);
            Controls.Add(routeDuration);
            Controls.Add(routeDistance);
            Controls.Add(routeEndStation);
            Controls.Add(routeStartStation);
            Controls.Add(addRoute);
            Controls.Add(clientPhone);
            Controls.Add(clientAddress);
            Controls.Add(clientName);
            Controls.Add(panel1);
            Controls.Add(addClient);
            Controls.Add(allCargoesButton);
            Controls.Add(allVehiclesButton);
            Controls.Add(allRoutesButton);
            Controls.Add(allClientsButton);
            Controls.Add(mainTextBox);
            Name = "Form1";
            Text = "Вантажі";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox mainTextBox;
        private Button allClientsButton;
        private Button allRoutesButton;
        private Button allVehiclesButton;
        private Button allCargoesButton;
        private Button addClient;
        private Panel panel1;
        private TextBox clientName;
        private TextBox clientAddress;
        private TextBox clientPhone;
        private TextBox routeDistance;
        private TextBox routeEndStation;
        private TextBox routeStartStation;
        private Button addRoute;
        private TextBox routeDuration;
        private TextBox routeCargoId;
        private TextBox routeVehicleId;
        private TextBox vehicleNumber;
        private TextBox vehicleYear;
        private TextBox vehicleType;
        private Button addVehicle;
        private TextBox cargoDimentions;
        private TextBox cargoWeight;
        private TextBox cargoName;
        private Button addCargo;
        private TextBox cargoDescription;
        private TextBox cargoClientId;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}
