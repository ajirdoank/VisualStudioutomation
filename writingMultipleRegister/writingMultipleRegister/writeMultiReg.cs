using System;
using System.IO.Ports;
using System.Windows.Forms;
using Modbus.Device;
using Modbus.Utility;


namespace writingMultipleRegister
{
    public partial class writeMultipleReg : Form
    {
        private SerialPort serialPort = null;

        public writeMultipleReg()
        {
            InitializeComponent();
        }

        private void writeMultipleReg_Load(object sender, EventArgs e)
        {
            try
            {
                serialPort = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSendMultiReg_Click(object sender, EventArgs e)
        {
            try
            {
                IModbusMaster masterRTU = ModbusSerialMaster.CreateRtu(serialPort);
                byte slaveId = 1;
                ushort startAdd = 40001;
                string[] strArray = textBox1.Text.Split(',');
                float[] floatArray = new float[strArray.Length];

                for (int i = 0; i < strArray.Length; i++)
                {
                    floatArray[i] = float.Parse(strArray[1]);
                }

                ushort[] data = ModbusUtility.convertFloatArrayToShortArray(floatArray);
                masterRTU.WriteMultipleRegisters(slaveId, startAdd, data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "error2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
