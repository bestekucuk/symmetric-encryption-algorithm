using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Class1
    {
       
        public string stringToBinary(string data)
        {
            bool formatBits = false;

            char[] buffer = new char[(((data.Length * 8) + (formatBits ? (data.Length - 1) : 0)))];
            int index = 0;
            for (int i = 0; i < data.Length; i++)
            {
                string binary = Convert.ToString(data[i], 2).PadLeft(8, '0');
                for (int j = 0; j < 8; j++)
                {
                    buffer[index] = binary[j];
                    index++;
                }
                if (formatBits && i < (data.Length - 1))
                {
                    buffer[index] = ' ';
                    index++;
                }
            }
            string a = new string(buffer);
            
            return a;

        }
        private string substitution(string data)
        {
            
            StringBuilder Data = new StringBuilder();
            Data.Append(data[2]);
            Data.Append(data[8]);
            Data.Append(data[12]);
            Data.Append(data[5]);
            Data.Append(data[9]);
            Data.Append(data[0]);
            Data.Append(data[14]);
            Data.Append(data[4]);
            Data.Append(data[11]);
            Data.Append(data[1]);
            Data.Append(data[15]);
            Data.Append(data[6]);
            Data.Append(data[3]);
            Data.Append(data[10]);
            Data.Append(data[7]);
            Data.Append(data[13]);
            string SData = Data.ToString();

            return SData;
        }

        public string ADD(string metin)
        {
            if (metin.Length % 2 == 0)
            {

                b_metin = stringToBinary(metin);
            }
            else
            {

                StringBuilder a = new StringBuilder();

                metin += a.Append("a");
                b_metin = stringToBinary(metin);
            }
            this.b_metin = b_metin;
            return this.b_metin;

        }
        private string metin, b_metin, key, b_key, S, sonuc;
        public string encrypt(string metin,string key)
        {
           
            b_key = stringToBinary(key);
            string data = this.b_metin=ADD(metin);
            string x_o_r = this.b_key;
            for (int i = 0; i < this.b_metin.Length; i += 16)
            {
                data = this.b_metin.Substring(i, 16);

                for (int j = 0; j < 64; j += 16) 
                {
                    
                    x_o_r = this.b_key.Substring(j, 16);
                    string sonuckey = "" ;
                    int beste = 0;
                    for (int k = 0; k< 16; k++)
                    {
                        beste= Convert.ToInt32(data[k]) ^ Convert.ToInt32(x_o_r[k]);
                        sonuckey += beste.ToString();
                    }
                    if (j < 32)
                    {
                        S = this.substitution(sonuckey);
                    }
                    else
                    {
                        S = sonuckey;
                    }

                    data = S;

                }
                this.sonuc += data;
            }

            return this.sonuc;
        }





















    }
}
