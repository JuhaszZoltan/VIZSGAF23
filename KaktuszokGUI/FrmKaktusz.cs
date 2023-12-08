using Microsoft.Data.SqlClient;

namespace KaktuszokGUI
{
    public partial class FrmKaktusz : Form
    {
        static string connString =
            @"Server=(localdb)\MSSQLLocalDB;" +
            "Database=novenytermesztes;";
        static string[] nehezsegek = { "könnyû", "mérsékelt", "nehéz" };

        public FrmKaktusz()
        {
            InitializeComponent();
            Load += Lekerdezes_Event;
            tbxSzures.TextChanged += Lekerdezes_Event;
            dgvKaktuszok.CellClick += DgvKaktuszok_CellClick;
        }

        private void Lekerdezes_Event(object? sender, EventArgs e)
        {
            dgvKaktuszok.Rows.Clear();
            using SqlConnection conn = new(connString);
            conn.Open();

            SqlCommand sqlCmd = new(
                "SELECT * FROM kaktuszok " +
                $"WHERE nev LIKE '{tbxSzures.Text}%';",
                conn);
            SqlDataReader sqlRdr = sqlCmd.ExecuteReader();

            while (sqlRdr.Read())
            {
                dgvKaktuszok.Rows.Add(
                    sqlRdr[0],
                    sqlRdr[1],
                    sqlRdr[2],
                    nehezsegek[sqlRdr.GetInt32(3) - 1],
                    $"{sqlRdr[4]} ml/h",
                    $"{sqlRdr[5]} lm");
            }
        }

        private void DgvKaktuszok_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            _ = MessageBox.Show(
                caption: "TUDOMÁNYOS NÉV:",
                text: $"{dgvKaktuszok[2, e.RowIndex].Value}");
        }
    }
}