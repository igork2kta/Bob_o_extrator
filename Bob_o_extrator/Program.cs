//using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.IO;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;


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
        static void Main(string[] args)
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

            if (args.Length > 0)
            {

                //BANCO, USUARIO, SENHA, SESSION, PATH, PATH QUERY
                if (args.Length < 6)
                {
                    Console.WriteLine("Número de parâmetros incorreto.");
                    return;
                }
                string query = File.ReadAllText(args[5]);


                DataAcess.Export(args[0], args[1], args[2], args[3], args[4], query);
            }
            else
            {
                Config.Load();
                Application.Run(new MainForm());
            }
               
        }
    }
}
