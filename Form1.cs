using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BinaryConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Convert readable text to binary
        private void toBinary_Click(object sender, EventArgs e)
        {
            // Conversion
            binaryRich.Text = "";
            string[] normalStream = normalRich.Lines;
            for (int i = 0; i < normalStream.Length; i++)
            {
                foreach (char c in normalStream[i])
                {
                    string hex = Convert.ToByte(c).ToString("x");
                    if (hex.Length == 1)
                    {
                        switch (hex)
                        {
                            case "0":
                                binaryRich.AppendText("00000000");
                                break;
                            case "1":
                                binaryRich.AppendText("00000001");
                                break;
                            case "2":
                                binaryRich.AppendText("00000010");
                                break;
                            case "3":
                                binaryRich.AppendText("00000011");
                                break;
                            case "4":
                                binaryRich.AppendText("00000100");
                                break;
                            case "5":
                                binaryRich.AppendText("00000101");
                                break;
                            case "6":
                                binaryRich.AppendText("00000110");
                                break;
                            case "7":
                                binaryRich.AppendText("00000111");
                                break;
                            case "8":
                                binaryRich.AppendText("00001000");
                                break;
                            case "9":
                                binaryRich.AppendText("00001001");
                                break;
                            case "a":
                                binaryRich.AppendText("00001010");
                                break;
                            case "b":
                                binaryRich.AppendText("00001011");
                                break;
                            case "c":
                                binaryRich.AppendText("00001100");
                                break;
                            case "d":
                                binaryRich.AppendText("00001101");
                                break;
                            case "e":
                                binaryRich.AppendText("00001110");
                                break;
                            case "f":
                                binaryRich.AppendText("00001111");
                                break;
                            default:
                                break;
                        }
                    }

                    // Process first character in hex value
                    else
                    {
                        switch (hex[0])
                        {
                            case '0':
                                binaryRich.AppendText("0000");
                                break;
                            case '1':
                                binaryRich.AppendText("0001");
                                break;
                            case '2':
                                binaryRich.AppendText("0010");
                                break;
                            case '3':
                                binaryRich.AppendText("0011");
                                break;
                            case '4':
                                binaryRich.AppendText("0100");
                                break;
                            case '5':
                                binaryRich.AppendText("0101");
                                break;
                            case '6':
                                binaryRich.AppendText("0110");
                                break;
                            case '7':
                                binaryRich.AppendText("0111");
                                break;
                            case '8':
                                binaryRich.AppendText("1000");
                                break;
                            case '9':
                                binaryRich.AppendText("1001");
                                break;
                            case 'a':
                                binaryRich.AppendText("1010");
                                break;
                            case 'b':
                                binaryRich.AppendText("1011");
                                break;
                            case 'c':
                                binaryRich.AppendText("1100");
                                break;
                            case 'd':
                                binaryRich.AppendText("1101");
                                break;
                            case 'e':
                                binaryRich.AppendText("1110");
                                break;
                            case 'f':
                                binaryRich.AppendText("1111");
                                break;
                            default:
                                break;
                        }
                        // Process second character in hex value
                        switch (hex[1])
                        {
                            case '0':
                                binaryRich.AppendText("0000");
                                break;
                            case '1':
                                binaryRich.AppendText("0001");
                                break;
                            case '2':
                                binaryRich.AppendText("0010");
                                break;
                            case '3':
                                binaryRich.AppendText("0011");
                                break;
                            case '4':
                                binaryRich.AppendText("0100");
                                break;
                            case '5':
                                binaryRich.AppendText("0101");
                                break;
                            case '6':
                                binaryRich.AppendText("0110");
                                break;
                            case '7':
                                binaryRich.AppendText("0111");
                                break;
                            case '8':
                                binaryRich.AppendText("1000");
                                break;
                            case '9':
                                binaryRich.AppendText("1001");
                                break;
                            case 'a':
                                binaryRich.AppendText("1010");
                                break;
                            case 'b':
                                binaryRich.AppendText("1011");
                                break;
                            case 'c':
                                binaryRich.AppendText("1100");
                                break;
                            case 'd':
                                binaryRich.AppendText("1101");
                                break;
                            case 'e':
                                binaryRich.AppendText("1110");
                                break;
                            case 'f':
                                binaryRich.AppendText("1111");
                                break;
                            default:
                                break;
                        }
                    }
                }

                //newline
                if(i != normalStream.Length - 1)
                {
                    binaryRich.AppendText("00001010");
                }
            }
        }


        // Convert binary to readable text
        private void toText_Click(object sender, EventArgs e)
        {
            // Filter out non-binary characters. Symbols resembling 0 and 1 are accepted
            string binaryStream = "";
            var sb = new System.Text.StringBuilder();
            normalRich.Text = "";
            foreach (char c in binaryRich.Text)
            {
                if (c == '0' || c == 'o' || c == 'O')
                {
                    sb.Append("0");
                }
                if(c == '1' || c == 'l' || c == 'I' || c == 'i' || c == '!')
                {
                    sb.Append("1");
                }
            }
            binaryStream = sb.ToString();


            // Convert binary
            int i = 0;
            int len = binaryStream.Length;
            while (i < len)
            {
                // Make sure we read an 8 bit substring, otherwise stop
                if (((len - i) - 8) < 0)
                {
                    return;
                }

                // Process binary string. Switch case for each individual character to avoid unnecesary ascii values
                switch(binaryStream.Substring(i, 8))
                {
                    case "00001010":
                        normalRich.AppendText("\n");
                        break;
                    case "00001001":
                        normalRich.AppendText("\t");
                        break;
                    case "00001011":
                        normalRich.AppendText("\t");
                        break;
                    case "00100000":
                        normalRich.AppendText(" ");
                        break;
                    case "00100001":
                        normalRich.AppendText("!");
                        break;
                    case "00100010":
                        normalRich.AppendText("\"");
                        break;
                    case "00100011":
                        normalRich.AppendText("#");
                        break;
                    case "00100100":
                        normalRich.AppendText("$");
                        break;
                    case "00100101":
                        normalRich.AppendText("%");
                        break;
                    case "00100110":
                        normalRich.AppendText("&");
                        break;
                    case "00100111":
                        normalRich.AppendText("\'");
                        break;
                    case "00101000":
                        normalRich.AppendText("(");
                        break;
                    case "00101001":
                        normalRich.AppendText(")");
                        break;
                    case "00101010":
                        normalRich.AppendText("*");
                        break;
                    case "00101011":
                        normalRich.AppendText("+");
                        break;
                    case "00101100":
                        normalRich.AppendText(",");
                        break;
                    case "00101101":
                        normalRich.AppendText("-");
                        break;
                    case "00101110":
                        normalRich.AppendText(".");
                        break;
                    case "00101111":
                        normalRich.AppendText("/");
                        break;
                    case "00110000":
                        normalRich.AppendText("0");
                        break;
                    case "00110001":
                        normalRich.AppendText("1");
                        break;
                    case "00110010":
                        normalRich.AppendText("2");
                        break;
                    case "00110011":
                        normalRich.AppendText("3");
                        break;
                    case "00110100":
                        normalRich.AppendText("4");
                        break;
                    case "00110101":
                        normalRich.AppendText("5");
                        break;
                    case "00110110":
                        normalRich.AppendText("6");
                        break;
                    case "00110111":
                        normalRich.AppendText("7");
                        break;
                    case "00111000":
                        normalRich.AppendText("8");
                        break;
                    case "00111001":
                        normalRich.AppendText("9");
                        break;
                    case "00111010":
                        normalRich.AppendText(":");
                        break;
                    case "00111011":
                        normalRich.AppendText(";");
                        break;
                    case "00111100":
                        normalRich.AppendText("<");
                        break;
                    case "00111101":
                        normalRich.AppendText("=");
                        break;
                    case "00111110":
                        normalRich.AppendText(">");
                        break;
                    case "00111111":
                        normalRich.AppendText("?");
                        break;
                    case "01000000":
                        normalRich.AppendText("@");
                        break;
                    case "01000001":
                        normalRich.AppendText("A");
                        break;
                    case "01000010":
                        normalRich.AppendText("B");
                        break;
                    case "01000011":
                        normalRich.AppendText("C");
                        break;
                    case "01000100":
                        normalRich.AppendText("D");
                        break;
                    case "01000101":
                        normalRich.AppendText("E");
                        break;
                    case "01000110":
                        normalRich.AppendText("F");
                        break;
                    case "01000111":
                        normalRich.AppendText("G");
                        break;
                    case "01001000":
                        normalRich.AppendText("H");
                        break;
                    case "01001001":
                        normalRich.AppendText("I");
                        break;
                    case "01001010":
                        normalRich.AppendText("J");
                        break;
                    case "01001011":
                        normalRich.AppendText("K");
                        break;
                    case "01001100":
                        normalRich.AppendText("L");
                        break;
                    case "01001101":
                        normalRich.AppendText("M");
                        break;
                    case "01001110":
                        normalRich.AppendText("N");
                        break;
                    case "01001111":
                        normalRich.AppendText("O");
                        break;
                    case "01010000":
                        normalRich.AppendText("P");
                        break;
                    case "01010001":
                        normalRich.AppendText("Q");
                        break;
                    case "01010010":
                        normalRich.AppendText("R");
                        break;
                    case "01010011":
                        normalRich.AppendText("S");
                        break;
                    case "01010100":
                        normalRich.AppendText("T");
                        break;
                    case "01010101":
                        normalRich.AppendText("U");
                        break;
                    case "01010110":
                        normalRich.AppendText("V");
                        break;
                    case "01010111":
                        normalRich.AppendText("W");
                        break;
                    case "01011000":
                        normalRich.AppendText("X");
                        break;
                    case "01011001":
                        normalRich.AppendText("Y");
                        break;
                    case "01011010":
                        normalRich.AppendText("Z");
                        break;
                    case "01011011":
                        normalRich.AppendText("[");
                        break;
                    case "01011100":
                        normalRich.AppendText("\\");
                        break;
                    case "01011101":
                        normalRich.AppendText("]");
                        break;
                    case "01011110":
                        normalRich.AppendText("^");
                        break;
                    case "01011111":
                        normalRich.AppendText("_");
                        break;
                    case "01100000":
                        normalRich.AppendText("`");
                        break;
                    case "01100001":
                        normalRich.AppendText("a");
                        break;
                    case "01100010":
                        normalRich.AppendText("b");
                        break;
                    case "01100011":
                        normalRich.AppendText("c");
                        break;
                    case "01100100":
                        normalRich.AppendText("d");
                        break;
                    case "01100101":
                        normalRich.AppendText("e");
                        break;
                    case "01100110":
                        normalRich.AppendText("f");
                        break;
                    case "01100111":
                        normalRich.AppendText("g");
                        break;
                    case "01101000":
                        normalRich.AppendText("h");
                        break;
                    case "01101001":
                        normalRich.AppendText("i");
                        break;
                    case "01101010":
                        normalRich.AppendText("j");
                        break;
                    case "01101011":
                        normalRich.AppendText("k");
                        break;
                    case "01101100":
                        normalRich.AppendText("l");
                        break;
                    case "01101101":
                        normalRich.AppendText("m");
                        break;
                    case "01101110":
                        normalRich.AppendText("n");
                        break;
                    case "01101111":
                        normalRich.AppendText("o");
                        break;
                    case "01110000":
                        normalRich.AppendText("p");
                        break;
                    case "01110001":
                        normalRich.AppendText("q");
                        break;
                    case "01110010":
                        normalRich.AppendText("r");
                        break;
                    case "01110011":
                        normalRich.AppendText("s");
                        break;
                    case "01110100":
                        normalRich.AppendText("t");
                        break;
                    case "01110101":
                        normalRich.AppendText("u");
                        break;
                    case "01110110":
                        normalRich.AppendText("v");
                        break;
                    case "01110111":
                        normalRich.AppendText("w");
                        break;
                    case "01111000":
                        normalRich.AppendText("x");
                        break;
                    case "01111001":
                        normalRich.AppendText("y");
                        break;
                    case "01111010":
                        normalRich.AppendText("z");
                        break;
                    case "01111011":
                        normalRich.AppendText("{");
                        break;
                    case "01111100":
                        normalRich.AppendText("|");
                        break;
                    case "01111101":
                        normalRich.AppendText("}");
                        break;
                    case "01111110":
                        normalRich.AppendText("~");
                        break;
                    default:
                        break;
                }
                i += 8;
            }
        }

        //Read text from file
        private void importTextFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog read = new OpenFileDialog();
            read.Filter = "Text File|*.txt";
            read.Title = "Open text file";
            read.ShowDialog();

            if(!(read.FileName == ""))
            {
                normalRich.Text = "";
                string[] lines = File.ReadAllLines(read.FileName);
                for(int i = 0; i < lines.Length-1; i++)
                {
                    normalRich.AppendText(lines[i] + "\r\n");
                }
                normalRich.AppendText(lines[lines.Length - 1]);
            }
        }

        //Read binary from file
        private void importBinaryFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog read = new OpenFileDialog();
            read.Filter = "Text File|*.txt";
            read.Title = "Open binary file";
            read.ShowDialog();

            if (!(read.FileName == ""))
            {
                binaryRich.Text = "";
                string[] lines = File.ReadAllLines(read.FileName);
                for (int i = 0; i < lines.Length; i++)
                {
                    binaryRich.AppendText(lines[i]);
                }
            }
        }

        //Save text to file
        private void saveTextToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text File|*.txt";
            save.Title = "Save text to file";
            save.ShowDialog();

            if(!(save.FileName == ""))
            {
                StreamWriter file = new StreamWriter(save.FileName);
                string[] toWrite = normalRich.Lines;
                for(int i = 0; i < toWrite.Length - 1; i++)
                {
                    file.WriteLine(toWrite[i]);
                }
                file.Write(toWrite[toWrite.Length - 1]);
                file.Close();
            }
        }

        //Save binary to file
        private void saveBinaryToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text File|*.txt";
            save.Title = "Save binary to file";
            save.ShowDialog();

            if (!(save.FileName == ""))
            {
                StreamWriter file = new StreamWriter(save.FileName);
                string[] toWrite = binaryRich.Lines;
                for (int i = 0; i < toWrite.Length; i++)
                {
                    file.Write(toWrite[i]);
                }
                file.Close();
            }
        }

        //Close program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Show program information
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }
    }
}
