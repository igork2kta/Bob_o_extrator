﻿using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Bob_o_extrator
{
    public static class Sql
    {
        public static string RemoveSemicolon(string query)
        {
            if (query.LastIndexOf(";") < 1) return query;
            return query.Remove(query.LastIndexOf(";"), 1);
        }

        public static List<string> GetParameters(string query)
        {
            List<string> ocorrencias = new List<string>();

            // Define a expressão regular para encontrar o texto entre ":" e " "
            Regex regex = new Regex(@":([^:\s]+)\s?");

            // Encontra todas as correspondências na entrada
            MatchCollection matches = regex.Matches(query);

            // Itera sobre as correspondências e adiciona o texto encontrado à lista
            foreach (Match match in matches)
            {
                // O texto capturado está na primeira captura do grupo
                string ocorrencia = match.Groups[1].Value;
                ocorrencias.Add(ocorrencia);
            }

            return ocorrencias;
        }

        public static string ReplaceParameters(string input, List<string> ocorrencias, List<string> substitutos)
        {
            for (int i = 0; i < ocorrencias.Count; i++)
            {
                string ocorrenciaOriginal = ":" + ocorrencias[i];

                string textoSubstituto = string.IsNullOrEmpty(substitutos[i]) ? "null" : substitutos[i];
                input = Regex.Replace(input, ocorrenciaOriginal, textoSubstituto);
            }

            return input;
        }



    }
}
