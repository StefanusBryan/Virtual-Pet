using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


public abstract class PET
{
    public string PetName { get; set; }
    public int MoodValue { get; set; }
    public int StaminaValue { get; set; }

    public PET(string petName)
    {
        PetName = petName;
        MoodValue = 100;
        StaminaValue = 100;
    }

    public virtual void DecreaseValues()
    {
        MoodValue -= 4;
        if (MoodValue < 0)
            MoodValue = 0;

        StaminaValue -= 5;
        if (StaminaValue < 0)
            StaminaValue = 0;
    }

    public virtual void IncreaseMood()
    {
        MoodValue += 6;
        if (MoodValue > 100)
            MoodValue = 100;
    }

    public virtual void IncreaseStamina()
    {
        StaminaValue += 7;
        if (StaminaValue > 100)
            StaminaValue = 100;
    }


    public abstract string PetType();

    // Metode untuk mengatur gambar hewan peliharaan
    public virtual void SetPetImage(string status, PictureBox pictureBox)
    {

        // Default: Kosongkan pictureBox
        pictureBox.Image = null;
    }

    public virtual void DecreaseMoodBy20()
    {
        MoodValue -= 20;
        if (MoodValue < 0)
            MoodValue = 0;
    }

    public virtual void DecreaseStaminaBy3()
    {
        StaminaValue -= 3;
        if (StaminaValue < 0)
            StaminaValue = 0;
    }
}

public class Kucing : PET
{
    public Kucing(string petName) : base(petName) { }

    public override string PetType()
    {
        return "Kucing";
    }

    // Override metode SetPetImage untuk mengatur gambar kucing
    public override void SetPetImage(string status, PictureBox pictureBox)
    {
        base.SetPetImage(status, pictureBox); // Panggil metode dari kelas induk jika diperlukan

        string imagePath = @"D:\Visual Studio\PEMROGRAMAN TINGKAT 3 C#\STEFANUS BRYAN_VIRTUAL PET_20216042_TRMK\Gambar\";

        switch (status)
        {
            case "X(":
                pictureBox.Image = Image.FromFile(imagePath + "X(Cat.jpg");
                break;
            case "Bosan":
                pictureBox.Image = Image.FromFile(imagePath + "BosanCat.jpg");
                break;
            case ":)))))":
                pictureBox.Image = Image.FromFile(imagePath + ")))))Cat.jpg");
                break;
            case "Lapar":
                pictureBox.Image = Image.FromFile(imagePath + "LaparCat.jpg");
                break;
            case "Happy":
                pictureBox.Image = Image.FromFile(imagePath + "HappyCat.jpg");
                break;
        }
    }
}

public class Anjing : PET
{
    public Anjing(string petName) : base(petName) { }

    public override string PetType()
    {
        return "Anjing";
    }

    public override void SetPetImage(string status, PictureBox pictureBox)
    {
        base.SetPetImage(status, pictureBox); // Panggil metode dari kelas induk jika diperlukan

        string imagePath = @"D:\Visual Studio\PEMROGRAMAN TINGKAT 3 C#\STEFANUS BRYAN_VIRTUAL PET_20216042_TRMK\Gambar\";

        switch (status)
        {
            case "X(":
                pictureBox.Image = Image.FromFile(imagePath + "X(Dog.jpg");
                break;
            case "Bosan":
                pictureBox.Image = Image.FromFile(imagePath + "BosanDog.jpg");
                break;
            case ":)))))":
                pictureBox.Image = Image.FromFile(imagePath + ")))))Dog.jpg");
                break;
            case "Lapar":
                pictureBox.Image = Image.FromFile(imagePath + "LaparDog.jpg");
                break;
            case "Happy":
                pictureBox.Image = Image.FromFile(imagePath + "HappyDog.jpg");
                break;
        }
    }
}

