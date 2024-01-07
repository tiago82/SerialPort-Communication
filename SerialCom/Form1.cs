using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialCom
{
    public partial class MainForm : Form
    {

        //Instanciação do objeto da porta serial
        SerialPort serialPort = new SerialPort();

        String saveDataFile = null;
        FileStream saveDataFS = null;

        public MainForm()
        {
            InitializeComponent();
        }


        // Inicializa as configurações de interface da porta serial

        private void Init_Port_Confs()
        {
            /*------ Configurações da Interface Serial ------*/

            // Verifica se há portas seriais disponíveis
            string[] str = SerialPort.GetPortNames();
            if (str == null)
            {
                //MessageBox.Show("本机没有串口！", "Error");
                MessageBox.Show("Este computador não possui portas seriais!", "Error");
                return;
            }
            //Adiciona as portas seriais disponíveis ao combobox
            foreach (string s in str)
            {
                comboBoxCom.Items.Add(s);
            }
            //Define a primeira porta serial como a selecionada por padrão
            comboBoxCom.SelectedIndex = 0;

            /*------ Configurações de Baud Rate -------*/
            string[] baudRate = { "9600", "19200", "38400", "57600", "115200" };
            foreach (string s in baudRate)
            {
                comboBoxBaudRate.Items.Add(s);
            }
            comboBoxBaudRate.SelectedIndex = 0;

            /*------ Configurações de Data Bit (Bits de Dados) -------*/
            string[] dataBit = { "5", "6", "7", "8" };
            foreach (string s in dataBit)
            {
                comboBoxDataBit.Items.Add(s);
            }
            comboBoxDataBit.SelectedIndex = 3;


            /*------ Configurações de Check Bit (Bit de Paridade) -------*/
            string[] checkBit = { "None", "Even", "Odd", "Mask", "Space" };
            foreach (string s in checkBit)
            {
                comboBoxCheckBit.Items.Add(s);
            }
            comboBoxCheckBit.SelectedIndex = 0;


            /*------ Configurações de Stop Bit (Bit de Parada) -------*/
            string[] stopBit = { "1", "1.5", "2" };
            foreach (string s in stopBit)
            {
                comboBoxStopBit.Items.Add(s);
            }
            comboBoxStopBit.SelectedIndex = 0;

            /*------ Configurações de Formato de Dados -------*/
            radioButtonSendDataASCII.Checked = true;
            radioButtonReceiveDataASCII.Checked = true;
        }

        // Carrega o formulário principal
        private void MainForm_Load(object sender, EventArgs e)
        {

            Init_Port_Confs();

            Control.CheckForIllegalCrossThreadCalls = false;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(dataReceived);


            // Pronto para uso          
            serialPort.DtrEnable = true;
            serialPort.RtsEnable = true;
            // Define o tempo de leitura de dados como 1 segundo
            serialPort.ReadTimeout = 1000;

            serialPort.Close();

            buttonSendData.Enabled = false;

        }


        // Abre ou fecha a porta serial
        private void buttonOpenCloseCom_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)// Se a porta serial estiver fechada
            {
                
                try
                {
                    
                    if (comboBoxCom.SelectedIndex == -1)
                    {
                        //MessageBox.Show("Error: 无效的端口,请重新选择", "Error");
                        MessageBox.Show("Erro: porta inválida, por favor, escolha novamente.", "Error");
                        return;
                    }
                    string strSerialName    = comboBoxCom.SelectedItem.ToString();
                    string strBaudRate      = comboBoxBaudRate.SelectedItem.ToString();
                    string strDataBit       = comboBoxDataBit.SelectedItem.ToString();
                    string strCheckBit      = comboBoxCheckBit.SelectedItem.ToString();
                    string strStopBit       = comboBoxStopBit.SelectedItem.ToString();

                    Int32 iBaudRate = Convert.ToInt32(strBaudRate);
                    Int32 iDataBit  = Convert.ToInt32(strDataBit);

                    serialPort.PortName = strSerialName;// Nome da porta serial
                    serialPort.BaudRate = iBaudRate;// Baud Rate
                    serialPort.DataBits = iDataBit;// Bits de Dados



                    switch (strStopBit)            // Bit de Parada
                    {
                        case "1":
                            serialPort.StopBits = StopBits.One;
                            break;
                        case "1.5":
                            serialPort.StopBits = StopBits.OnePointFive;
                            break;
                        case "2":
                            serialPort.StopBits = StopBits.Two;
                            break;
                        default:
                            //MessageBox.Show("Error：停止位参数不正确!", "Error");
                            MessageBox.Show("Error：Parâmetro de bits de parada incorreto!", "Error");
                            break;
                    }
                    switch (strCheckBit)             // Bit de Paridade
                    {
                        case "None":
                            serialPort.Parity = Parity.None;
                            break;
                        case "Odd":
                            serialPort.Parity = Parity.Odd;
                            break;
                        case "Even":
                            serialPort.Parity = Parity.Even;
                            break;
                        default:
                            //MessageBox.Show("Error：校验位参数不正确!", "Error");
                            MessageBox.Show("Error：Parâmetro de bit de paridade incorreto!", "Error");
                            break;
                    }



                    if (saveDataFile != null)
                    {
                        saveDataFS = File.Create(saveDataFile);
                    }

                    // Abre a porta serial
                    serialPort.Open();

                    // As configurações não serão mais válidas após abrir a porta serial
                    comboBoxCom.Enabled = false;
                    comboBoxBaudRate.Enabled = false;
                    comboBoxDataBit.Enabled = false;
                    comboBoxCheckBit.Enabled = false;
                    comboBoxStopBit.Enabled = false;
                    radioButtonSendDataASCII.Enabled = false;
                    radioButtonSendDataHex.Enabled = false;
                    radioButtonReceiveDataASCII.Enabled = false;
                    radioButtonReceiveDataHEX.Enabled = false;
                    buttonSendData.Enabled = true;
                    Button_Refresh.Enabled = false;

                    //buttonOpenCloseCom.Text = "关闭串口";
                    buttonOpenCloseCom.Text = "Fechar porta serial";

                }
                catch(System.Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Error");
                    return;
                }
            }
            else // Se a porta serial estiver aberta
            {
                
                serialPort.Close();// Fecha a porta serial
                // Configurações válidas quando a porta serial está fechada
                comboBoxCom.Enabled = true;
                comboBoxBaudRate.Enabled = true;
                comboBoxDataBit.Enabled = true;
                comboBoxCheckBit.Enabled = true;
                comboBoxStopBit.Enabled = true;
                radioButtonSendDataASCII.Enabled = true;
                radioButtonSendDataHex.Enabled = true;
                radioButtonReceiveDataASCII.Enabled = true;
                radioButtonReceiveDataHEX.Enabled = true;
                buttonSendData.Enabled = false;
                Button_Refresh.Enabled = true;

                //buttonOpenCloseCom.Text = "打开串口";
                buttonOpenCloseCom.Text = "Abrir porta serial";

                if (saveDataFS != null)
                {
                    saveDataFS.Close(); // 关闭文件
                    saveDataFS = null;//释放文件句柄
                }

            }
        }

        // Recebe os dados
        private void dataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                //MessageBox.Show("sss","OK");
                //输出当前时间
                //DateTime dateTimeNow = DateTime.Now;
                //dateTimeNow.GetDateTimeFormats();
                //textBoxReceive.Text += string.Format("{0}\r\n", dateTimeNow);
                //dateTimeNow.GetDateTimeFormats('f')[0].ToString() + "\r\n";
               // textBoxReceive.ForeColor = Color.Red;    //改变字体的颜色

                if (radioButtonReceiveDataASCII.Checked == true) // Recebe em formato ASCII
                {
                    try
                    {
                        String input = serialPort.ReadLine();
                        textBoxReceive.Text += input + "\r\n";
                        // Salva os dados em um arquivo
                        if (saveDataFS != null)
                        {
                            byte[] info = new UTF8Encoding(true).GetBytes(input + "\r\n");
                            saveDataFS.Write(info, 0, info.Length);
                        }
                    }
                    catch(System.Exception ex)
                    {
                        //MessageBox.Show(ex.Message, "你波特率是不是有问题？？？");
                        MessageBox.Show(ex.Message, "A sua taxa de baud está com algum problema???");
                        return;
                    }
                    
                    textBoxReceive.SelectionStart = textBoxReceive.Text.Length;
                    textBoxReceive.ScrollToCaret();//滚动到光标处
                    serialPort.DiscardInBuffer(); // Limpa o buffer do SerialPort
                }
                else // Recebe em formato HEX
                {
                    try
                    {

                        string input = serialPort.ReadLine();
                        char[] values = input.ToCharArray();
                        foreach (char letter in values)
                        {
                            // Get the integral value of the character.
                            int value = Convert.ToInt32(letter);
                            // Convert the decimal value to a hexadecimal value in string form.
                            string hexOutput = String.Format("{0:X}", value);
                            textBoxReceive.AppendText(hexOutput + " ");
                            textBoxReceive.SelectionStart = textBoxReceive.Text.Length;
                            textBoxReceive.ScrollToCaret();//滚动到光标处
                            //textBoxReceive.Text += hexOutput + " ";

                        }

                        // Salva os dados em um arquivo
                        if (saveDataFS != null)
                        {
                            byte[] info = new UTF8Encoding(true).GetBytes(input + "\r\n");
                            saveDataFS.Write(info, 0, info.Length);
                        }


                    }
                    catch(System.Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                        textBoxReceive.Text = "";// Limpa
                    }
                }
            }
            else
            {
                //MessageBox.Show("请打开某个串口", "错误提示");
                MessageBox.Show("Por favor, abra uma porta serial", "Mensagem de Erro");

            }
        }

        // Envia dados
        private void buttonSendData_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                //MessageBox.Show("请先打开串口", "Error");
                MessageBox.Show("Por favor, abra a porta serial primeiro", "Error");
                return;
            }

            String strSend = textBoxSend.Text;//发送框数据
            if (radioButtonSendDataASCII.Checked == true)// Envia em formato ASCII
            {
                serialPort.WriteLine(strSend);//发送一行数据 

            }
            else
            {
                // Envia em formato HEX

                char[] values = strSend.ToCharArray();
                foreach (char letter in values)
                {
                    // Get the integral value of the character.
                    int value = Convert.ToInt32(letter);
                    // Convert the decimal value to a hexadecimal value in string form.
                    string hexIutput = String.Format("{0:X}", value);
                    serialPort.WriteLine(hexIutput);

                }



            }

        }

        // Limpa a caixa de recepção de dados
        private void buttonClearRecData_Click(object sender, EventArgs e)
        {
            
            textBoxReceive.Text = "";

        }


        // Quando o formulário é fechado
        private void MainForm_Closing(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();// Fecha a porta serial
            }

            if (saveDataFS != null)
            {
                saveDataFS.Close(); // Fecha o arquivo
                saveDataFS = null;// Libera o handle do arquivo
            }

        }

        // Atualiza as portas seriais disponíveis
        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            comboBoxCom.Text = "";
            comboBoxCom.Items.Clear();
            
            string[] str = SerialPort.GetPortNames();
            if (str == null)
            {
                //MessageBox.Show("本机没有串口！", "Error");
                MessageBox.Show("Este computador não tem portas seriais!", "Error");
                return;
            }

            // Adiciona as portas seriais disponíveis ao combobox
            foreach (string s in str)
            {
                comboBoxCom.Items.Add(s);
            }

            // Define a primeira porta serial como a selecionada por padrão
            comboBoxCom.SelectedIndex = 0;
            comboBoxBaudRate.SelectedIndex = 0;
            comboBoxDataBit.SelectedIndex = 3;
            comboBoxCheckBit.SelectedIndex = 0;
            comboBoxStopBit.SelectedIndex = 0;

        }

        // Sair
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();//关闭串口
            }
            if (saveDataFS != null)
            {
                saveDataFS.Close(); // 关闭文件
                saveDataFS = null;//释放文件句柄
            }

            this.Close();
        }

        // Reseta as configurações da porta serial
        private void ResetPortConfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBoxCom.SelectedIndex = 0;
            comboBoxBaudRate.SelectedIndex = 0;
            comboBoxDataBit.SelectedIndex = 3;
            comboBoxCheckBit.SelectedIndex = 0;
            comboBoxStopBit.SelectedIndex = 0;
            radioButtonSendDataASCII.Checked = true;
            radioButtonReceiveDataASCII.Checked = true;

        }

        // Salva os dados recebidos em um arquivo
        private void SaveReceiveDataToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Txt |*.txt";
            //saveFileDialog.Title = "保存接收到的数据到文件中";
            saveFileDialog.Title = "Salvar os dados recebidos em um arquivo";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != null)
            {
                saveDataFile = saveFileDialog.FileName;
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDataBit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxReceiveSetting_Enter(object sender, EventArgs e)
        {

        }
    }
}
