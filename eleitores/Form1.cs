namespace eleitores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {



            int totalVotos;
            int votosBrancos = Convert.ToInt32(txt_votosBrancos.Text);
            int votosValidos = Convert.ToInt32(txt_votosValidos.Text);
            int votosNulos = Convert.ToInt32(txt_votosNulos.Text);


            totalVotos = votosBrancos + votosValidos + votosNulos;



            lbl_Resultado.Text = $"{votosBrancos * 100 / totalVotos} % de votos Brancos \n"; //\n = quebra de linha 
            lbl_Resultado.Text += $"{votosValidos * 100 / totalVotos} % de votos Validos \n"; // += ; adiciona outra coisa na ao chamado sem subisituis o anterior  
            lbl_Resultado.Text += $"{votosNulos * 100 / totalVotos} % de votos Nulos";

        }


    }
}
