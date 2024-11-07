using System;
using System.Windows.Forms;

namespace lab_work_3
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            fCar fcar = new fCar(car);
            if(fcar.ShowDialog() == DialogResult.OK) 
            {
                tbCarsnfo.Text +=
                string.Format("Модель: {0}, Виробник: {1}, Рік випуску: {2}, " +
                "Об'єм двигуна (л): {3}, Кількість місць: {4}, {5}, Середня витрата палива (л/100км): {6}. \r\n\r\n",
                car.ModelName,  
                car.Manufacturer,  
                car.YearOfProduction,  
                car.EngineCapacity,  
                car.SeatCount,  
                car.IsElectric ? "Електричний" : "Не електричний",
                car.AverageFuelConsumption);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) 
                Application.Exit();
        }
    }
}
