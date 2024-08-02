using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MitreAttack
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void btn1518_Click(object sender, EventArgs e)
        {
            SaveAttackDatabase("T1518");
        }

        private void btnT1614_Click(object sender, EventArgs e)
        {
            SaveAttackDatabase("T1614");
        }

        public void SaveAttackDatabase(string attackCode)
        {
            string query = "";
            if (attackCode == "T1518")
            {
                query = "reg query \"HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Internet Explorer\" /v svcVersion";
            }
            else if (attackCode == "T1614")
            {
                query = "reg query \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Nls\\Language\"";
            }
            else
            {
                MessageBox.Show("Geçersiz attack ID.");
                return;
            }

            var processInfo = new ProcessStartInfo
            {
                FileName = @"C:\Windows\System32\cmd.exe",
                Arguments = $"/c {query}",
                Verb = "runas", // CMD'yi yönetici olarak çalıştır
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            try
            {
                using (Process process = new Process())
                {
                    process.StartInfo = processInfo;
                    process.Start();
                    string result = process.StandardOutput.ReadToEnd(); // CMD çıktısını oku
                    process.WaitForExit();

                    string connectionString = "Data Source=**IP**\\SQLEXPRESS;Initial Catalog=MitreAttackDB;User Id=MITRE;Password=1234;";


                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string sql = "INSERT INTO ATTACKS (AttackResult, AttackCode) VALUES (@AttackResult, @AttackCode)";
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@AttackResult", result);
                        command.Parameters.AddWithValue("@AttackCode", attackCode);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Veritabanına kayıt yapılamadı: " + ex.Message);
                        }
                    }
                }
            }
            catch (Win32Exception)
            {
                MessageBox.Show("Komut yönetici olarak çalıştırılamadı.");
            }
        }
    }
}
