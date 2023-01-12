using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace BookShop
{
    public partial class Bookshop : Form
    {
        //Dictionary<string, List<string>> Editions;
        List<Edition> Editions = new List<Edition>();
        public Bookshop()
        {
            InitializeComponent();
            //IPrintable edition = new Edition("Відьмак", 319, "Штибор", "Бартош", DateTime.Now, "Тьмяні Спогади", "Фентезі", 104, "Vovkulaka");
            //MessageBox.Show($"{edition.GetInfo()}");
        }

        private void Pyblisher_SelectedIndexChanged(object sender, EventArgs e)
        {
            Editione.Text = "";
            Editione.Items.Clear();
            foreach (var editiones in Editions)
            {
                if (editiones.Publishing_house.Name == Pyblisher.Text)
                {
                    Editione.Items.Add(editiones.Name);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Editione_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void orderInfo_Click(object sender, EventArgs e)
        {

        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            Edition temp = new Edition();
            foreach (var editions in Editions)
            {
                if(editions.Publishing_house.Name == Pyblisher.Text && editions.Name == Editione.Text)
                {
                    temp = editions;
                }
            }
            orderInfo.Text = "Ваше замовлення:"
                + $"\nВидавництво: {temp.Publishing_house.Name}"
                + $"\nНазва книги: {temp.Name}, жанр - {temp.Book.Genre}, кількість сторінок - {temp.Page}"
                + $"\nЇї автор: {temp.Book.Authors.FirstOrDefault().Name} {temp.Book.Authors.FirstOrDefault().Soname}"
                + $"\nЦіна: {temp.Price} гривень";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дякую за замовлення!");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SonameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Edition edition = new Edition(Box1.Text, Int32.Parse(Box7.Text), Box4.Text, Box3.Text, DateTime.Now, Box5.Text, Box6.Text, Int32.Parse(Box8.Text), Box1.Text);
            Editions.Add(edition);
            if (!Pyblisher.Items.Contains(Box1.Text))
            {
                Pyblisher.Items.Add(Box1.Text);
            }

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("books.dat", FileMode.Create))
            {
                binaryFormatter.Serialize(fs, Editions);
            }
        }

        private void Bookshop_Load_1(object sender, EventArgs e)
        {
            Pyblisher.Items.Clear();
            Pyblisher.Text = "";
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("books.dat", FileMode.OpenOrCreate))
            {
                Editions = (List<Edition>)binaryFormatter.Deserialize(fs);

                //Edition edition = new Edition("Відьмак", 319, "Штибор", "Бартош", DateTime.Now, "Тьмяні Спогади", "Фентезі", 104, "Vovkulaka");
                //Editions.Add(edition);
                //edition = new Edition("Токійські месники", 155, "Кен", "Вакуі", DateTime.Now, "Том 1-4", "Шьонен", 192, "Nasha idea");
                //Editions.Add(edition);
                //edition = new Edition("Тоgsadgasgegrgsvddvssdsd", 155, "Кен", "Вакуі", DateTime.Now, "Том 1-4", "Шьонен", 192, "Nasha idea");
                //Editions.Add(edition);
                //edition = new Edition("Ранкове сяйво", 319, "Сара", "Джіо", DateTime.Now, "Ранкове сяйво", "Фентезі", 104, "Vivat");
                //Editions.Add(edition);

                foreach (Edition pyblisher in Editions)
                {
                    if (!Pyblisher.Items.Contains(pyblisher.Publishing_house.Name))
                    {
                        Pyblisher.Items.Add(pyblisher.Publishing_house.Name);
                    }
                }
            }
        }

        private void Bookshop_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("books.dat", FileMode.Create))
            {
                binaryFormatter.Serialize(fs, Editions);
            }
        }

    }
}
