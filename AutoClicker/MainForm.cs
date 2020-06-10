using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using static AutoClicker.MouseController;
using static AutoClicker.HotKey;
using System.Threading.Tasks;

namespace AutoClicker
{
    public partial class MainForm : Form
    {
        public bool stopProgram = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private static async Task WaitMsAsync(int time)
        {
            await Task.Run(() =>
            {
                Thread.Sleep(time);
            });
        }

        private int CheckProcessInstances(string process)
        {
            Process[] processes = Process.GetProcessesByName(process);
            return processes.Count();
        }

        private void WaitMs(int time)
        {
            Thread.Sleep(time);
        }

        protected override void WndProc(ref Message m)
        {
            int id = m.WParam.ToInt32();

            if (m.Msg == 0x0312)
            {

                listBoxTEST.Items.Add(string.Format("Hotkey #{0} pressed", id));

                if (id == 1)
                {
                    stopProgram = false;
                    StartProgram();
                }
                if (id == 2)
                {
                    stopProgram = true;
                }
                if (id == 5)
                {
                    AddEvent(Cursor.Position.X, Cursor.Position.Y);
                }
            }

            base.WndProc(ref m);
        }

        private void AddEvent(int CoorX, int CoorY)
        {
            dataGridView1.Rows.Add(CoorX, CoorY, "Lewy przycisk myszki", 1000);
        }

        private void ButtonAddEvent_Click(object sender, EventArgs e)
        {
            AddEvent(0, 0);
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            stopProgram = false;
            StartProgram();
        }

        private void ButtonStopProgram_Click(object sender, EventArgs e)
        {
            stopProgram = true;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                this.dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterSingleGHK(1);
            UnregisterSingleGHK(2);
            UnregisterSingleGHK(5);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RegisterSingleGHK(1, (int)Keys.F1);
            RegisterSingleGHK(2, (int)Keys.F2);
            RegisterSingleGHK(5, (int)Keys.F5);
        }

        private void PerformButtonClick(int CoordX, int CoordY, string button)
        {
            MouseClickLeftButton mcLeftButton = new MouseClickLeftButton();
            MouseClickMiddleButton mcMiddleButton = new MouseClickMiddleButton();
            MouseClickRightButton mcRightButton = new MouseClickRightButton();

            mcLeftButton.CoordX = CoordX;
            mcLeftButton.CoordY = CoordY;

            if (button == "Lewy przycisk myszki")
                mcLeftButton.Click1();

            if (button == "Środkowy przycik myszki")
                mcMiddleButton.Click1();

            if (button == "Prawy przycik myszki")
                mcRightButton.Click1();
        }

        private void PerformSendKeys(string keys)
        {
            if (keys.Length > 0)
                SendKeys.SendWait(keys);
        }

        private void RegisterSingleGHK(int uniqueId, int hotKeyCode)
        {
            Boolean registered = RegisterHotKey(this.Handle, uniqueId, 0x0000, hotKeyCode);

            if (registered)
                listBoxTEST.Items.Add(string.Format("Globalny skrót o ID: #{0} został zarejestrowany: {1}", uniqueId, hotKeyCode));

            else
                listBoxTEST.Items.Add(string.Format("Globalny skrót {0} NIE został zarejestrowany -- BŁĄD", uniqueId));

        }

        private async void StartProgram()
        {
            int repeatTimes = int.Parse(textBoxRepeat.Text);

            for (int i = 0; i < repeatTimes; i++)
            {
                textBoxRepeat.Text = (repeatTimes - i).ToString();
                textBoxRepeat.Refresh();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[2].Value.ToString() == "Lewy przycisk myszki" ||
                        row.Cells[2].Value.ToString() == "Środkowy przycik myszki" ||
                        row.Cells[2].Value.ToString() == "Prawy przycik myszki")
                    {
                        PerformButtonClick(
                            int.Parse(row.Cells[0].Value.ToString()), // Mouse coordinate X
                            int.Parse(row.Cells[1].Value.ToString()), // Mouse coordinate Y
                            row.Cells[2].Value.ToString()             // Mouse button description
                            );
                    }

                    // Must add single button click function

                    if (row.Cells[2].Value.ToString() == "Ciąg znaków")
                    {
                        PerformSendKeys(row.Cells[4].Value.ToString());
                    }

                    await WaitMsAsync(int.Parse(row.Cells[3].Value.ToString()));

                    if (stopProgram)
                        return;
                }
                if (stopProgram)
                    return;
            }

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            //timerProgram.Interval = int.Parse(dataGridView1.Rows[row.Index].Cells[3].Value.ToString());
        }

        private void TimerCoord_Tick(object sender, EventArgs e)
        {
            labelCoordX.Text = "Pozycja myszki w osi X: " + Cursor.Position.X.ToString();
            labelCoordY.Text = "Pozycja myszki w osi Y: " + Cursor.Position.Y.ToString();
        }

        private void UnregisterSingleGHK(int uniqueId)
        {
            Boolean unregistered = UnregisterHotKey(this.Handle, uniqueId);

            if (unregistered)
            {
                listBoxTEST.Items.Add("Globalny skrót " + uniqueId + " został zarejestrowany");
                Console.WriteLine("Globalny skrót " + uniqueId + " został zarejestrowany");
            }

            else
            {
                listBoxTEST.Items.Add("Globalny skrót " + uniqueId + " NIE został zarejestrowany -- BŁĄD");
                Console.WriteLine("Globalny skrót " + uniqueId + " NIE został zarejestrowany -- BŁĄD");
            }

        }
    }
}