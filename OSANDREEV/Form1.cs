using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSANDREEV
{
    public partial class Form1 : Form
    {
        private object queueLock = new object();
        public Queue<TaskOS> queueOne = new Queue<TaskOS>();
        public Queue<TaskOS> queueTwo = new Queue<TaskOS>();
        public Queue<TaskOS> queueNew = new Queue<TaskOS>();
        public Queue<TaskOS> queueBlocked = new Queue<TaskOS>();
        public Queue<TaskOS> queueBlocked2 = new Queue<TaskOS>();
        public Processor[] CPUs = new Processor[3];

        public Queue<TaskOS> activeQueue;
        public Queue<TaskOS> passiveQueue;

        public volatile bool isModelOn = false;
        public volatile bool isAutoOn = false;
        int id = 0;
        public int speedOSint;
        public async void  planner()
        {
            while (true)
            {
                while (isModelOn)
                {
                    lock (queueLock)
                    {
                        //добавление новых задач
                        while (queueNew.Count != 0)
                        {
                            passiveQueue.Enqueue(queueNew.Dequeue());
                        }
                        /////////////////////
                        
                        //блокировка разблокировка
                        while (queueBlocked.Count != 0)
                        {
                            TaskOS p = queueBlocked.Peek();
                            if (p.COMMAND == status.Blocked)
                            {
                                queueBlocked2.Enqueue(queueBlocked.Dequeue());
                            }
                            else
                            {
                                passiveQueue.Enqueue(queueBlocked.Dequeue());
                            }
                        }
                        changeQueues(ref queueBlocked, ref queueBlocked2);
                        //////////////////////////
                        if(activeQueue.Count == 0 && passiveQueue.Count != 0)
                        {
                            while(passiveQueue.Count != 0)
                            {
                                if(passiveQueue.Peek().COMMAND != status.Blocked)
                                {
                                activeQueue.Enqueue(passiveQueue.Dequeue());
                                }
                                else
                                {
                                    queueBlocked.Enqueue(passiveQueue.Dequeue());
                                }
                            }
                        }

                        // удаление выполненных
                        foreach (TaskOS X in activeQueue)
                        {
                            if (X == null) break;
                            if (X.COMMAND == status.Completed) DeleteRowById(X.TASK_ID);
                        }
                    }







                    //
                    //while (activeQueue.Count != 0)
                    //{
                    //    List<Task> tasks = new List<Task>();

                    //    foreach (Processor cpu in CPUs)
                    //    {
                    //        if (activeQueue.Count == 0) break;

                    //        tasks.Add(Task.Run(() =>
                    //        {
                    //            TaskOS task = null;
                    //            TaskOS peek = null;
                    //            lock (passiveQueue)
                    //            {
                    //                lock (activeQueue )
                    //                {
                    //                    if (activeQueue.Count > 0)
                    //                    {
                    //                        peek = activeQueue.Peek();
                    //                        if(peek.COMMAND == status.Blocked) { queueBlocked.Enqueue(activeQueue.Dequeue()); }
                    //                    }
                    //                    if (passiveQueue.Count > 0)
                    //                    {
                    //                        peek = passiveQueue.Peek();
                    //                        if (peek.COMMAND == status.Blocked) { queueBlocked.Enqueue(passiveQueue.Dequeue()); }
                    //                    }

                    //                    if (activeQueue.Count > 0)
                    //                    {
                    //                        task = activeQueue.Dequeue();
                    //                    }
                    //                    else if (passiveQueue.Count > 0)
                    //                    {
                    //                        task = passiveQueue.Dequeue();
                    //                    }
                    //                    if (task == null) return;
                    //                }

                    //            }

                    //            var result = cpu.doTask(task);
                    //            lock (passiveQueue)
                    //            {
                    //                passiveQueue.Enqueue(result);
                    //            }
                    //        }));
                    //    }
                    //    await Task.WhenAll(tasks);
                    //}
                    //changeQueues(ref activeQueue, ref passiveQueue);

                    //удаление выполненных.
                    //foreach (TaskOS X in activeQueue)
                    //{
                    //    if (X == null) break;
                    //    if (X.COMMAND == status.Completed) DeleteRowById(X.TASK_ID);
                    //}
                }
                Thread.Sleep(300);
            }
            
        }

        public TaskOS giveTask()
        {
            lock (queueLock)
                {
                while(activeQueue.Count != 0)
                {
                    TaskOS peek = null;
                    if (activeQueue.Count > 0)
                    {
                        peek = activeQueue.Peek();
                        if (peek.COMMAND == status.Blocked) { queueBlocked.Enqueue(activeQueue.Dequeue()); }
                    }
                    if (activeQueue.Count != 0 && activeQueue.Peek().COMMAND != status.Blocked)
                    {
                        return activeQueue.Dequeue();
                    }
                }
                return null;
                }
        }

        public Form1()
        {
            activeQueue = queueOne;
            passiveQueue = queueTwo;
            CPUs[0] = new Processor(this, speedOSint, 1);
            CPUs[1] = new Processor(this, speedOSint, 2);
            CPUs[2] = new Processor(this, speedOSint, 3);


            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(() => planner());
            Task.Run(() => AutoAdd());
            Task.Run(() => CPUs[0].run());
            Task.Run(() => CPUs[1].run());
            Task.Run(() => CPUs[2].run());
            
        }

        private void changeQueues(ref Queue<TaskOS> activeQueue, ref Queue<TaskOS> passiveQueue)
        {
            Queue<TaskOS> tempQueue = activeQueue;
            activeQueue = passiveQueue;
            passiveQueue = tempQueue;
        }

        private void addTask_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrWhiteSpace(memory.Text) || string.IsNullOrWhiteSpace(numberOfCommands.Text)) { MessageBox.Show("Значения не должны быть пустыми", "Ошибка", MessageBoxButtons.OK); return; }
            TaskOS task = new TaskOS(++id, int.Parse(memory.Text), int.Parse(numberOfCommands.Text), 0, 0, 0, status.Idle);
            queueNew.Enqueue(task);
            dataGridViewTasks.Rows.Add(task.TASK_ID, task.V_TASK, task.N_CMD, task.currentCommand, task.COMMAND);
        }

        private void memory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void numberOfCommands_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UpdateLabel(Label label, int commandCount)
        {
            if (label.InvokeRequired)
            {
                label.Invoke(new Action(() => label.Text = commandCount.ToString()));
            }
            else
            {
                label.Text = commandCount.ToString();
            }
        }

        public void UpdateCellValue(int id, string columnName, object newValue)
        {
            UpdateLabel(label7, CPUs[0].countOfAllCompletedCommands);
            UpdateLabel(label8, CPUs[1].countOfAllCompletedCommands);
            UpdateLabel(label9, CPUs[2].countOfAllCompletedCommands);

            foreach (DataGridViewRow row in dataGridViewTasks.Rows)
            {
                if (Convert.ToInt32(row.Cells["dgvColumnId"].Value) == id)
                {
                    DataGridViewCell cell = row.Cells[columnName];
                    if (cell != null)
                    {
                        cell.Value = newValue;
                    }
                    break;
                }
            }
        }
        private void DeleteRowById(int id)
        {
            if (dataGridViewTasks.InvokeRequired)
            {
                dataGridViewTasks.Invoke(new Action(() => DeleteRowById(id)));
            }
            else
            {
                foreach (DataGridViewRow row in dataGridViewTasks.Rows)
                {
                    if (Convert.ToInt32(row.Cells["dgvColumnId"].Value) == id)
                    {
                        dataGridViewTasks.Rows.Remove(row);
                        break;
                    }
                }
            }
        }
        private void power_Click(object sender, EventArgs e)
        {
            isModelOn = !isModelOn;
        }

        private void speedOS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            speedOSint = trackBar1.Value;
            foreach (Processor cpu in CPUs)
            {
                cpu.speedOS = speedOSint;
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            CPUs[0].speed = trackBar2.Value;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            CPUs[1].speed = trackBar3.Value;
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            CPUs[2].speed = trackBar4.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dataGridViewTasks.CurrentRow;
                int statusColumnIndex = dataGridViewTasks.Columns["dgvColumnStatus"].Index;
                int idColumnIndex = dataGridViewTasks.Columns["dgvColumnId"].Index;
                //selectedRow.Cells[statusColumnIndex].Value = status.Blocked; 
                dataGridViewTasks.Refresh();
                if (selectedRow.Cells[statusColumnIndex].Value == null)
                {
                    return;
                }
                if (selectedRow.Cells[statusColumnIndex].Value.ToString() == status.Blocked)
                {
                    selectedRow.Cells[statusColumnIndex].Value = status.Idle;
                }
                else if(selectedRow.Cells[statusColumnIndex].Value.ToString() == status.Idle)
                {
                    selectedRow.Cells[statusColumnIndex].Value = status.Blocked;
                }

                foreach (TaskOS taskOS in queueOne) 
                {
                    if (int.Parse(selectedRow.Cells[idColumnIndex].Value.ToString()) == taskOS.TASK_ID)
                    {
                        taskOS.COMMAND = selectedRow.Cells[statusColumnIndex].Value.ToString();
                    } 
                };
                foreach (TaskOS taskOS in queueTwo)
                {
                    if (int.Parse(selectedRow.Cells[idColumnIndex].Value.ToString()) == taskOS.TASK_ID)
                    {
                        taskOS.COMMAND = selectedRow.Cells[statusColumnIndex].Value.ToString();
                    }
                };
                foreach (TaskOS taskOS in queueBlocked)
                {
                    if (int.Parse(selectedRow.Cells[idColumnIndex].Value.ToString()) == taskOS.TASK_ID)
                    {
                        taskOS.COMMAND = selectedRow.Cells[statusColumnIndex].Value.ToString();
                    }
                };

            }
            else
            {
                MessageBox.Show("Нет выделенной строки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    return;
                }
                foreach (Processor cpu in CPUs)
                {
                    cpu.quant = int.Parse(textBox1.Text);
                }
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        public void AutoAdd()
        {
            while (true)
            {
                while (isAutoOn)
                {
                    if (string.IsNullOrWhiteSpace(memory.Text) || string.IsNullOrWhiteSpace(numberOfCommands.Text)) { MessageBox.Show("Значения не должны быть пустыми", "Ошибка", MessageBoxButtons.OK); { return; } }
                    TaskOS task = new TaskOS(++id, int.Parse(memory.Text), int.Parse(numberOfCommands.Text), 0, 0, 0, status.Idle);
                    queueNew.Enqueue(task);


                    if (dataGridViewTasks.InvokeRequired)
                    {
                        dataGridViewTasks.Invoke(new Action(() => { dataGridViewTasks.Rows.Add(task.TASK_ID, task.V_TASK, task.N_CMD, task.currentCommand, task.COMMAND); }));
                    }
                    else
                    {
                        dataGridViewTasks.Rows.Add(task.TASK_ID, task.V_TASK, task.N_CMD, task.currentCommand, task.COMMAND);
                    }


                    Thread.Sleep(1000);
                }
            }
        }
        private void addTaskAuto_Click(object sender, EventArgs e)
        {
            isAutoOn = !isAutoOn;
        }
    }
}
