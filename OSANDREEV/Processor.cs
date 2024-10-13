using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace OSANDREEV
{
    internal class Processor
    {
        public int  countOfAllCompletedCommands = 0;
        public int quant = 1000;
        public float speed = 100;
        private Form1 _form;
        public float speedOS = 5000;

        public Processor(Form1 form, int speedOS)
        {
            _form = form;
            this.speedOS = speedOS;
        }

        public TaskOS doTask(TaskOS currentTask) 
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            while (watch.ElapsedMilliseconds < quant)
            {
                currentTask.COMMAND = status.Active;
                _form.UpdateCellValue(currentTask.TASK_ID, "dgvColumnStatus", currentTask.COMMAND);
                if (currentTask.currentCommand < currentTask.N_CMD)
                {
                doCommand();
                countOfAllCompletedCommands++;
                currentTask.currentCommand++;
                _form.UpdateCellValue(currentTask.TASK_ID, "dgvColumnCurrentCommand", currentTask.currentCommand);
                }
                else
                {
                    currentTask.COMMAND = status.Completed;
                    _form.UpdateCellValue(currentTask.TASK_ID, "dgvColumnStatus", currentTask.COMMAND);
                    break;
                }
            }
            watch.Stop();
            if (currentTask.COMMAND != status.Completed)
            {
                currentTask.COMMAND = status.Idle;
                _form.UpdateCellValue(currentTask.TASK_ID, "dgvColumnStatus", currentTask.COMMAND);
            }
            return currentTask;
        }

        public void doCommand()
        {
            Console.WriteLine(speed);
            if(speed == 0 || speedOS == 0)
            {
                Thread.Sleep(Convert.ToInt32(5000 / 100 * 100));
            }
            else Thread.Sleep(Convert.ToInt32(speedOS / speed * 100));

        }
    }
}
