namespace Gestor_de_Habitos_Saudaveis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void bt_limpar_Click(object sender, EventArgs e)
        {
            LB_listhabitos.Items.Clear();
        }

        private void bt_marcar_Click(object sender, EventArgs e)
        {
            string habitos = LB_listhabitos.SelectedItem.ToString();
            if (habitos.StartsWith("*"))
            {
                habitos = habitos.Substring(2);
            }
            else
            {
                habitos = "*" + habitos;
                LB_listhabitos.Items[LB_listhabitos.SelectedIndex] = habitos;
            }
        }

        private void BT_aplica_Click(object sender, EventArgs e)
        {
            string habito = TB_habitos.Text;
            string data = CB_regularidades.Text;
            string adicionado = habito + " - " + data;
            LB_listhabitos.Items.Add(adicionado);
            TB_habitos.Clear();
            CB_regularidades.SelectedIndex = -1;
        }
    }
}

