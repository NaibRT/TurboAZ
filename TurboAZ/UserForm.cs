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
    }
}
