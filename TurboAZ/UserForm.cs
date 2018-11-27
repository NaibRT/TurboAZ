using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurboAZ.Model;

namespace TurboAZ
{
    public partial class UserForm : Form
    {
        public string[] Cities = new string[] { "Baki", "Gence", "Qazax", "Quba", "Zaqatal", "Mingecevir" , "Agdam" };
        public string[] BanTypes = new string[] { "Avtobus", "Dartqı", "Furqon", "Kupe", "Minivan", "Sedan" };

        public string[] Colors = new string[] { "Ağ","Bej","Boz","Gümüşü","Mavi","Narıncı","Qara","Qəhvəyi","Qırmızı","Qızılı","Yaş_Asfalt"};

        public string[] MotorVolumes = new string[] { "100", "200", "300", "400", "500", "600", "700", "800", "900", "1000", "1200", "1300", "1400", "1500", "1600", "1700", "1800", "1900", "2000" };


        public UserForm()
        {
            InitializeComponent();
            CityComboBox.Items.AddRange(Cities);
            BanTypeComboBox.Items.AddRange(BanTypes);
            ColorComboBox.Items.AddRange(Colors);
            MotorVolumeComboBox.Items.AddRange(MotorVolumes);
            FlueTypeComboBox.Items.AddRange(new[] { "Benzin", "Gas", "Diesel" });
            TransmissionComboBox.Items.AddRange(new[] { "Automat", "Mechanic" });
            GearTypeComboBox.Items.AddRange(new[] { "Front", "Back", "Both" });
            NewComboBox.Items.AddRange(new[] { "Yes","No"});
            MarkaComboBox.Items.AddRange(toArray());

           
        }

        private string[] modelForMark(string mark)
        {
            CarMarka newmark = DB.CarM.Find(m => m.Name == mark);
            List<string> newModel = new List<string>();
            foreach (var item in DB.CarModels)
            {
                if (item.MarkID==newmark.ID)
                {
                    newModel.Add(item.Name);
                }
            }
            return newModel.ToArray();
        }

        private string[] toArray()
        {
            string[] newM = new string[DB.CarM.Count];

            for (int i = 0; i < DB.CarM.Count; i++)
            {
                newM[i] = DB.CarM[i].Name;
            }
            return newM;
        }

        private void MarkaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ModelComboBox.Items.Count>0)
            {
                ModelComboBox.Items.Clear();
            }
            ModelComboBox.Items.AddRange(modelForMark(MarkaComboBox.SelectedItem.ToString()));
        }

        private void ADDbutton_Click(object sender, EventArgs e)
        {

        }

       private void AddUserProduct()
        {
            Car newCar = new Car(CityComboBox.SelectedItem.ToString(), MarkaComboBox.SelectedItem.ToString(), ModelComboBox.SelectedItem.ToString(),
                dateTimePicker1.Value.ToString(), BanTypeComboBox.SelectedItem.ToString(), ColorComboBox.SelectedItem.ToString(), MotorVolumeComboBox.SelectedItem.ToString(),
                HoursePowertextBox.Text.ToString(), FlueTypeComboBox.SelectedItem.ToString(), MilagetextBox.Text.ToString(), TransmissionComboBox.SelectedItem.ToString(),
                GearTypeComboBox.SelectedItem.ToString(), NewComboBox.SelectedItem.ToString(), PrisetextBox.Text.ToString(),
                );
        }

        private bool CheckAddProduct()
        {
            if (String.IsNullOrEmpty(CityComboBox.SelectedItem.ToString()))
            {
                return false;
            }
            if (String.IsNullOrEmpty(MarkaComboBox.SelectedItem.ToString()))
            {
                return false;
            }
            if (String.IsNullOrEmpty(ModelComboBox.SelectedItem.ToString()))
            {
                return false;
            }
            if (String.IsNullOrEmpty(dateTimePicker1.Value.ToString()))
            {
                return false;
            }
            if (String.IsNullOrEmpty(BanTypeComboBox.SelectedItem.ToString()))
            {
                return false;
            }
            if (String.IsNullOrEmpty(ColorComboBox.SelectedItem.ToString()))
            {
                return false;
            }
            if (String.IsNullOrEmpty(MotorVolumeComboBox.SelectedItem.ToString()))
            {
                return false;

            }
            if (String.IsNullOrEmpty(HoursePowertextBox.Text.ToString()))
            {
                return false;
            }
            if (String.IsNullOrEmpty(FlueTypeComboBox.SelectedItem.ToString()))
            {
                return false;
            }
            if (String.IsNullOrEmpty(MilagetextBox.Text.ToString()))
            {
                return false;
            }
            if (String.IsNullOrEmpty(TransmissionComboBox.SelectedItem.ToString()))
            {
                return false;
            }
            if (String.IsNullOrEmpty(GearTypeComboBox.SelectedItem.ToString()))
            {
                return false;
            }
            if (String.IsNullOrEmpty(NewComboBox.SelectedItem.ToString()))
            {
                return false;
            }
            if (String.IsNullOrEmpty(PrisetextBox.Text.ToString()))
            {
                return false;
            }
            return true;
        }
    }
}
