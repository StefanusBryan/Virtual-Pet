using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIRTUAL_PET
{

    public partial class VIRTUALPET : Form
    {
        private bool isNameEntered = false;
        private PET pet;
        private int ageInSeconds = 0;
        private bool isDogSelected = true;


        public VIRTUALPET()
        {
            InitializeComponent();
            InitializeVirtualPet();
        }

        private void InitializeVirtualPet()
        {
            isNameEntered = true;
            string petName = PromptForPetName("Masukkan Nama Hewan Peliharaan");
            if (string.IsNullOrEmpty(petName))
            {
                // Jika pengguna membatalkan dialog, keluar dari aplikasi
                this.Close();
                return;
            }

            textBoxname.Text = petName;

            // Saat pertama kali program dijalankan, hewan peliharaan otomatis menjadi kucing
            if (isDogSelected)
            {
                pet = new Anjing(petName);
            }
            else
            {
                pet = new Kucing(petName);
            }
            UpdatePetInfo();
            textBoxresponse.Text = "";
            timer1.Interval = 1000; // Ubah interval menjadi 1000 ms (1 detik)
            timer1.Start(); // Mulai timer setelah inisialisasi
        }

        private string PromptForPetName(string prompt)
        {
            Form promptForm = new Form();
            promptForm.Width = 350;
            promptForm.Height = 150;
            promptForm.Text = prompt;

            Label lblPrompt = new Label() { Left = 50, Top = 20, Text = prompt };
            TextBox txtInput = new TextBox() { Left = 50, Top = 50, Width = 200 };
            Button btnOk = new Button() { Text = "Ok", Left = 150, Width = 70, Top = 80 };
            Button btnCancel = new Button() { Text = "Cancel", Left = 230, Width = 70, Top = 80 };

            btnOk.Click += (sender, e) => { promptForm.DialogResult = DialogResult.OK; };
            btnCancel.Click += (sender, e) => { promptForm.DialogResult = DialogResult.Cancel; };

            promptForm.Controls.Add(lblPrompt);
            promptForm.Controls.Add(txtInput);
            promptForm.Controls.Add(btnOk);
            promptForm.Controls.Add(btnCancel);

            DialogResult result = promptForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                return txtInput.Text;
            }
            else
            {
                // Jika pengguna membatalkan dialog, kembalikan string kosong
                return string.Empty;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Usia bertambah setiap 60 detik (1 menit)
            ageInSeconds++;
            int ageInYears = ageInSeconds / 60;
            textBoxage.Text = ageInYears.ToString();

            // Mengurangi nilai mood dan stamina
            pet.DecreaseValues();
            UpdatePetInfo();

            // Menentukan status berdasarkan kondisi mood dan stamina
            string status = "";
            if (pet.MoodValue < 30 && pet.StaminaValue >= 30)
            {
                status = "Bosan";
            }
            else if (pet.MoodValue >= 30 && pet.StaminaValue < 30)
            {
                status = "Lapar";
            }
            else if (pet.MoodValue < 20)
            {
                status = "X(";
            }
            else if (pet.StaminaValue < 20)
            {
                status = "X(";
            }
            else if (pet.MoodValue >= 60 && pet.StaminaValue >= 60)
            {
                status = "Happy";
            }
            else if (pet.MoodValue >= 20)
            {
                status = ":)))))";
            }
            else if (pet.StaminaValue >= 20)
            {
                status = ":)))))";
            }
            

            // Menetapkan gambar di pictureBox1 berdasarkan status
            pet.SetPetImage(status, pictureBox1);

            // Menetapkan status di textBoxstatus
            textBoxstatus.Text = status;
        }



        private void buttonmood_Click(object sender, EventArgs e)
        {
            textBoxresponse.Text = "Yippie"; // Memberikan respons standar
            pet.IncreaseMood(); // Meningkatkan mood

            // Menurunkan stamina sebesar 5
            pet.DecreaseStaminaBy3();

            UpdatePetInfo(); // Memperbarui informasi hewan peliharaan di GUI
        }

        private void buttonstamina_Click(object sender, EventArgs e)
        {
            // Memeriksa apakah stamina di atas 90
            if (pet.StaminaValue > 99)
            {
                pet.DecreaseMoodBy20(); // Mengurangi mood sebesar 50
            }
            else
            {
                // Respons standar jika stamina tidak di atas 90
                textBoxresponse.Text = "Yummy"; // Respons standar
                pet.IncreaseStamina(); // Stamina bertambah karena makan
            }

            UpdatePetInfo(); // Memperbarui informasi hewan peliharaan di GUI
        }

        private void UpdatePetInfo()
        {
            // Menampilkan informasi tentang hewan peliharaan ke TextBox
            textBoxname.Text = $"{pet.PetType()} - {pet.PetName}";
            progressBarmood.Value = pet.MoodValue;
            progressBarstamina.Value = pet.StaminaValue;
        }

        private void buttonchangepet_Click(object sender, EventArgs e)
        {
            // Tampilkan dialog untuk memasukkan nama hewan peliharaan baru
            string newPetName = PromptForPetName("Masukkan Nama Hewan Peliharaan");

            // Periksa apakah pengguna memasukkan nama
            if (!string.IsNullOrEmpty(newPetName))
            {
                // Ubah jenis hewan peliharaan
                if (isDogSelected)
                {
                    pet = new Kucing(newPetName);
                    textBoxresponse.Text = "";
                }
                else
                {
                    pet = new Anjing(newPetName);
                    textBoxresponse.Text = "";
                }

                // Perbarui informasi hewan peliharaan
                isDogSelected = !isDogSelected;
                textBoxresponse.Text = "";
                UpdatePetInfo();
            }
        }
    }
}