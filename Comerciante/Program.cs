using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comerciante {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, i, baixo, medio, alto;
            double lucro, margen, totalCompra, totalVenda, lucroTotal;

            Console.Write("Serao digitados dados de quantos produtos? ");
            n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            double[] precoCompra = new double[n];
            double[] precoVenda = new double[n];

            for (i = 0; i < n; i++) {//////////////////////////////// ATRIBUIÇOES
                Console.WriteLine("Produto " + (i + 1) + ":");
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Preco por compra: ");
                precoCompra[i] = double.Parse(Console.ReadLine(), CI);
                Console.Write("Preco de venda: ");
                precoVenda[i] = double.Parse(Console.ReadLine(), CI);
            }

            lucro = 0;
            baixo = 0;
            medio = 0;
            alto = 0;
            for (i = 0; i < n; i++) {///////////////////// DEFINE MARGEN DE LUCRO
                lucro = precoVenda[i] - precoCompra[i];
                margen = lucro * 100 / precoCompra[i];
                if (margen < 10) {
                    baixo = baixo + 1;
                }
                else if (margen == 10 || margen < 20) {
                    medio = medio + 1;
                }
                else {
                    alto = alto + 1;
                }
            }

            totalCompra = 0;
            totalVenda = 0;
            for (i = 0; i < n; i++) {///////////////////// TOTAL COMPRA E VENDA
                totalCompra = totalCompra + precoCompra[i];
                totalVenda = totalVenda + precoVenda[i];
            }

            lucroTotal = 0;
            for (i = 0; i < n; i++) {///////////////////// LUCRO TOTAL
                lucro = precoVenda[i] - precoCompra[i];
                lucroTotal = lucroTotal + lucro;
            }

            Console.WriteLine();
            Console.WriteLine("RELATORIO:");
            Console.WriteLine("Lucro abaixo de 10%: " + baixo);
            Console.WriteLine("Lucro entre 10% e 20%: " + medio);
            Console.WriteLine("Lucro acima de 20%: " + alto);
            Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2", CI));
            Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F2", CI));
            Console.WriteLine("Lucro total: " + lucroTotal.ToString("F2", CI));
            Console.WriteLine();
        }
    }
}
