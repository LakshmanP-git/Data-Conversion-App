using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace DataConversionApp
{
    public partial class dataStorageConversion_frm : Form
    {
        public dataStorageConversion_frm()
        {
            InitializeComponent();
        }

        private void convert_btn_Click(object sender, EventArgs e)
        {
            RadioButton[] radioButtons = new RadioButton[10];
            radioButtons[0] = byte_rb;
            radioButtons[1] = kilobit_rb;
            radioButtons[2] = megabit_rb;
            radioButtons[3] = gigabit_rb;
            radioButtons[4] = terabit_rb;
            radioButtons[5] = byteConvert_rb;
            radioButtons[6] = kilobitConvert_rb;
            radioButtons[7] = megabitConvert_rb;
            radioButtons[8] = gigabitConvert_rb;
            radioButtons[9] = terabitConvert_rb;
            try
                {
                    //This initiates an int variable and assigns it to the value of valueToConvert_txt.Text but as an int
                    decimal valueToConvert = decimal.Parse(valueToConvert_txt.Text);
                    string typeToConvert = string.Empty;
                    string typeToBeConvertedTo = string.Empty;
                    if (byte_rb.Checked & !(kilobit_rb.Checked || megabit_rb.Checked || gigabit_rb.Checked || terabit_rb.Checked))
                    {
                        typeToConvert = "byte";
                    }
                    else if (kilobit_rb.Checked & !(byte_rb.Checked || megabit_rb.Checked || gigabit_rb.Checked || terabit_rb.Checked))
                    {
                        typeToConvert = "kilobit";
                    }
                    else if (megabit_rb.Checked & !(byte_rb.Checked || kilobit_rb.Checked || terabit_rb.Checked || gigabit_rb.Checked))
                    {
                        typeToConvert = "megabit";
                    }
                    else if (gigabit_rb.Checked & !(kilobit_rb.Checked || megabit_rb.Checked || byte_rb.Checked || terabit_rb.Checked))
                    {
                        typeToConvert = "gigabit";
                    }
                    else if (terabit_rb.Checked & !(kilobit_rb.Checked || megabit_rb.Checked || gigabit_rb.Checked || byte_rb.Checked))
                    {
                        typeToConvert = "terabit";
                    }
                    else
                    {
                        MessageBox.Show("You have selected too many radios.");
                    }

                    if (byteConvert_rb.Checked & !(kilobitConvert_rb.Checked || megabitConvert_rb.Checked || gigabitConvert_rb.Checked || terabitConvert_rb.Checked))
                    {
                        typeToBeConvertedTo = "byte";
                    }
                    else if (kilobitConvert_rb.Checked & !(byteConvert_rb.Checked || megabitConvert_rb.Checked || gigabitConvert_rb.Checked || terabitConvert_rb.Checked))
                    {
                        typeToBeConvertedTo = "kilobit";
                    }
                    else if (megabitConvert_rb.Checked & !(byteConvert_rb.Checked || kilobitConvert_rb.Checked || terabitConvert_rb.Checked || gigabitConvert_rb.Checked))
                    {
                        typeToBeConvertedTo = "megabit";
                    }
                    else if (gigabitConvert_rb.Checked & !(kilobitConvert_rb.Checked || megabitConvert_rb.Checked || byteConvert_rb.Checked || terabitConvert_rb.Checked))
                    {
                        typeToBeConvertedTo = "gigabit";
                    }
                    else if (terabitConvert_rb.Checked & !(kilobitConvert_rb.Checked || megabitConvert_rb.Checked || gigabitConvert_rb.Checked || byteConvert_rb.Checked))
                    {
                        typeToBeConvertedTo = "terabit";
                    }
                    else
                    {
                        MessageBox.Show("You have selected too many radios.");
                    }

                    decimal amountOfBytesConversion = 1m;
                    decimal amountOfKilobytesConversion = 1024m;
                    decimal amountOfMegabytesConversion = 1024m * 1024m;
                    decimal amountOfGigabyte = 1024m * 1024m * 1024m;
                    long amountOfTerabyte = 1099511627776;
                    string output = string.Empty;

                    switch (typeToConvert)
                    {
                        case "byte":
                            switch (typeToBeConvertedTo)
                            {
                                case "byte":
                                    output = (valueToConvert / amountOfBytesConversion).ToString(); 
                                    break;
                                case "kilobit":
                                    output = (valueToConvert / amountOfKilobytesConversion).ToString();
                                    break;
                                case "megabit":
                                    output = (valueToConvert / amountOfMegabytesConversion).ToString();
                                    break;
                                case "gigabit":
                                    output = (valueToConvert / amountOfGigabyte).ToString();
                                    break;
                                case "terabit":
                                    output = (valueToConvert / amountOfTerabyte).ToString();
                                    break;
                            }
                            break;
                        case "kilobit":
                            switch (typeToBeConvertedTo)
                            {
                                case "byte":
                                    output = (valueToConvert * amountOfKilobytesConversion).ToString();
                                    break;
                                case "kilobit":
                                    output = (valueToConvert / amountOfBytesConversion).ToString();
                                    break;
                                case "megabit":
                                    output = (valueToConvert / amountOfKilobytesConversion).ToString();
                                    break;  
                                case "gigabit": 
                                    output = (valueToConvert / amountOfGigabyte).ToString();
                                    break;
                                case "terabit":
                                    output = (valueToConvert / amountOfTerabyte).ToString();
                                    break;
                            }
                            break;
                        case "megabit":
                            switch (typeToBeConvertedTo)
                            {
                                case "byte":
                                    output = (valueToConvert * amountOfMegabytesConversion).ToString();
                                    break;
                                case "kilobit":
                                    output = (valueToConvert * amountOfKilobytesConversion).ToString();
                                    break;
                                case "megabit":
                                    output = (valueToConvert / amountOfBytesConversion).ToString();
                                    break;  
                                case "gigabit": 
                                    output = (valueToConvert / amountOfKilobytesConversion).ToString();
                                    break;
                                case "terabit":
                                    output = (valueToConvert / amountOfMegabytesConversion).ToString();
                                    break;
                            }
                            break;
                        case "gigabit":
                            switch (typeToBeConvertedTo)
                            {
                                case "byte":
                                    output = (valueToConvert * amountOfGigabyte).ToString();
                                    break;
                                case "kilobit":
                                    output = (valueToConvert * amountOfMegabytesConversion).ToString();
                                    break;
                                case "megabit":
                                    output = (valueToConvert / amountOfMegabytesConversion).ToString();
                                    break;
                                case "gigabit":
                                    output = (valueToConvert / amountOfBytesConversion).ToString();
                                    break;
                                case "terabit":
                                    output = (valueToConvert / amountOfKilobytesConversion).ToString();
                                    break;
                            }
                            break;
                        case "terabit":
                            switch (typeToBeConvertedTo)
                            {
                                case "byte":
                                    output = (valueToConvert * amountOfTerabyte).ToString();
                                    break;
                                case "kilobit":
                                    output = (valueToConvert * amountOfMegabytesConversion).ToString();
                                    break;
                                case "megabit":
                                    output = (valueToConvert / amountOfMegabytesConversion).ToString();
                                    break;
                                case "gigabit":
                                    output = (valueToConvert / amountOfKilobytesConversion).ToString();
                                    break;
                                case "terabit":
                                    output = (valueToConvert / amountOfBytesConversion).ToString();
                                    break;
                            }
                            break;

                        }
                convertOutput_txt.Text = output;

            }
                catch (FormatException)
                {
                    MessageBox.Show("You have given an incorrect input. Please try again.");
                }
        }
    }
}
