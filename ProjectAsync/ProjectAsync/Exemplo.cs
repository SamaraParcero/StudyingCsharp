using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAsync
{
    internal class Exemplo
    {
        //Mesma sequência e aguarda tarefa anterior ser concluída -> Risco lentidão
        bool Task_TResult()
        {
            return DateTime.IsLeapYear(DateTime.Now.Year);
        }

        //Método com retorno void
        void Task_Void()
        {
            Task.Delay(2000);
            Form1.listResult.Items.Add("Tarefa longa executada");
        }

        public void Task_LongaDuracao()
        {
            bool isAnoBissexto = Task_TResult();

            Form1.listResult.Items.Add($"{DateTime.Now.Year} {(isAnoBissexto? " é " : " não é ")} um ano bissexto");
            Task_Void();
        }
    }
}
