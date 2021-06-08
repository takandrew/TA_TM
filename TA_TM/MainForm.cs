using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_TM
{
    public partial class MainForm : Form
    {
        List<object> alphabetList = new List<object>();
        int currentColumn = 1;
        public MainForm()
        {
            InitializeComponent();
            AddColumnTableButton.Enabled = false;
            DeleteColumnTableButton.Enabled = false;
            StartButton.Enabled = false;
            MaximizeBox = false;
        }

        private bool GetData(TextBox textBox, List<object> dataList)
        {
            try
            {
                string dataString = textBox.Text;
                string[] splittedDataString = dataString.Split(' ');
                int zero = 0;
                int countSpaces = zero;
                for (int i = 0; i < splittedDataString.Length; i++)
                {
                    if (splittedDataString[i] != "")
                    {
                        countSpaces++;
                    }
                }
                if (countSpaces == zero)
                {
                    MessageBox.Show("Исходные данные отсутствуют", "Внимание!");
                    return false;
                }
                for (int i = 0; i < splittedDataString.Length; i++)
                {
                    for (int k = i+1; k < splittedDataString.Length; k++)
                    {
                        if (splittedDataString[i] == splittedDataString[k])
                        {
                            splittedDataString[i] = "";
                            countSpaces--;
                            break;
                        }
                    }
                }
                string[] withoutSpacesDataString = new string[countSpaces];
                int j = 0;
                for (int i = 0; i < splittedDataString.Length; i++)
                {
                    if (splittedDataString[i] != "")
                    {
                        withoutSpacesDataString[j] = splittedDataString[i];
                        j++;
                    }
                }
                for (int i = 0; i < withoutSpacesDataString.Length; i++)
                {
                    dataList.Add(withoutSpacesDataString[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода");
                return false;
            }
            return true;
        }

        private void AlphabetButton_Click(object sender, EventArgs e)
        {
            alphabetList.Clear();
            TableGridView.Rows.Clear(); TableGridView.Columns.Clear();
            CommandGridView.Rows.Clear(); CommandGridView.Columns.Clear();
            if (GetData(AlphabetTextBox, alphabetList))
            {
                AddColumnTableButton.Enabled = true;
                DeleteColumnTableButton.Enabled = true;
                StartButton.Enabled = true;
                TableGridView.Columns.Add("", "");
                TableGridView.Columns.Add("Q1", "Q1");
                for (int i = 0; i < alphabetList.Count; i++)
                    TableGridView.Rows.Add(alphabetList[i]);
                TableGridView.Rows.Add("");
                for (int i = -alphabetList.Count*10; i <= alphabetList.Count*10; i++)
                    CommandGridView.Columns.Add("", "");
                CommandGridView.Rows.Add("", "");
                CommandGridView.Rows.Add("", "");
            }
            else
            {
                AddColumnTableButton.Enabled = false;
                DeleteColumnTableButton.Enabled = false;
                StartButton.Enabled = false;
            }
        }

        private void AddColumnTableButton_Click(object sender, EventArgs e)
        {
            string columnName = "Q" + TableGridView.Columns.Count;
            TableGridView.Columns.Add(columnName, columnName);
        }

        private void DeleteColumnTableButton_Click(object sender, EventArgs e)
        {
            if (TableGridView.Columns.Count != 2)
            {
                string columnName = "Q" + (TableGridView.Columns.Count-1);
                TableGridView.Columns.Remove(columnName);
            }
        }

        private void CommandGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int j = 0; j < CommandGridView.Rows[0].Cells.Count; j++)
                CommandGridView.Rows[0].Cells[j].Value = null;
            int i = CommandGridView.CurrentCell.ColumnIndex;
            CommandGridView.Rows[0].Cells[i].Value = "*";
            currentColumn = 1;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            int pointer = -1;
            for (int i = 0; i < CommandGridView.Rows[0].Cells.Count; i++)
                if ((CommandGridView.Rows[0].Cells[i].Value != null)
                    && (CommandGridView.Rows[0].Cells[i].Value.ToString() == "*"))
                {
                    pointer = i;
                    break;
                }
            if (pointer != -1)
            {
                object currentState = CommandGridView.Rows[1].Cells[pointer].Value;
                if (!alphabetList.Contains(currentState))
                {
                    MessageBox.Show("Лента содержит символ, не содержащийся в алфавите", "Ошибка!");
                    return;
                }
                int currentIndex = -1;
                for (int i = 0; i < TableGridView.RowCount; i++)
                {
                    if (TableGridView.Rows[i].Cells[0].Value.ToString() == currentState.ToString())
                    {
                        currentIndex = i;
                        break;
                    }
                }
                if (TableGridView.Rows[currentIndex].Cells[currentColumn].Value == null)
                {
                    MessageBox.Show("Ячейка не содержит команды", "Ошибка!");
                    return;
                }
                TableGridView.Rows[currentIndex].Cells[currentColumn].Selected = true;
                string[] currentCommand = TableGridView.Rows[currentIndex].Cells[currentColumn].Value.ToString().Split(' ');
                if (currentCommand.Length != 3)
                {
                    MessageBox.Show("Команда введена некорректно", "Ошибка!");
                    return;
                }
                if (!alphabetList.Contains(currentCommand[0]))
                {
                    MessageBox.Show("Команда введена некорректно", "Ошибка!");
                    return;
                }
                CommandGridView.Rows[1].Cells[pointer].Value = currentCommand[0];
                if (currentCommand[1] == "R")
                {
                    if (pointer != CommandGridView.Columns.Count)
                    {
                        CommandGridView.Rows[0].Cells[pointer].Value = "";
                        CommandGridView.Rows[0].Cells[pointer + 1].Value = "*";
                    }
                    else
                    {
                        MessageBox.Show("Команда введена некорректно. \n Ячейка является крайней справа.", "Ошибка!");
                        return;
                    }
                }
                else if (currentCommand[1] == "L")
                {
                    if (pointer != 0)
                    {
                        CommandGridView.Rows[0].Cells[pointer].Value = "";
                        CommandGridView.Rows[0].Cells[pointer - 1].Value = "*";
                    }
                    else
                    {
                        MessageBox.Show("Команда введена некорректно. \n Ячейка является крайней слева.", "Ошибка!");
                        return;
                    }
                }
                else if (currentCommand[1] == "S")
                {

                }
                else
                {
                    MessageBox.Show("Корректный вид команды в ячейке: \n " +
                        "значение, на которое нужно заменить (должно содержаться в алфавите) \n" +
                        "смещение (L - влево, R - вправо, S - остаться на месте) \n" +
                        "номер состояния (Если нужно Q2, то пишем 2)", "Ошибка!");
                    return;
                }
                currentColumn = Convert.ToInt32(currentCommand[2]);
                if ((currentColumn <= 0) && (currentColumn > TableGridView.Columns.Count))
                {
                    MessageBox.Show("Команда введена некорректно. \n Состояние некорректно", "Ошибка!");
                    currentColumn = 1;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Необходимо установить указатель ленты на начало выполнения команды", "Ошибка!");
            }
        }
    }
}
