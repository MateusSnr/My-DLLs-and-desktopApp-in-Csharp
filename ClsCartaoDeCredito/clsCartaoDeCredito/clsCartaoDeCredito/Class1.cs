using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsCartaoDeCredito
{
    public class Validacoes
    {
        public static Boolean ValidaCartao(string cartao)
        {
            //Tratamento da string
            cartao = cartao.Replace(".", "").Replace(",", "").Replace("/", "").Replace("-", "").Replace(" ","").Trim();

            if (cartao.Length != 16)
            {
                return false;
            }

            #region Variáveis
            int soma = 0;
            int resto = 0;
            int vezes = 0;
            #endregion

            for(int i = 0;i <= 15; i++)
            {
                if (i % 2 == 0)
                {
                    vezes = int.Parse(cartao.Substring(i, 1)) * 2;
                    if(vezes > 9)
                    {
                        vezes -= 9;
                        soma += vezes;
                    }
                    else
                    {
                        soma += vezes;
                    }
                }
                else if (i % 2 != 0)
                {
                    vezes = int.Parse(cartao.Substring(i, 1)) * 1;
                    if (vezes > 9)
                    {
                        vezes -= 9;
                        soma += vezes;
                    }
                    else
                    {
                        soma += vezes;
                    }
                }    
                
            }
            resto = soma % 10;
            if(resto == 0)
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
