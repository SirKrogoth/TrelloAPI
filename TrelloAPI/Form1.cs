using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace TrelloAPI
{
    public partial class frmPrincipal : Form
    {
        AcessaDadosSQLServer dados = new AcessaDadosSQLServer();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnConectarTrello_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (btnConectarTrello.Text == "Conectar")
                    ConectarBanco();
                else
                    DesconectarBanco();
            }
            catch
            {
                if(btnConectarTrello.Text == "Conectar")
                {
                    MessageBox.Show("Não foi possível conectar-se ao banco de dados",
                                    "Erro ao conectar",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    imgStatus.Image = Properties.Resources.desconectado;
                }
                
            }
        }

        private void ConectarBanco()
        {
            SqlConnection conexao = dados.CriarConexaoBanco();

            conexao.Open();

            imgStatus.Image = Properties.Resources.conectado;
            btnConectarTrello.Text = "Desconectar";
        }

        private void DesconectarBanco()
        {
            SqlConnection conexao = dados.CriarConexaoBanco();

            conexao.Close();

            imgStatus.Image = Properties.Resources.desconectado;
            btnConectarTrello.Text = "Conectar";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var requisicaoWeb = WebRequest.CreateHttp("https://api.trello.com/1/boards/5accca0715c25d76f5bad2e3/cards?key=b61d05d52e25401c1a6875d97f482442&token=a0976b6862cb5d888d2e46e02437843e9848074514ed429a508067ac31561219");
                requisicaoWeb.Method = "GET";
                requisicaoWeb.UserAgent = "RequisicaoWebDemo";

                using (var resp = requisicaoWeb.GetResponse())
                {
                    var streamDados = resp.GetResponseStream();
                    StreamReader streamReader = new StreamReader(streamDados);

                    object objResponse = streamReader.ReadToEnd();
                    var post = JsonConvert.DeserializeObject<List<BoardCards>>(objResponse.ToString());

                    MessageBox.Show("ID: " + post[1].name + " - " + post[1].id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
