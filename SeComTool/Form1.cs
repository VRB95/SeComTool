using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeComTool
{
    public partial class Form1 : Form
    {
        
        public int preambles = 6;
        public String byteCount = "";
        public String[] hexfloatArray = new String[4];
        string newLine = Environment.NewLine;
        public const string HexLetters = "0123456789abcdefABCDEF\b/";
        public Form1()
        {
            InitializeComponent();
            numUDPreambles.Value = preambles;
            for (int i = 0; i < hexfloatArray.Length; i++)
                hexfloatArray[i] = "";
            txtHex1.ReadOnly = true;
            txtHex2.ReadOnly = true;
            txtHex3.ReadOnly = true;
            txtHex4.ReadOnly = true;
            txtFloat5.ReadOnly = true;
            txtFloat6.ReadOnly = true;
            txtFloat7.ReadOnly = true;
            txtFloat8.ReadOnly = true;
            txtobjHex1.ReadOnly = true;
            txtobjDec2.ReadOnly = true;

            // Define the border style of the form to a dialog box.
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Set the MaximizeBox to false to remove the maximize box.
            this.MaximizeBox = false;

            // Set the MinimizeBox to false to remove the minimize box.
            this.MinimizeBox = false;

            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            getAllText();
        }

        private void getAllText()
        {
            preambles = Convert.ToInt32(numUDPreambles.Value);
            String delimiter = "";
            if (!String.IsNullOrWhiteSpace(txtDelimiter.Text))
                delimiter = txtDelimiter.Text;
            String address = "";
            if (!String.IsNullOrWhiteSpace(txtDelimiter.Text))
                address = txtAddress.Text;
            String command = "";
            if (!String.IsNullOrWhiteSpace(txtCommand.Text))
                command = DecToHex(txtCommand.Text);
            if (!String.IsNullOrWhiteSpace(txtByteCount.Text))
                byteCount = txtByteCount.Text;
            String data = "";
            if (!String.IsNullOrWhiteSpace(txtData.Text))
                data = txtData.Text;
            
            String result = formTelegram(preambles, delimiter, address, command, byteCount, data);

            txtTelegramPreview.Text = result + newLine;

        }
        private string formTelegram(int preambles, string delimiter, string address, string command, string byteCount, string data)
        {
            calculateFloatToHex();
            String telegram = "";

            telegram += delimiter;
            address = address.Replace(" ", "");
            telegram += address;
            telegram += command;
            data = data.Replace(" ", "");
            String dataParsed = dataParser(data);
            //after data is parsed the bytecount need to be recalcualted
            String byteCountAfterParsed = getByteCount(dataParsed);
            telegram += byteCountAfterParsed;
            txtByteCount.Text = byteCountAfterParsed;
            telegram += dataParsed;
            telegram = telegram.Replace(" ", "");

            //Handle Checksum
            byte[] hexByteArray = ConvertHexadecimalStringToByteArray(telegram);
            Byte checksum = calculateCheckSum(hexByteArray);

            String str_checksum = DecToHex(checksum.ToString());
            txtCheckSum.Text = str_checksum;
            telegram += str_checksum;
            
            //Handle Preambles
            String preamblesBuffer = "";
            for (int i = 0; i < preambles; i++)
            {
                preamblesBuffer += "FF";
            }
            telegram = preamblesBuffer + telegram;

            //return
            return ProcessString(telegram);
        }

        public static byte[] ConvertHexadecimalStringToByteArray(string hexadecimalString)
        {
            if (hexadecimalString.Length % 2 != 0)
            {
                throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, "HexaDecimal cannot have an odd number of digits: {0}", hexadecimalString));
            }

            byte[] hexByteArray = new byte[hexadecimalString.Length / 2];
            for (int index = 0; index < hexByteArray.Length; index++)
            {
                string byteValue = hexadecimalString.Substring(index * 2, 2);
                hexByteArray[index] = byte.Parse(byteValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            }

            return hexByteArray;
        }

        private static byte calculateCheckSum(byte[] byteData)
        {
            Byte chkSumByte = 0x00;
            for (int i = 0; i < byteData.Length; i++)
                chkSumByte ^= byteData[i];
            return chkSumByte;
        }

       static string ProcessString(string input)
        {
            StringBuilder buffer = new StringBuilder(input.Length * 3 / 2);
            for (int i = 0; i < input.Length; i++)
            {
                if ((i > 0) & (i % 2 == 0))
                    buffer.Append(" ");
                buffer.Append(input[i]);
            }
            return buffer.ToString();
        }

        public string DecToHex(string num)
        {
            int decValue = Int32.Parse(num);
            String hexValue = decValue.ToString("x");
            int lengthOfHexValue = hexValue.Length;

            if (lengthOfHexValue % 2 == 0)
            {
                return hexValue;
            }
            else
            {
                return "0" + hexValue;
            }
        }

        // HANDLE TEXT INPUT FROM ADDRESS TEXTBOX
        public int addressCharCounter = 0;
        public char wasBackspacePressed;
        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            wasBackspacePressed = e.KeyChar;
            if (!HexLetters.Contains(e.KeyChar)) e.Handled = true;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            int selectionIndex = txtAddress.SelectionStart;
            int chars = txtAddress.Text.Length;
            int dataCharCounter = chars % 3;
            if (dataCharCounter == 2 && wasBackspacePressed != 0x08)
            {
                txtAddress.Text = txtAddress.Text.Insert(selectionIndex, " ");
                txtAddress.SelectionStart = selectionIndex + 1; // restore cursor position
            }
            if (chars > 1)
            {
                if (dataCharCounter == 0 && wasBackspacePressed == 0x08)
                {
                    txtAddress.Text = txtAddress.Text.Remove(chars - 1);
                    txtAddress.SelectionStart = selectionIndex + 1;
                }
            }
        }
        // HANDLE TEXT INPUT FROM DATA TEXTBOX
        public int dataCharCounter = 0;
        private void txtData_KeyPress(object sender, KeyPressEventArgs e)
        {
            wasBackspacePressed = e.KeyChar;
            if (!HexLetters.Contains(e.KeyChar)) e.Handled = true;
        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {
            int selectionIndex = txtData.SelectionStart;
            int chars = txtData.Text.Length;
            int dataCharCounter = chars % 3;
            if (dataCharCounter == 2 && wasBackspacePressed != 0x08)
            {
                txtData.Text = txtData.Text.Insert(selectionIndex, " ");
                txtData.SelectionStart = selectionIndex + 1; // restore cursor position
            }
            if (chars > 1)
            {
                if (dataCharCounter == 0 && wasBackspacePressed == 0x08)
                {
                    txtData.Text = txtData.Text.Remove(chars - 1);
                    txtData.SelectionStart = selectionIndex + 1;
                }
            }

            /* int lengthOfData = (txtData.Text.Count(x => !Char.IsWhiteSpace(x)))/2;

             if (lengthOfData < 10)
             {
                 txtByteCount.Text = "0" + lengthOfData.ToString();

             }
             else
             {
                 txtByteCount.Text = lengthOfData.ToString();
             }*/
            txtByteCount.Text = getByteCount(txtData.Text);

        }
        private string getByteCount(string data)
        {
            String tempData = data;
            int lengthOfData = (tempData.Count(x => !Char.IsWhiteSpace(x))) / 2;

            if (lengthOfData < 10)
            {
                return "0" + lengthOfData.ToString();

            }
            else
            {
                return lengthOfData.ToString();
            }
        }

        private void ckBoxFloat1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private string ToHexString(float f, bool swap)
        {
            byte[] bytes = BitConverter.GetBytes(f);
            if (swap)
                Array.Reverse(bytes);
            var i = BitConverter.ToInt32(bytes, 0);
            return ProcessString(i.ToString("X8"));
        }
        private float FromHexString(string s)
        {
            String sb = s.Replace(" ", "");
            var i = Convert.ToInt32(sb, 16);
            var bytes = BitConverter.GetBytes(i);
            return BitConverter.ToSingle(bytes, 0);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
    
            calculateFloatToHex();
            String data = txtData.Text;
            data = data.Replace(" ", "");
            String dataPreview = dataParser(data);
            txtTelegramPreview.Text = ProcessString(dataPreview + newLine);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            calculateFloatToHex();
            calculateHexToFloat();
            calculateObjToHex();
            calculateHexToObj();
        }
        private void calculateObjToHex()
        {
            if (!String.IsNullOrWhiteSpace(txtobjDec1.Text))
            {
                int decValue = Int32.Parse(txtobjDec1.Text);
                String hexValue = decValue.ToString("X");
                int lengthOfHexValue = hexValue.Length;

                if (lengthOfHexValue % 2 == 0)
                {
                    txtobjHex1.Text = ProcessString(hexValue);
                }
                else
                {
                    txtobjHex1.Text = ProcessString("0" + hexValue);
                }
            }
        }
        private void calculateHexToObj()
        {
            if (!String.IsNullOrWhiteSpace(txtobjHex2.Text))
            {
                String value = txtobjHex2.Text.Replace(" ", "");
                int decValue = Convert.ToInt32(value, 16);
                txtobjDec2.Text = decValue.ToString();
            }
        }
        private void calculateFloatToHex()
        {
            if (!String.IsNullOrWhiteSpace(txtFloat1.Text))
            {
                float value = float.Parse(txtFloat1.Text, CultureInfo.InvariantCulture.NumberFormat);
                bool isSwapEndianness = Convert.ToBoolean(ckBoxFloat1.CheckState);
                hexfloatArray[0] = ToHexString(value, isSwapEndianness);
                txtHex1.Text = hexfloatArray[0];
            }
            if (!String.IsNullOrWhiteSpace(txtFloat2.Text))
            {
                float value = float.Parse(txtFloat2.Text, CultureInfo.InvariantCulture.NumberFormat);
                bool isSwapEndianness = Convert.ToBoolean(ckBoxFloat2.CheckState);
                hexfloatArray[1] = ToHexString(value, isSwapEndianness);
                txtHex2.Text = hexfloatArray[1];
            }
            if (!String.IsNullOrWhiteSpace(txtFloat3.Text))
            {
                float value = float.Parse(txtFloat3.Text, CultureInfo.InvariantCulture.NumberFormat);
                bool isSwapEndianness = Convert.ToBoolean(ckBoxFloat3.CheckState);
                hexfloatArray[2] = ToHexString(value, isSwapEndianness);
                txtHex3.Text = hexfloatArray[2];
            }
            if (!String.IsNullOrWhiteSpace(txtFloat4.Text))
            {
                float value = float.Parse(txtFloat4.Text, CultureInfo.InvariantCulture.NumberFormat);
                bool isSwapEndianness = Convert.ToBoolean(ckBoxFloat4.CheckState);
                hexfloatArray[3] = ToHexString(value, isSwapEndianness);
                txtHex4.Text = hexfloatArray[3];
            }
        }
        private void calculateHexToFloat()
        {
            if (!String.IsNullOrWhiteSpace(txtHex5.Text))
            {
                String value = txtHex5.Text;
                float result = FromHexString(value);
                txtFloat5.Text = result.ToString();
            }
            if (!String.IsNullOrWhiteSpace(txtHex6.Text))
            {
                String value = txtHex6.Text;
                float result = FromHexString(value);
                txtFloat6.Text = result.ToString();
            }
            if (!String.IsNullOrWhiteSpace(txtHex7.Text))
            {
                String value = txtHex7.Text;
                float result = FromHexString(value);
                txtFloat7.Text = result.ToString();
            }
            if (!String.IsNullOrWhiteSpace(txtHex8.Text))
            {
                String value = txtHex8.Text;
                float result = FromHexString(value);
                txtFloat8.Text = result.ToString();
            }
        }
        private string dataParser(string input)
        {
            string s = input;
            string[] tokens = s.Split(new[] { "//" }, StringSplitOptions.None);
            StringBuilder sb = new StringBuilder();

            int counter = 0;
            for (int i = 0; i < tokens.Length; i++)
            {
                sb.Append(tokens[i]);
                if (i < tokens.Length - 1)
                    sb.Append(hexfloatArray[counter++]);
            }

            return sb.ToString().Replace(" ", "");
        }

        private void ckBoxHex1_CheckedChanged(object sender, EventArgs e)
        {

            if (!String.IsNullOrWhiteSpace(txtHex5.Text))
            {
                bool isSwapEndianness = Convert.ToBoolean(ckBoxHex1.CheckState);
                String value = txtHex5.Text.Replace(" ", "");
                if (isSwapEndianness)
                {
                   
                    String result = LittleEndian(value);
                    txtHex5.Text = result;
                }
                else
                {
                    String result = BigEndian(value);
                    txtHex5.Text = result;

                }
            }
        }

        

        private void ckBoxHex2_CheckedChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtHex6.Text))
            {
                bool isSwapEndianness = Convert.ToBoolean(ckBoxHex2.CheckState);
                String value = txtHex6.Text.Replace(" ", "");
                if (isSwapEndianness)
                {

                    String result = LittleEndian(value);
                    txtHex6.Text = result;
                }
                else
                {
                    String result = BigEndian(value);
                    txtHex6.Text = result;

                }
            }
        }

        private void ckBoxHex3_CheckedChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtHex7.Text))
            {
                bool isSwapEndianness = Convert.ToBoolean(ckBoxHex3.CheckState);
                String value = txtHex7.Text.Replace(" ", "");
                if (isSwapEndianness)
                {

                    String result = LittleEndian(value);
                    txtHex7.Text = result;
                }
                else
                {
                    String result = BigEndian(value);
                    txtHex7.Text = result;

                }
            }
        }

        private void ckBoxHex4_CheckedChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtHex8.Text))
            {
                bool isSwapEndianness = Convert.ToBoolean(ckBoxHex4.CheckState);
                String value = txtHex8.Text.Replace(" ", "");
                if (isSwapEndianness)
                {

                    String result = LittleEndian(value);
                    txtHex8.Text = result;
                }
                else
                {
                    String result = BigEndian(value);
                    txtHex8.Text = result;

                }
            }
        }

        private static string BigEndian(string num)
        {
            String hexadecimalString = num.Replace(" ", "");
            String buffer = "";
            int counter = hexadecimalString.Length - 2;
            for (int index = 0; index < hexadecimalString.Length / 2; index++)
            {
                string byteValue = hexadecimalString.Substring(counter, 2);
                buffer += byteValue;
                counter -= 2;
            }
            return ProcessString(buffer);
        }

        private static string LittleEndian(string num)
        {
            int number = Convert.ToInt32(num, 16);
            byte[] bytes = BitConverter.GetBytes(number);
            string retval = "";
            foreach (byte b in bytes)
                retval += b.ToString("X2");
            return ProcessString(retval);
        }
        // HANDLE HEX TEXTBOX
        public int txthex5CharCounter = 0;
        public int txthex6CharCounter = 0;
        public int txthex7CharCounter = 0;
        public int txthex8CharCounter = 0;


        private void txtHex5_KeyPress(object sender, KeyPressEventArgs e)
        {
            wasBackspacePressed = e.KeyChar;
           // if (!HexLetters.Contains(e.KeyChar)) e.Handled = true;
        }

        private void txtHex6_KeyPress(object sender, KeyPressEventArgs e)
        {
            wasBackspacePressed = e.KeyChar;
           // if (!HexLetters.Contains(e.KeyChar)) e.Handled = true;
        }

        private void txtHex7_KeyPress(object sender, KeyPressEventArgs e)
        {
            wasBackspacePressed = e.KeyChar;
           // if (!HexLetters.Contains(e.KeyChar)) e.Handled = true;
        }

        private void txtHex8_KeyPress(object sender, KeyPressEventArgs e)
        {
            wasBackspacePressed = e.KeyChar;
           // if (!HexLetters.Contains(e.KeyChar)) e.Handled = true;
        }

        private void txtHex5_TextChanged(object sender, EventArgs e)
        {
            int selectionIndex = txtHex5.SelectionStart;
            int chars = txtHex5.Text.Length;
            int dataCharCounter = chars % 3;
            if (dataCharCounter == 2 && wasBackspacePressed != 0x08)
            {
                txtHex5.Text = txtHex5.Text.Insert(selectionIndex, " ");
                txtHex5.SelectionStart = selectionIndex + 1; // restore cursor position
            }
            if (chars > 1)
            {
                if (dataCharCounter == 0 && wasBackspacePressed == 0x08)
                {
                    txtHex5.Text = txtHex5.Text.Remove(chars - 1);
                    txtHex5.SelectionStart = selectionIndex + 1;
                }
            }
        }

        private void txtHex6_TextChanged(object sender, EventArgs e)
        {
            int selectionIndex = txtHex6.SelectionStart;
            int chars = txtHex6.Text.Length;
            int dataCharCounter = chars % 3;
            if (dataCharCounter == 2 && wasBackspacePressed != 0x08)
            {
                txtHex6.Text = txtHex6.Text.Insert(selectionIndex, " ");
                txtHex6.SelectionStart = selectionIndex + 1; // restore cursor position
            }
            if (chars > 1)
            {
                if (dataCharCounter == 0 && wasBackspacePressed == 0x08)
                {
                    txtHex6.Text = txtHex6.Text.Remove(chars - 1);
                    txtHex6.SelectionStart = selectionIndex + 1;
                }
            }
        }

        private void txtHex7_TextChanged(object sender, EventArgs e)
        {
            int selectionIndex = txtHex7.SelectionStart;
            int chars = txtHex7.Text.Length;
            int dataCharCounter = chars % 3;
            if (dataCharCounter == 2 && wasBackspacePressed != 0x08)
            {
                txtHex7.Text = txtHex7.Text.Insert(selectionIndex, " ");
                txtHex7.SelectionStart = selectionIndex + 1; // restore cursor position
            }
            if (chars > 1)
            {
                if (dataCharCounter == 0 && wasBackspacePressed == 0x08)
                {
                    txtHex7.Text = txtHex7.Text.Remove(chars - 1);
                    txtHex7.SelectionStart = selectionIndex + 1;
                }
            }
        }

        private void txtHex8_TextChanged(object sender, EventArgs e)
        {
            int selectionIndex = txtHex8.SelectionStart;
            int chars = txtHex8.Text.Length;
            int dataCharCounter = chars % 3;
            if (dataCharCounter == 2 && wasBackspacePressed != 0x08)
            {
                txtHex8.Text = txtHex8.Text.Insert(selectionIndex, " ");
                txtHex8.SelectionStart = selectionIndex + 1; // restore cursor position
            }
            if (chars > 1)
            {
                if (dataCharCounter == 0 && wasBackspacePressed == 0x08)
                {
                    txtHex8.Text = txtHex8.Text.Remove(chars - 1);
                    txtHex8.SelectionStart = selectionIndex + 1;
                }
            }
        }

        private void txtobjHex2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!HexLetters.Contains(e.KeyChar)) e.Handled = true;
        }

        private void txtobjDec1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtFloat1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFloat1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void txtFloat2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void txtFloat3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void txtFloat4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void deviceVariableUnitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form unitsDataGrid = new DVUnits();
            unitsDataGrid.Show();
        }

        private void deviceVariableClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form classDataGrid = new DVClass();
            classDataGrid.Show();
        }
    }
}
