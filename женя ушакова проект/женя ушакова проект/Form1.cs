using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace женя_ушакова_проект
{
    public partial class Form1 : Form
    {
        List<Event> eventsList = new List<Event>(); // Предположим, у вас есть список событий
        Journal journal;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            textBox2.Text = "Добро пожаловать.Выбирете действие ↓";
            journal = new Journal(eventsList);
        }

      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ADD_Click(object sender, EventArgs e)
        {
           // textBox2.Text = "Введите название события:";
            string Name = Convert.ToString(name.Text);
            textBox2.Clear();
           // textBox2.Text="Введите время события в формате 'чч:мм':";
            textBox1.Clear();
            DateTime startTime = DateTime.ParseExact(time.Text, "HH:mm", CultureInfo.InvariantCulture);
            textBox2.Clear();
            //textBox2.Text="Введите описание события:";
            textBox1.Clear();
            string Description = Convert.ToString(description.Text);
            journal.AddEvent(new Event { Name = Name, StartTime = startTime, Description = Description });
        }

        private void Show_All_Click(object sender, EventArgs e)
        {
            
            textBox2.Text = "Введите дату для просмотра событий в формате 'гггг-ММ-дд':";
            DateTime displayDate = DateTime.ParseExact(date.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            string eventsForDay = journal.DisplayAllEventsForDay(displayDate);

            textBox1.Text = eventsForDay;
        }

        private void Save_Click(object sender, EventArgs e)
        {
           textBox2.Text=("Введите дату для сохранения событий в файл в формате 'гггг-ММ-дд':");
            string saveDate = date.Text;
           journal.SaveEventsToFile(saveDate);
            MessageBox.Show("файл успешно сохранен");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void time_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_TextChanged(object sender, EventArgs e)
        {

        }

        private void description_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
