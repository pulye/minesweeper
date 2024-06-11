using System;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;

namespace minesweeper
{
    public partial class Form1 : Form
    {
        private const int numarRanduri = 10;
        private const int numarColoane = 10;
        private const double probabilitateMina = 0.15;
        private Button[,] butoane;
        private bool[,] areMina;
        private bool[,] esteDezvaluita;
        private bool[,] esteMarcata;
        private int numarCeluleDezvaluite;
        private Label etichetaCronometru;
        private System.Timers.Timer cronometru;
        private int timpJoc;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            butoane = new Button[numarRanduri, numarColoane];
            areMina = new bool[numarRanduri, numarColoane];
            esteDezvaluita = new bool[numarRanduri, numarColoane];
            esteMarcata = new bool[numarRanduri, numarColoane];
            numarCeluleDezvaluite = 0;
            timpJoc = 0;

           

            cronometru = new System.Timers.Timer(1000);
            cronometru.Elapsed += ActualizareCronometru;
            cronometru.Start();

            for (int i = 0; i < numarRanduri; i++)
            {
                for (int j = 0; j < numarColoane; j++)
                {
                    Button buton = new Button
                    {
                        Dock = DockStyle.Fill,
                        Tag = new Tuple<int, int>(i, j),
                        BackColor = Color.LightGray, // Adjust color to match XP style
                        FlatStyle = FlatStyle.Flat, // Remove button borders
                        Font = new Font("Tahoma", 8, FontStyle.Bold) // Adjust font to match XP style
                    };
                    buton.FlatAppearance.BorderSize = 1; // Set border size to 1 for XP style
                    buton.MouseDown += Buton_MouseDown;
                    tableLayoutPanel.Controls.Add(buton, j, i);
                    butoane[i, j] = buton;

                    areMina[i, j] = new Random().NextDouble() < probabilitateMina;
                }
            }
        }

        private void Buton_MouseDown(object sender, MouseEventArgs e)
        {
            Button butonApasat = sender as Button;
            if (butonApasat == null) return;

            var pozitie = (Tuple<int, int>)butonApasat.Tag;
            int rand = pozitie.Item1;
            int coloana = pozitie.Item2;

            if (e.Button == MouseButtons.Left)
            {
                if (esteMarcata[rand, coloana]) return;

                if (areMina[rand, coloana])
                {
                    butonApasat.Text = "M";
                    butonApasat.BackColor = Color.Red;
                    MessageBox.Show("Ai pierdut!");
                    Application.Restart();
                }
                else
                {
                    DezvaluieCelula(rand, coloana);
                    VerificaCastig();
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (!esteDezvaluita[rand, coloana])
                {
                    esteMarcata[rand, coloana] = !esteMarcata[rand, coloana];
                    butonApasat.Text = esteMarcata[rand, coloana] ? "F" : "";
                }
            }
        }

        private void DezvaluieCelula(int rand, int coloana)
        {
            if (esteDezvaluita[rand, coloana]) return;

            int mineInApropiere = NumarMineInApropiere(rand, coloana);
            butoane[rand, coloana].Text = mineInApropiere.ToString();
            butoane[rand, coloana].Enabled = false;
            esteDezvaluita[rand, coloana] = true;
            numarCeluleDezvaluite++;

            if (mineInApropiere == 0)
            {
                for (int i = rand - 1; i <= rand + 1; i++)
                {
                    for (int j = coloana - 1; j <= coloana + 1; j++)
                    {
                        if (i >= 0 && i < numarRanduri && j >= 0 && j < numarColoane && !(i == rand && j == coloana))
                        {
                            DezvaluieCelula(i, j);
                        }
                    }
                }
            }
        }

        private void VerificaCastig()
        {
            if (numarCeluleDezvaluite == numarRanduri * numarColoane - NumarMineTotal())
            {
                cronometru.Stop();
                MessageBox.Show($"Ai câștigat! Timp: {timpJoc} secunde");
                Application.Restart();
            }
        }

        private int NumarMineTotal()
        {
            int numarMine = 0;
            for (int i = 0; i < numarRanduri; i++)
            {
                for (int j = 0; j < numarColoane; j++)
                {
                    if (areMina[i, j])
                    {
                        numarMine++;
                    }
                }
            }
            return numarMine;
        }

        private int NumarMineInApropiere(int rand, int coloana)
        {
            int numarMine = 0;
            for (int i = rand - 1; i <= rand + 1; i++)
            {
                for (int j = coloana - 1; j <= coloana + 1; j++)
                {
                    if (i >= 0 && i < numarRanduri && j >= 0 && j < numarColoane && !(i == rand && j == coloana))
                    {
                        if (areMina[i, j])
                        {
                            numarMine++;
                        }
                    }
                }
            }
            return numarMine;
        }

        private void ActualizareCronometru(object sender, ElapsedEventArgs e)
        {
            timpJoc++;
            Invoke((MethodInvoker)delegate
            {
                etichetaCronometru.Text = $"Timp: {timpJoc}";
            });
        }
    }
}

