using System;
using System.Windows.Forms;


//[assembly: AssemblyVersion("1.4.0")]
//[assembly: AssemblyMetadata("BuildDate", "2024-06-06")]
namespace Bob_o_extrator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Nome da vari�vel de ambiente do TNS
            const string tnsVariable = "TNS_ADMIN";

            // Verifica se a vari�vel de ambiente j� existe no n�vel do usu�rio
            if (string.IsNullOrEmpty(Environment.GetEnvironmentVariable(tnsVariable, EnvironmentVariableTarget.User)))
            {
                var resposta = MessageBox.Show("Vari�vel de ambiente TNS_ADMIN n�o cadastrada, sua aus�ncia pode causar falha para conectar no banco. Deseja criar?",
                    "Aten��o!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resposta == DialogResult.Yes)
                {
                    // Gambiarra master para reaproveitar a tela de parametros pra pegar o caminho do TNS
                    var parametros = new ParametersForm(":ENDERECO_TNSNAMES.ORA");
                    parametros.ShowDialog();
                    if (!string.IsNullOrEmpty(parametros.query))
                        Environment.SetEnvironmentVariable(tnsVariable, parametros.query, EnvironmentVariableTarget.User);
                }

            }


            Application.Run(new MainForm());
        }
    }
}
