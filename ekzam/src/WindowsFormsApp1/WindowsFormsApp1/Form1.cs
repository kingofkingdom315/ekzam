using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Height = 525;
        }

        public void OpenButtonSplit_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файл (*.html)|*.html|Текст (*.txt)|*.txt| Все файлы (*.*)|*.*"; 
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    webBrowser.Navigate(openFileDialog.FileName);
                    this.Height = 585;

                    string url = openFileDialog.FileName;
                    Regex r = new Regex($"index.html");
                    Regex r1 = new Regex($"index2.html");
                    if (r.IsMatch(url) == true)
                        LabelStatusSplit.Text = "Задание №1";
                    else
                    {
                        if (r1.IsMatch(url) == true)
                        {
                            LabelStatusSplit.Text = "Задание №2";
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка");
                }   
            }
        }

        private void ClearButtonSplit_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("about:blank");
            this.Height = 525;
            LabelStatusSplit.Text = "Статус решения";
        }

        private void ExitBottonSplit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelpBottonSplit_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
            this.Show();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBoxX.Text);
                double y = Convert.ToDouble(textBoxY.Text);
                string url = webBrowser.Document.Url.OriginalString;
                Regex r = new Regex($"index.html");
                Regex r1 = new Regex($"index2.html");
                if (r.IsMatch(url) == true)
                {
                    if (x >= -2 && x <= 3)
                    {
                        if (y >= 2 && y <= 5)
                        {
                            if (x == 3)
                            {
                                if (y != 2 && y < 3)
                                {
                                    DialogResult result = MessageBox.Show(
                                    "Точка в области",
                                    "Результат");
                                }
                                else
                                {
                                    DialogResult result = MessageBox.Show("точка на границе", "Результат");
                                }
                            }
                            else if (x == -2 || y == 2 || y == 5)
                            {
                                DialogResult result = MessageBox.Show("точка на границе", "Результат");
                            }
                            else
                            {
                                DialogResult result = MessageBox.Show("Точка в области", "Результат");
                            }
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("точка вне области", "Результат");
                        }
                    }
                    else if (x > 3 && x <= 5)
                    {
                        if (y >= 2 && y <= 3)
                        {
                            if (x == 5 || y == 2 || y == 3)
                            {
                                DialogResult result = MessageBox.Show("точка на границе", "Результат");
                            }
                            else
                            {
                                DialogResult result = MessageBox.Show("Точка в области", "Результат");
                            }
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("точка вне области", "Результат");
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("точка вне области", "Результат");
                    }
                }
                else
                {
                    if (r1.IsMatch(url) == true)
                    {
                        double d;
                        if (y > 0 || (y == 0 && x ==0))
                        {
                            d = x * x;
                            if (y >= d)
                            {
                                if (y == d)
                                {
                                    DialogResult result = MessageBox.Show("точка на границе", "Результат");
                                }
                                else
                                {
                                    DialogResult result = MessageBox.Show("Точка в области", "Результат");
                                }
                            }
                            else { DialogResult result = MessageBox.Show("точка вне области", "Результат"); }
                        }
                        else
                        {
                            if (x >= -1 && x <= 1)
                            {
                                d = 1 - x * x;
                                if (y <= -d)
                                {
                                    if (y == -d)
                                    {
                                        DialogResult result = MessageBox.Show("точка на границе", "Результат");
                                    }
                                    else
                                    {
                                        DialogResult result = MessageBox.Show("Точка в области", "Результат");
                                    }
                                }
                                else { DialogResult result = MessageBox.Show("точка вне области", "Результат"); }
                            }
                            else if (y == 0)
                            {
                                DialogResult result = MessageBox.Show("точка на границе", "Результат");
                            }
                            else
                            {
                                DialogResult result = MessageBox.Show("Точка в области", "Результат");
                            }
                        }
                    }
                    else
                        LabelStatusSplit.Text = "Для данного файла нет задания!";
                }
            }
            catch(FormatException)
            {
                LabelStatusSplit.Text = "Некорректный ввод данных";
            }
            catch (Exception ex)
            {
                LabelStatusSplit.Text = $"Ошибка! {ex.Message}";
            }
        }
    }
}