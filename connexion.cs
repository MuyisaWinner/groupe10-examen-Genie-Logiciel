namespace ProjetGroupe10
{
    public partial class connexion : Form
    {
        public connexion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void connexion_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {

            if(txtUserName.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                try {
                    var con = DbManager.Instance;
                    con.user = txtUserName.Text;
                    con.password = txtPassword.Text;
                    con.initialise();
                    
                    var result = con.Connect();
                    if(result)
                    {
                        MessageBox.Show("Connexion réussis", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.None);

                    }
                    else
                    {
                        MessageBox.Show("Connexion echouer", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch (Exception) {
                    MessageBox.Show("Une erreur s'est produite ", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Entrer vos identifiant !", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
