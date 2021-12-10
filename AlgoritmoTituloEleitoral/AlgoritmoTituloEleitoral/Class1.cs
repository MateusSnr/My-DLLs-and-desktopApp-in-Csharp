using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoTituloEleitoral
{
    public class ClasseAlgoritmoTituloEleitor
    {
       
        public static Boolean ValidaTE(string te)
        {
            //Variáveis globais
            int somadv1 = 0;
            int somadv2 = 0;
            int dv1 = 0;
            int dv2 = 0;

            //Tratamento da string
            te = te.Replace(".", "").Replace(",", "").Replace("/", "").Replace("-", "").Trim();

            //Verifica o tamanho do numero do titulo e insere "zeros" até completar os 12 algarismos
            if(te.Length != 12)
            {
                for(int i = 0; i < 13 - te.Length; i++)
                {
                    te = te.Insert(i, "0");
                }
            }

            //Soma e calculo do resto da sequencia inicial de numeros
            for(int i = 0; i <=7; i++)
            {
                somadv1 += (int.Parse(te.Substring(i, 1)) * (i+2));
            }

            dv1 = somadv1 % 11;

            //Soma e calculo do resto da sequencia final de numeros
            for (int i = 8; i <= 10; i++)
            {
                somadv2 += (int.Parse(te.Substring(i, 1)) * (i - 1));
            }

            dv2 = somadv2 % 11;

            //Se houver exceção
            if(dv2 == 0 && ((int.Parse(te.Substring(9,1))==1 ) || (int.Parse(te.Substring(9,1))==2)))
            {
                dv2 = 1;
            }

            //Retornando a verificação
            if (dv1 == (int.Parse(te.Substring(10, 1))) && dv2 == (int.Parse(te.Substring(11, 1))))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
