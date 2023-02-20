using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LottoSors {
    public partial class Form1 : Form {

        private readonly Random random = new Random();
        private readonly int[] selectedNumbers = new int[5];

        private int current = 0;

        public Form1() {
            InitializeComponent();

            int size = 40;
            int num = 1;

            for (int i = 0; i < 6; i++) {
                for (int a = 0; a < 16; a++) {
                    Button button = new Button() {
                        Bounds = new Rectangle(a * size, i * size, size, size),
                        Text = num.ToString(),
                        Font = new Font("Arial", 15, FontStyle.Bold),
                        FlatStyle = FlatStyle.Flat,
                        Cursor = Cursors.Hand,
                        Tag = num
                    };

                    button.FlatAppearance.BorderSize = 0;

                    button.Click += (o, e) => {
                        if (o is Button clicked) {
                            if (clicked.BackColor == Color.Red) {
                                clicked.BackColor = Color.Transparent;

                                selectedNumbers[current - 1] = -1;
                                current--;
                                return;
                            }
                            
                            if (clicked.Tag is int number) {
                                if (current >= 5) {
                                    MessageBox.Show("Maximum 5 db számot választhat.", "Sorsolás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }

                                clicked.BackColor = Color.Red;

                                selectedNumbers[current] = number;
                                current++;
                            }
                        }
                    };

                    numberPanel.Controls.Add(button);
                    num++;
                }
            }
        }

        private void sorsolasButton_Click(object sender, EventArgs e) {
            pointText.Text = "Találat ->";

            if (current < 4) {
                MessageBox.Show("Legalább 4 számot kell választania a sorsoláshoz.", "Sorsolás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int[] values = new int[5];

            for (int i = 0; i < 5; i++) {
                int val = random.Next(0, 91);

                foreach (int one in values) {
                    while (one == val) {
                        val = random.Next(0, 91);
                    }
                }

                values[i] = val;
            }

            var filtered = selectedNumbers.Where(one => one != -1);

            playedText.Text = $"Megjátszott -> {string.Join(", ", filtered)}";
            winningText.Text = $"Nyerőszámok -> {string.Join(", ", values)}";

            string tal = "";

            foreach (int one in filtered) {
                foreach (int ran in values) {
                    if (one == ran) {
                        if (tal.Length != 0) {
                            tal += ", ";
                        }

                        tal += $"{one}";
                    }
                }
            }

            if (tal.Length != 0) {
                pointText.Text = $"Találat -> {tal}";
            }
        }
    }
}
