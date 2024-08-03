using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace DinnerSelector
{
    public partial class Form1 : Form
    {
        private List<string> dinnerOptions;
        private string jsonFilePath = "dinners.json";

        public Form1()
        {
            InitializeComponent();
            LoadDinner();
        }
        
        private void LoadDinner()
        {
            try
            {
                if (File.Exists(jsonFilePath))
                {
                    string jsonString = File.ReadAllText(jsonFilePath, Encoding.UTF8);
                    dinnerOptions = JsonSerializer.Deserialize<List<string>>(jsonString);
                }
                else
                {
                    dinnerOptions = new List<string>();
                    SaveDinner();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error LoadDinnerOptions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dinnerOptions = new List<string>();
            }
        }

        private void SaveDinner()
        {
            try
            {
                //string jsonString = JsonSerializer.Serialize(dinnerOptions);
                //File.WriteAllText(jsonFilePath, jsonString, Encoding.UTF8);
                var options = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                    WriteIndented = true
                };
                string jsonString = JsonSerializer.Serialize(dinnerOptions, options);

                using (var writer = new StreamWriter(jsonFilePath, false, new UTF8Encoding(true)))
                {
                    writer.Write(jsonString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"�x�s���\�ﶵ�ɵo�Ϳ��~�G{ex.Message}", "���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button
        private void btnSelectDinner_Click(object sender, EventArgs e)
        {
            if (dinnerOptions.Count == 0)
            {
                MessageBox.Show("�S���i�Ϊ����\�ﶵ�C", "���~", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Random random = new Random();
            int index = random.Next(dinnerOptions.Count);
            string selectedDinner = dinnerOptions[index];

            lblResult.Text = $"{selectedDinner}";
        }
        // �x�s
        private void BtnAddDinner_Click(object sender, EventArgs e)
        {
            string newDinner = Microsoft.VisualBasic.Interaction.InputBox("�п�J�s�����\�ﶵ�G", "�s�W���\", "");
            if (!string.IsNullOrWhiteSpace(newDinner))
            {
                dinnerOptions.Add(newDinner);
                SaveDinner();
                MessageBox.Show($"�w�s�W '{newDinner}' ����\�ﶵ���C", "���\", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // �R��
        private void BtnDeleteDinner_Click(object sender, EventArgs e)
        {
            if (dinnerOptions.Count == 0)
            {
                MessageBox.Show("0�ӱ��\", "���~", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var form = new Form())
            {
                form.Text = "��ܭn�R�������\";
                form.Size = new Size(300, 200);

                var listBox = new ListBox();
                listBox.Dock = DockStyle.Fill;
                listBox.DataSource = new List<string>(dinnerOptions);

                var btnDelete = new Button();
                btnDelete.Text = "�R��";
                btnDelete.Dock = DockStyle.Bottom;
                btnDelete.Click += (s, ev) =>
                {
                    if (listBox.SelectedItem != null)
                    {
                        string selectedDinner = listBox.SelectedItem.ToString();
                        dinnerOptions.Remove(selectedDinner);
                        SaveDinner();
                        form.Close();
                        MessageBox.Show($"�w�R�� '{selectedDinner}'�C", "���\", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                };

                form.Controls.Add(listBox);
                form.Controls.Add(btnDelete);

                form.ShowDialog();
            }
        }
    }
}


