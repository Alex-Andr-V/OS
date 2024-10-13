using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSANDREEV
{
    public class TaskOS
    {
        public int TASK_ID;
        public int V_TASK;
        public int N_CMD;
        public int D_IN_OUT;
        public int N_IN_OUT;
        public string COMMAND;
        public int currentCommand;

        public TaskOS(int TASK_Id, int V_TASK, int N_CMD, int currentCommand, int D_IN_OUT, int N_IN_OUT, string COMMAND) 
        {
            this.TASK_ID = TASK_Id;
            this.V_TASK = V_TASK;
            this.N_CMD = N_CMD;
            this.D_IN_OUT = D_IN_OUT;
            this.N_IN_OUT = N_IN_OUT;
            this.COMMAND = COMMAND;
            this.currentCommand = currentCommand;
        }
    }
}
