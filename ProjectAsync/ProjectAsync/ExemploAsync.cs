using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAsync
{
    internal class ExemploAsync
    {
        //Não aguarda outras tarefasn para serem concluídas
        async Task<bool> Task_TResult_Async()
        {
            return await Task.FromResult<bool>(DateTime.IsLeapYear(DateTime.Now.Year));
        }

        async Task Task_Void_Async()
        {
            await Task.Delay(2000);
            Form1.listResult.Items.Add("Tarefa longa executada");
        }

        public async Task Task_LongaDuracao()
        {
            bool isAnoBissexto = await Task_TResult_Async();
            Form1.listResult.Items.Add($"{DateTime.Now.Year} {(isAnoBissexto ? " é " : " não é ")} um ano bissexto");
            await Task_Void_Async();
        }
    }
}
