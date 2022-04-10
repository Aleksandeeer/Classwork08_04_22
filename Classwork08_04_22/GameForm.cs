using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork08_04_22
{
    public partial class GameForm : Form
    {
        private List<PictureBox> pictureboxes;
        private List<PictureBox> result;
        private List<Image> images;
        private readonly Random rnd;
        private RankedForm RF;
        private NameForm NF;
        int count = 0;

        public Form RForm
        {
            get { return RF; }
        }
        public Timer Timer
        {
            get { return GameTimer; }
            set { GameTimer = value; }
        }

        public GameForm()
        {
            InitializeComponent();

            pictureboxes = new List<PictureBox>
            {
                pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox8,pictureBox9, pictureBox10,
                pictureBox11, pictureBox12, pictureBox13, pictureBox14,pictureBox15,pictureBox16,pictureBox17,pictureBox18,pictureBox19,pictureBox20,pictureBox21,
                pictureBox22,pictureBox23,pictureBox24,pictureBox25,pictureBox26,pictureBox27,pictureBox28,pictureBox29,pictureBox30,pictureBox31,pictureBox32,
                pictureBox33,pictureBox34,pictureBox35,pictureBox36
            };

            images = new List<Image>()
            {
                Properties.Resources.Apple, Properties.Resources.Banan, Properties.Resources.Bicycle, Properties.Resources.Button,
                Properties.Resources.Card, Properties.Resources.Chair, Properties.Resources.CLoud, Properties.Resources.Cube, Properties.Resources.Glass,
                Properties.Resources.Pear, Properties.Resources.Pen, Properties.Resources.Piece, Properties.Resources.Pill, Properties.Resources.Scissors,
                Properties.Resources.Shit, Properties.Resources.Shit, Properties.Resources.Tree, Properties.Resources.Watermelon,

                Properties.Resources.Apple, Properties.Resources.Banan, Properties.Resources.Bicycle, Properties.Resources.Button,
                Properties.Resources.Card, Properties.Resources.Chair, Properties.Resources.CLoud, Properties.Resources.Cube, Properties.Resources.Glass,
                Properties.Resources.Pear, Properties.Resources.Pen, Properties.Resources.Piece, Properties.Resources.Pill, Properties.Resources.Scissors,
                Properties.Resources.Shit, Properties.Resources.Shit, Properties.Resources.Tree, Properties.Resources.Watermelon
            };

            rnd = new Random();
            RF = new RankedForm();
            NF = new NameForm();
            result = new List<PictureBox>();

            Refresh(images);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if(GameProgressBar.Value != 0)
            {
                GameProgressBar.Value--;
            }
            else
            {
                GameTimer.Stop();
                MessageBox.Show($"Время кончилось, вы заработали {Convert.ToInt32(MainScoreLabel.Text)} очков(a)");
                if(NF.ShowDialog() == DialogResult.OK)
                {
                    //Занесение данных в таблицу
                    RF.Table.Rows.Add(NF.Name, Convert.ToInt32(MainScoreLabel.Text), DateTime.Now.ToShortDateString());
                }
                Close();

            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            GameTimer.Start();
        }

        private new void Click(object sender, EventArgs e)
        {
            //Получаем бокс
            var picture = sender as PictureBox;

            //Если картинка не открыта и количество открытых картинок < 2
            if (picture.Image == null && count < 2)
            {
                picture.Image = images[pictureboxes.IndexOf(picture)];
                //Добавляем бокс в результат. Когда достигнет двух, то начнёт сравнение двух открытых картинок
                result.Add(pictureboxes[pictureboxes.IndexOf(picture)]);

                try
                {
                    int index1 = images.IndexOf(result[0].Image);
                    int index2 = images.IndexOf(result[1].Image);

                    if (index1 == index2)
                    {
                        //Если картинки совпали, то добавляем очко, а боксы с их картинками убираем из листов (далее они нам не будут нужны)
                        pictureboxes.Remove(result[0]);
                        pictureboxes.Remove(result[1]);
                        images.RemoveAt(index1);
                        images.RemoveAt(index2);
                        result.Clear();
                        MainScoreLabel.Text = (Convert.ToInt32(MainScoreLabel.Text) + 1).ToString();
                    }
                }
                catch
                {
                    //В случае если нажали на первый бокс
                }
                count++;
            }
            else if (count == 2)
            {
                //Очищаем картинки, которые не совпали
                for (int i = 0; i < pictureboxes.Count; i++)
                {
                    pictureboxes[i].Image = null;
                }
                result.Clear();
                count = 0;
            }
        }

        private void Refresh(List<Image> images)
        {
            for (int i = images.Count - 1; i >= 1; i--)
            {
                int j = rnd.Next(i + 1);
                var temp = images[j];
                images[j] = images[i];
                images[i] = temp;
            }
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
