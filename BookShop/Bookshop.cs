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
            //public Edition(string name, decimal price, string authorName, string authorSoname, DateTime authorBirth, string bookName, string bookGenre, int bookPages, string publishing_house)
            
            
            Edition edition = new Edition("Відьмак", 319, "Штибор", "Бартош", DateTime.Now, "Тьмяні Спогади", "Фентезі", 104, "Vovkulaka");
            Editions.Add(edition);
            edition = new Edition("Токійські месники", 155, "Кен", "Вакуі", DateTime.Now, "Том 1-4", "Шьонен", 192, "Nasha idea");
            Editions.Add(edition);
            edition = new Edition("Ранкове сяйво", 319, "Сара", "Джіо", DateTime.Now, "Ранкове сяйво", "Фентезі", 104, "Vivat");
            Editions.Add(edition);

            Pyblisher.Items.Clear();
            Pyblisher.Text = "";
            foreach (var pyblisher in Editions)
            {
                if (!Pyblisher.Items.Contains(pyblisher.Publishing_house.Name))
                {
                    Pyblisher.Items.Add(pyblisher.Publishing_house.Name);
                }

            }
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
                + $"\nНазва книги: {temp.Name}, жанр - {temp.Book.Genre}, кількість сторіно - {temp.Page}"
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
        }
    }
}
