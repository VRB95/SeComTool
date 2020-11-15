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
    public partial class SeComTool : Form
    {
        
        public int preambles = 6;
        public String byteCount = "";
        public String[] hexfloatArray = new String[4];
        public String[] hexfloatArrayGDC = new String[4];
        public int len = 0;
        string newLine = Environment.NewLine;
        public const string HexLetters = "0123456789abcdefABCDEF\b/";
        private DeviceVariables dv = new DeviceVariables();
        private Dictionary<int, string> dv_class_dic = new Dictionary<int, string>();
        private Dictionary<int, string> dv_units_dic = new Dictionary<int, string>();
        private Dictionary<int, int> dv_units_obj_dic = new Dictionary<int, int>();

        public SeComTool()
        {
            InitializeComponent();
            fillComboboxes();
            comboBox_Class.Text = "Select Device Var. Class Code";
            comboBox_Unit.Text = "Select Device Var. Unit Code";
            numUDPreambles.Value = preambles;

            // Command 180 for DD Method

            txt_180DD_Transaction.Text = "1";
            txt_180DD_Fixed_1.Text = "0x00";
            txt_180DD_Fixed_1.ReadOnly = true;
            txt_180DD_Fixed_2.Text = "0x41";
            txt_180DD_Fixed_2.ReadOnly = true;
            txt_180DD_DataLength.Text = "00";
            checkBox_180DD_AutoLength.Checked = true;

            for (int i = 0; i < hexfloatArray.Length; i++)
                hexfloatArray[i] = "";
                
            // Define the border style of the form to a dialog box.
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Set the MaximizeBox to false to remove the maximize box.
            this.MaximizeBox = false;

            // Set the MinimizeBox to false to remove the minimize box.
            this.MinimizeBox = false;

            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
            
            //Set textboxes to read only
            txtHexGDC1.ReadOnly = true;
            txtHexGDC2.ReadOnly = true;
            txtHexGDC3.ReadOnly = true;
            txtHexGDC4.ReadOnly = true;
            txtobjGDC1.ReadOnly = true;
            txt_classObj.ReadOnly = true;

        }
        private void fillComboboxes()
        {
            foreach (var i in dv.list_of_classes)
            {
                string display_text_class = i.class_code.ToString() + " - " + i.class_name;
                comboBox_Class.Items.Add(display_text_class);
                dv_class_dic.Add(i.class_code, i.class_name);
                dv_units_obj_dic.Add(i.class_code, i.gdc_obj_number);
                string header_class = "--- " + i.class_name + " --------------------------";
                comboBox_Unit.Items.Add(header_class);

                foreach (var j in i.units)
                {
                    string display_text_unit = j.Key.ToString() + " - " + j.Value;
                    dv_units_dic.Add(j.Key, j.Value);
                    comboBox_Unit.Items.Add(display_text_unit);
                }

            }
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
            //calculateFloatToHex();
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
        public string HexToStringDec(string num)
        {
            num = num.Trim();
            num = num.Replace(" ", "");
            int decValue = Convert.ToInt32(num, 16);
            return decValue.ToString();
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
        private string ToHexString(float f, bool swap)
        {
            byte[] bytes = BitConverter.GetBytes(f);
            if (swap)
                Array.Reverse(bytes);
            var i = BitConverter.ToInt32(bytes, 0);
            String hex = ProcessString(i.ToString("X8"));
            return hex;

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
    
            //calculateFloatToHex();
            String data = txtData.Text;
            data = data.Replace(" ", "");
            String dataPreview = dataParser(data);
            txtTelegramPreview.Text = ProcessString(dataPreview + newLine);
        }

        private string calculateObjToHex(string value)
        {
            int decValue = Int32.Parse(value);
            String hexValue = decValue.ToString("X");
            int lengthOfHexValue = hexValue.Length;

            if (lengthOfHexValue % 2 == 0)
            {
                return ProcessString(hexValue);
            }
            else
            {
                return ProcessString("0" + hexValue);
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


        private void txtobjDec1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    
        private void txtHexHART1_KeyUp(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtHexHART1.Text))
            {
                String value = txtHexHART1.Text;
                ////Handle HEX whith whitespace and simple HEX ex: "00 00 00 3F"
                if (value.Length > 2)
                {
                    if (Char.IsWhiteSpace(value[2]))
                    {
                        txtHexHART1.MaxLength = 11;
                        len = 11;
                    }
                    else
                    {
                        txtHexHART1.MaxLength = 8;
                        len = 8;
                    }
                }

                if (value.Length == len)
                {
                    float result = FromHexString(value);
                    txtFloat1.Text = result.ToString();
                    txtHexGDC1.Text = ToHexString(result, true);
                }
            }
        }

        private void txtHexHART2_KeyUp(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtHexHART2.Text))
            {
                String value = txtHexHART2.Text;
                ////Handle HEX whith whitespace and simple HEX ex: "00 00 00 3F"
                if (value.Length > 2)
                {
                    if (Char.IsWhiteSpace(value[2]))
                    {
                        txtHexHART2.MaxLength = 11;
                        len = 11;
                    }
                    else
                    {
                        txtHexHART2.MaxLength = 8;
                        len = 8;
                    }
                }

                if (value.Length == len)
                {
                    float result = FromHexString(value);
                    txtFloat2.Text = result.ToString();
                    txtHexGDC2.Text = ToHexString(result, true);
                }
            }
        }

            private void txtHexHART3_KeyUp(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtHexHART3.Text))
            {
                String value = txtHexHART3.Text;
                ////Handle HEX whith whitespace and simple HEX ex: "00 00 00 3F"
                if (value.Length > 2)
                {
                    if (Char.IsWhiteSpace(value[2]))
                    {
                        txtHexHART3.MaxLength = 11;
                        len = 11;
                    }
                    else
                    {
                        txtHexHART3.MaxLength = 8;
                        len = 8;
                    }
                }

               if (value.Length == len)
                {
                    float result = FromHexString(value);
                    txtFloat3.Text = result.ToString();
                    txtHexGDC3.Text = ToHexString(result, true);
               }
            }
        }

        private void txtHexHART4_KeyUp(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtHexHART4.Text))
            {
                String value = txtHexHART4.Text;
                ////Handle HEX whith whitespace and simple HEX ex: "00 00 00 3F"
                if (value.Length > 2)
                {
                    if (Char.IsWhiteSpace(value[2]))
                    {
                        txtHexHART4.MaxLength = 11;
                        len = 11;
                    }
                    else
                    {
                        txtHexHART4.MaxLength = 8;
                        len = 8;
                    }             }

                if (value.Length == len)
                {
                    float result = FromHexString(value);
                    txtFloat4.Text = result.ToString();
                    txtHexGDC4.Text = ToHexString(result, true);
                }
            }
        }

        private void txtFloat1_KeyUp(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtFloat1.Text) && (txtFloat1.Text != "-"))
            {
                try
                {
                    float value = float.Parse(txtFloat1.Text, CultureInfo.InvariantCulture.NumberFormat);
                    hexfloatArray[0] = ToHexString(value, false);
                    txtHexHART1.Text = hexfloatArray[0];
                    hexfloatArrayGDC[0] = ToHexString(value, true);
                    txtHexGDC1.Text = hexfloatArrayGDC[0];
 
                }
                catch (Exception ex)
                {
                    txtTelegramPreview.Text = $"txtFloat1 throw: {ex.Message}";
                }
                
            }
        }

        private void txtFloat2_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (!String.IsNullOrWhiteSpace(txtFloat2.Text) && (txtFloat2.Text != "-"))
            {
                try
                {
                    float value = float.Parse(txtFloat2.Text, CultureInfo.InvariantCulture.NumberFormat);
                    hexfloatArray[0] = ToHexString(value, false);
                    txtHexHART2.Text = hexfloatArray[0];
                    hexfloatArrayGDC[0] = ToHexString(value, true);
                    txtHexGDC2.Text = hexfloatArrayGDC[0];
                }
                catch (Exception ex)
                {
                    txtTelegramPreview.Text = $"txtFloat2 throw: {ex.Message}";
                }
            }
            
        }

        private void txtFloat3_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (!String.IsNullOrWhiteSpace(txtFloat3.Text) && (txtFloat3.Text != "-"))
            {
                try
                {
                    float value = float.Parse(txtFloat3.Text, CultureInfo.InvariantCulture.NumberFormat);
                    hexfloatArray[0] = ToHexString(value, false);
                    txtHexHART3.Text = hexfloatArray[0];
                    hexfloatArrayGDC[0] = ToHexString(value, true);
                    txtHexGDC3.Text = hexfloatArrayGDC[0];
                }
                catch (Exception ex)
                {
                    txtTelegramPreview.Text = $"txtFloat3 throw: {ex.Message}";
                }
            }
            
        }

        private void txtFloat4_KeyUp(object sender, KeyEventArgs e)
        {
           
            if (!String.IsNullOrWhiteSpace(txtFloat4.Text) && (txtFloat4.Text != "-"))
            {
                try
                {
                    float value = float.Parse(txtFloat4.Text, CultureInfo.InvariantCulture.NumberFormat);
                    hexfloatArray[0] = ToHexString(value, false);
                    txtHexHART4.Text = hexfloatArray[0];
                    hexfloatArrayGDC[0] = ToHexString(value, true);
                    txtHexGDC4.Text = hexfloatArrayGDC[0];
                }
                catch (Exception ex)
                {
                    txtTelegramPreview.Text = $"txtFloat4 throw: {ex.Message}";
                }
            }
            
        }

        /// <summary>
        /// Reverse a ByteArray String from "00 00 00 3F" to "3F 00 00 00"
        /// </summary>
        /// <param name="byteArray"></param>
        /// <returns></returns>
        private String reverseByteArray(string byteArray)
        {
            String[] buffer = byteArray.Split(' ');
            String[] output = new String[10];
            int counter = 0;
            for (int i = (buffer.Length-1); i >=0; i--)
            {
                output[counter] = buffer[i];
                counter++;
            }
            return String.Join(" ", output);
        }
        private void txtobjDec1_KeyUp(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtobjDec1.Text))
            {
                String value = txtobjDec1.Text;
                String output = calculateObjToHex(value);
                txtobjHART1.Text = output;
                if (value.Length % 2 == 0)
                    txtobjGDC1.Text = reverseByteArray(output);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtTelegramPreview.Text);
        }

        private void txtobjHART1_Leave(object sender, EventArgs e)
        {
   
            String value = txtobjHART1.Text;
            value = value.Replace(" ", String.Empty);
            if (value.Length % 2 == 0)
            {
                String output = "";
                int spliceValue_B = 0;
                for (int i = 0; i < value.Length / 2; i++)
                {
                    String sp = value.Substring(spliceValue_B, 2);
                    if (i != (value.Length/2)-1)
                        sp += " ";
                    output += sp;
                    spliceValue_B +=2;
                }

                txtobjHART1.Text = output;
            }
        }

        private void txtHexHART1_Leave(object sender, EventArgs e)
        {
            String value = txtHexHART1.Text;
            value = value.Replace(" ", String.Empty);
            if (value.Length % 2 == 0)
            {
                String output = "";
                int spliceValue_B = 0;
                for (int i = 0; i < value.Length / 2; i++)
                {
                    String sp = value.Substring(spliceValue_B, 2);
                    if (i != (value.Length / 2) - 1)
                        sp += " ";
                    output += sp;
                    spliceValue_B += 2;
                }

                txtHexHART1.Text = output;
            }
        }

        private void txtHexHART2_Leave(object sender, EventArgs e)
        {
            String value = txtHexHART2.Text;
            value = value.Replace(" ", String.Empty);
            if (value.Length % 2 == 0)
            {
                String output = "";
                int spliceValue_B = 0;
                for (int i = 0; i < value.Length / 2; i++)
                {
                    String sp = value.Substring(spliceValue_B, 2);
                    if (i != (value.Length / 2) - 1)
                        sp += " ";
                    output += sp;
                    spliceValue_B += 2;
                }

                txtHexHART2.Text = output;
            }
        }

        private void txtHexHART3_Leave(object sender, EventArgs e)
        {
            String value = txtHexHART3.Text;
            value = value.Replace(" ", String.Empty);
            if (value.Length % 2 == 0)
            {
                String output = "";
                int spliceValue_B = 0;
                for (int i = 0; i < value.Length / 2; i++)
                {
                    String sp = value.Substring(spliceValue_B, 2);
                    if (i != (value.Length / 2) - 1)
                        sp += " ";
                    output += sp;
                    spliceValue_B += 2;
                }

                txtHexHART3.Text = output;
            }
        }

        private void txtHexHART4_Leave(object sender, EventArgs e)
        {
            String value = txtHexHART4.Text;
            value = value.Replace(" ", String.Empty);
            if (value.Length % 2 == 0)
            {
                String output = "";
                int spliceValue_B = 0;
                for (int i = 0; i < value.Length / 2; i++)
                {
                    String sp = value.Substring(spliceValue_B, 2);
                    if (i != (value.Length / 2) - 1)
                        sp += " ";
                    output += sp;
                    spliceValue_B += 2;
                }

                txtHexHART4.Text = output;
            }
        }

        private void txtUnitClass_KeyUp(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtUnitClass.Text))
            {
                int unit_to_search = int.Parse(txtUnitClass.Text);
                string value = "Not found";
                string gdc_value = "";

                if (dv_class_dic.ContainsKey(unit_to_search))
                {
                    value = dv_class_dic[unit_to_search];
                    gdc_value = dv_units_obj_dic[unit_to_search].ToString();
                }
                comboBox_Class.Text = value;
                txt_classObj.Text = gdc_value;
                txtUnitClassHEX.Text = unit_to_search.ToString("X");
            }
        }

        private void txtUnitCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtUnitCode.Text))
            {
                int unit_to_search = int.Parse(txtUnitCode.Text);
                string value = "Not found";
                if (dv_units_dic.ContainsKey(unit_to_search))
                {
                    value = dv_units_dic[unit_to_search];
                }
                comboBox_Unit.Text = value;
                txtUnitCodeHEX.Text = unit_to_search.ToString("X");
            }
        }

        private void comboBox_Unit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selection = comboBox_Unit.SelectedItem.ToString();

            if (!selection.StartsWith("-"))
            {
                string unit_code = selection.Split('-')[0].Trim();
                int unit_code_dec = int.Parse(unit_code);
                txtUnitCode.Text = unit_code;
                txtUnitCodeHEX.Text = unit_code_dec.ToString("X");
            }
        }

        private void comboBox_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = comboBox_Class.SelectedItem.ToString();

            if (!selection.StartsWith("-"))
            {
                string class_code = selection.Split('-')[0].Trim();
                int class_code_dec = int.Parse(class_code);
                txtUnitClass.Text = class_code;
                txtUnitClassHEX.Text = class_code_dec.ToString("X");

                string gdc_value = "";
                if (dv_units_obj_dic.ContainsKey(class_code_dec))
                {
                    gdc_value = dv_units_obj_dic[class_code_dec].ToString();
                }
                txt_classObj.Text = gdc_value;
            }
        }

        private void txtUnitCodeHEX_KeyUp(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtUnitCodeHEX.Text))
            {
                string unit_code = HexToStringDec(txtUnitCodeHEX.Text);
                txtUnitCode.Text = unit_code;
                
                int unit_to_search = int.Parse(unit_code);
                string value = "Not found";
                if (dv_units_dic.ContainsKey(unit_to_search))
                {
                    value = dv_units_dic[unit_to_search];
                }
                comboBox_Unit.Text = value;
            }
        }

        private void txtUnitClassHEX_KeyUp(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtUnitClassHEX.Text))
            {
                string unit_code = HexToStringDec(txtUnitClassHEX.Text);
                txtUnitClass.Text = unit_code;
                
                int unit_to_search = int.Parse(unit_code);
                string value = "Not found";
                string gdc_value = "";

                if (dv_class_dic.ContainsKey(unit_to_search))
                {
                    value = dv_class_dic[unit_to_search];
                    gdc_value = dv_units_obj_dic[unit_to_search].ToString();

                }
                comboBox_Class.Text = value;
                txt_classObj.Text = gdc_value;

            }
        }
        private string formatAsByteArray(string num)
        {
            if (num.Length > 2)
            {
                num = num.Replace(" ", String.Empty);

                String output = "";
                int spliceValue_B = 0;
                for (int i = 0; i < num.Length / 2; i++)
                {
                    String sp = num.Substring(spliceValue_B, 2);
                    if (i != (num.Length / 2) - 1)
                        sp += " ";
                    output += sp;
                    spliceValue_B += 2;
                }
                string[] splited = output.Split(' ');
                num = "";
                for (int i = splited.Length - 1; i >= 0; i--)
                {
                    num += splited[i] + " ";
                }
                num = num.Trim();
            }
            return num.ToUpper();
        }
        private void txtobjHART1_KeyUp(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtobjHART1.Text))
            {
                String value = txtobjHART1.Text;
                
                ////Handle HEX whith whitespace and simple HEX ex: "00 00 00 3F"
                if (value.Length > 2)
                {
                    bool wasWhiteSpaceInserted = Char.IsWhiteSpace(value[2]);
                    value = value.Replace(" ", "").Trim();
                    if (wasWhiteSpaceInserted)
                    {
                        txtobjHART1.MaxLength = 5;
                        len = 5;
                    }
                    else
                    {
                        txtobjHART1.MaxLength = 4;
                        len = 4;
                    }
                }

                if (value.Length % 2 == 0)
                {
                    string result = HexToStringDec(value);
                    txtobjDec1.Text = result.ToString();

                    // set in the gdc txt
                    
                    txtobjGDC1.Text = formatAsByteArray(value);
                }
            }
        }

        private void btn_180DD_Generate_Click(object sender, EventArgs e)
        {
            string transaction  = txt_180DD_Transaction.Text;
            transaction = DecToHex(transaction);

            string fixedValue_1 = "00";
            string fixedValue_2 = "41";

            string gdcObjNum = txt_180DD_ObjNum.Text;
            gdcObjNum = DecToHex(gdcObjNum);
            //txtTelegramPreview.AppendText(gdcObjNum + " ");
            
            string gdcSubNum = txt_180DD_SubNum.Text;
            gdcSubNum = DecToHex(gdcSubNum);
            //txtTelegramPreview.AppendText(gdcSubNum + " ");

            string dataLength = txt_180DD_DataLength.Text;
            dataLength = DecToHex(dataLength);
            //txtTelegramPreview.AppendText(dataLength + " ");

            string data = txt_180DD_Data.Text.Replace(" ", String.Empty);

            string buffer = transaction + fixedValue_1 + fixedValue_2 + gdcObjNum + gdcSubNum + dataLength + data;
            txtTelegramPreview.Text = ProcessString(buffer.ToUpper());
        }

        private void txt_180DD_Data_KeyUp(object sender, KeyEventArgs e)
        {
            if (checkBox_180DD_AutoLength.Checked == true)
                txt_180DD_DataLength.Text = DecToHex(getByteCount(txt_180DD_Data.Text));
            else
                return;
        }

        public int data180CharCounter = 0;
        //public char wasBackspacePressed;
        private void txt_180DD_Data_KeyPress(object sender, KeyPressEventArgs e)
        {
            wasBackspacePressed = e.KeyChar;
            if (!HexLetters.Contains(e.KeyChar)) e.Handled = true;
        }

        private void txt_180DD_Data_TextChanged(object sender, EventArgs e)
        {
            int selectionIndex = txt_180DD_Data.SelectionStart;
            int chars = txt_180DD_Data.Text.Length;
            int dataCharCounter = chars % 3;
            if (dataCharCounter == 2 && wasBackspacePressed != 0x08)
            {
                txt_180DD_Data.Text = txt_180DD_Data.Text.Insert(selectionIndex, " ");
                txt_180DD_Data.SelectionStart = selectionIndex + 1; // restore cursor position
            }
            if (chars > 1)
            {
                if (dataCharCounter == 0 && wasBackspacePressed == 0x08)
                {
                    txt_180DD_Data.Text = txt_180DD_Data.Text.Remove(chars - 1);
                    txt_180DD_Data.SelectionStart = selectionIndex + 1;
                }
            }
        }

        private void txtFloat1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 45 && e.KeyChar != 3 && e.KeyChar != 22 && e.KeyChar != 1))
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
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 45 && e.KeyChar != 3 && e.KeyChar != 22 && e.KeyChar != 1))
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
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 45 && e.KeyChar != 3 && e.KeyChar != 22 && e.KeyChar != 1))
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
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 45 && e.KeyChar != 3 && e.KeyChar != 22 && e.KeyChar != 1))
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

        private void btn_clearTelegramPreview_Click(object sender, EventArgs e)
        {
            txtTelegramPreview.Text = String.Empty;
        }
    }
}
