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

            // Nome da variável de ambiente do TNS
            const string tnsVariable = "TNS_ADMIN";

            // Verifica se a variável de ambiente já existe no nível do usuário
            if (string.IsNullOrEmpty(Environment.GetEnvironmentVariable(tnsVariable, EnvironmentVariableTarget.User)))
            {
                var resposta = MessageBox.Show("Variável de ambiente TNS_ADMIN não cadastrada, sua ausência pode causar falha para conectar no banco. Deseja criar?",
                    "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
